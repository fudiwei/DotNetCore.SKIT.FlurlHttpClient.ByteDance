namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/poi/service_base 接口的响应。</para>
    /// </summary>
    public class DataExternalPOIServiceBaseResponse : DouyinOpenResponse<DataExternalPOIServiceBaseResponse.Types.Data>
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
                        /// 获取或设置曝光 UV。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exposure_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("exposure_uv")]
                        public int ExposureUV { get; set; }

                        /// <summary>
                        /// 获取或设置点击 UV。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("click_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("click_uv")]
                        public int ClickUV { get; set; }

                        /// <summary>
                        /// 获取或设置订单成交量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("success_order_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("success_order_cnt")]
                        public int SuccessOrderCount { get; set; }
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
    }
}
