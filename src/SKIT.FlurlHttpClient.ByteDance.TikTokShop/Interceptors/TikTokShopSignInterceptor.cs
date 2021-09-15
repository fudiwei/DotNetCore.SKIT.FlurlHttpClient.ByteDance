using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Interceptors
{
    internal partial class TikTokShopSignInterceptor : FlurlHttpCallInterceptor
    {
        private readonly string _signMethod;
        private readonly string _appKey;
        private readonly string _appSecret;

        public TikTokShopSignInterceptor(string signMethod, string appKey, string appSecret)
        {
            _signMethod = signMethod;
            _appKey = appKey;
            _appSecret = appSecret;
        }

        public override Task BeforeCallAsync(FlurlCall flurlCall)
        {
            if (flurlCall == null) throw new ArgumentNullException(nameof(flurlCall));

            var queries = HttpUtility.ParseQueryString(flurlCall.HttpRequestMessage.RequestUri?.Query ?? string.Empty);
            string method = queries.Get("method") ?? string.Empty;
            string version = queries.Get("v") ?? string.Empty;
            string body = flurlCall.RequestBody;
            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();

            string signText;

            try
            {
                string paramJson = MarshalJson(body);
                string plainText = $"app_key{_appKey}method{method}param_json{paramJson}timestamp{timestamp}v{version}{_appSecret}";

                switch (_signMethod)
                {
                    case Constants.SignAlgorithms.MD5:
                        {
                            signText = Security.MD5Utility.Hash(plainText);
                        }
                        break;

                    case Constants.SignAlgorithms.HMAC_SHA256:
                        {
                            signText = Security.HMACSHA256Utility.Hash(_appSecret, plainText);
                        }
                        break;

                    default:
                        throw new Exceptions.TikTokShopRequestSignatureException("Unsupported sign method.");
                }
            }
            catch (Exceptions.TikTokShopRequestSignatureException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exceptions.TikTokShopRequestSignatureException("Generate signature of request failed. Please see the `InnerException` for more details.", ex);
            }

            flurlCall.Request.SetQueryParam("app_key", _appKey);
            flurlCall.Request.SetQueryParam("sign_method", _signMethod);
            flurlCall.Request.SetQueryParam("sign", signText);
            flurlCall.Request.SetQueryParam("timestamp", timestamp);

            return Task.CompletedTask;
        }
    }

    partial class TikTokShopSignInterceptor
    {
        public string MarshalJson(string json)
        {
            // 1、确保所有层级上 Key 的有序性
            // 2、确保所有数值不带多余的小数点（即 1.0 → 1）

            if (string.IsNullOrEmpty(json))
                return string.Empty;

            var jObject = JsonConvert.DeserializeObject(json);
            var settings = new JsonSerializerSettings();
            settings.Converters = new List<JsonConverter> { new JObjectConverter(), new JValueConverter() };
            return JsonConvert.SerializeObject(jObject, Formatting.None, settings);
        }

        class JObjectConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(JObject);
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                writer.WriteStartObject();

                var jObject = (JObject)value!;
                var props = jObject.Properties().OrderBy(i => i.Name).ToList();
                foreach (var prop in props)
                {
                    writer.WritePropertyName(prop.Name);
                    serializer.Serialize(writer, prop.Value);
                }

                writer.WriteEndObject();
            }

            public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
            {
                return serializer.Deserialize(reader, objectType) ?? existingValue;
            }
        }

        class JValueConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(JValue);
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                var jVal = (JValue)value!;
                if (jVal.Type == JTokenType.Float ||
                    jVal.Type == JTokenType.String)
                {
                    double d;

                    if (jVal.Type == JTokenType.String)
                    {
                        if (!double.TryParse(jVal.Value?.ToString(), out d))
                        {
                            writer.WriteValue(value);
                            return;
                        }
                    }
                    else
                    {
                        d = Convert.ToDouble(jVal.Value);
                    }                 

                    long i = (long)d;
                    if (Math.Abs(i - d) == 0)
                    {
                        writer.WriteValue(i);
                        return;
                    }
                }

                writer.WriteValue(value);
            }

            public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
            {
                return serializer.Deserialize(reader, objectType) ?? existingValue;
            }
        }
    }
}
