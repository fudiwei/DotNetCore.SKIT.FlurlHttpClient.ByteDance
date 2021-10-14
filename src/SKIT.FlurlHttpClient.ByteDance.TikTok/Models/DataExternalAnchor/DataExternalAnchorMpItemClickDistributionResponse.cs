using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/anchor/mp_item_click_distribution 接口的响应。</para>
    /// </summary>
    public class DataExternalAnchorMpItemClickDistributionResponse : TikTokResponse<DataExternalAnchorMpItemClickDistributionResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date")]
                        [System.Text.Json.Serialization.JsonPropertyName("date")]
                        public string DateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序点击量视频分布字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_item_click_json")]
                        [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonItemClickDistributionMapConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_item_click_json")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonItemClickDistributionMapConverter))]
                        public IDictionary<string, int> ItemClickDistributionMap { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result_list")]
                [System.Text.Json.Serialization.JsonPropertyName("result_list")]
                public Types.Result[] ResultList { get; set; } = default!;
            }
        }
    
        internal static class Converters
        {
            internal class NewtonsoftJsonItemClickDistributionMapConverter : Newtonsoft.Json.JsonConverter<IDictionary<string, int>?>
            {
                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override IDictionary<string, int>? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, IDictionary<string, int>? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
                    {
                        return existingValue;
                    }
                    else if (reader.TokenType == Newtonsoft.Json.JsonToken.String)
                    {
                        string? value = serializer.Deserialize<string>(reader);
                        if (value == null)
                            return existingValue;

                        return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, int>>(value);
                    }

                    throw new Newtonsoft.Json.JsonReaderException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, IDictionary<string, int>? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (value != null)
                        writer.WriteValue(Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.None));
                    else
                        writer.WriteNull();
                }
            }

            internal class SystemTextJsonItemClickDistributionMapConverter : System.Text.Json.Serialization.JsonConverter<IDictionary<string, int>?>
            {
                public override IDictionary<string, int>? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
                {
                    if (reader.TokenType == System.Text.Json.JsonTokenType.Null)
                    {
                        return null;
                    }
                    else if (reader.TokenType == System.Text.Json.JsonTokenType.String)
                    {
                        string? value = reader.GetString();
                        if (value == null)
                            return null;

                        return System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, int>>(value, options);
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, IDictionary<string, int>? value, System.Text.Json.JsonSerializerOptions options)
                {
                    if (value != null)
                        writer.WriteStringValue(System.Text.Json.JsonSerializer.Serialize(value, options));
                    else
                        writer.WriteNullValue();
                }
            }
        }
    }
}
