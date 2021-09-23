using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Interceptors
{
    internal partial class TikTokShopMarshalJsonInterceptor : FlurlHttpCallInterceptor
    {
        public override async Task BeforeCallAsync(FlurlCall flurlCall)
        {
            if (flurlCall == null) throw new ArgumentNullException(nameof(flurlCall));

            try
            {
                if (flurlCall.HttpRequestMessage.Content is MultipartFormDataContent)
                {
                    var oldFormdataContent = (MultipartFormDataContent)flurlCall.HttpRequestMessage.Content;
                    var oldParamHttpContent = oldFormdataContent.SingleOrDefault(e => Constants.FormDataFields.FORMDATA_PARAM_JSON.Equals(e.Headers.ContentDisposition?.Name?.Trim('\"')));
                    if (oldParamHttpContent != null)
                    {
                        string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
                        var newFormdataContent = new MultipartFormDataContent(boundary);

                        string paramJson = await oldParamHttpContent.ReadAsStringAsync().ConfigureAwait(false);
                        paramJson = MarshalJson(paramJson);

                        foreach (var item in oldFormdataContent)
                        {
                            if (item == oldParamHttpContent)
                                continue;

                            if (string.IsNullOrEmpty(item.Headers.ContentDisposition.FileName))
                                newFormdataContent.Add(item, item.Headers.ContentDisposition.Name);
                            else
                                newFormdataContent.Add(item, item.Headers.ContentDisposition.Name, item.Headers.ContentDisposition.FileName);
                        }

                        var newParamHttpContent = new StringContent(paramJson, Encoding.UTF8, "application/json");
                        newFormdataContent.Add(newParamHttpContent, Constants.FormDataFields.FORMDATA_PARAM_JSON);
                        flurlCall.HttpRequestMessage.Content = newFormdataContent;

                        oldFormdataContent.Dispose();
                    }
                }
                else
                {
                    string paramJson = flurlCall.RequestBody;
                    paramJson = MarshalJson(flurlCall.RequestBody);

                    if (!string.IsNullOrEmpty(paramJson))
                    {
                        var oldParamHttpContent = flurlCall.HttpRequestMessage.Content;

                        var newParamHttpContent = new ByteArrayContent(Encoding.UTF8.GetBytes(paramJson));
                        newParamHttpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json; charset=UTF-8");
                        flurlCall.HttpRequestMessage.Content = newParamHttpContent;

                        oldParamHttpContent.Dispose();
                    }
                }
            }
            catch (Exceptions.TikTokShopRequestSignatureException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exceptions.TikTokShopRequestMarshalException("Marshal request failed. Please see the `InnerException` for more details.", ex);
            }
        }
    }

    partial class TikTokShopMarshalJsonInterceptor
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

        private class JObjectConverter : JsonConverter
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

        private class JValueConverter : JsonConverter
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
