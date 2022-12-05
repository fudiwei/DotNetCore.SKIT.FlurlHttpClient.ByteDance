using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/anchor/mp_item_click_distribution 接口的响应。</para>
    /// </summary>
    public class DataExternalAnchorMpItemClickDistributionResponse : DouyinOpenResponse<DataExternalAnchorMpItemClickDistributionResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
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
                        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyItemClickDistributionMapNewtonsoftJsonConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_item_click_json")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyItemClickDistributionMapSystemTextJsonConverter))]
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
            internal class ResponsePropertyItemClickDistributionMapNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<IDictionary<string, int>?>
            {
            }

            internal class ResponsePropertyItemClickDistributionMapSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<IDictionary<string, int>?>
            {
            }
        }
    }
}
