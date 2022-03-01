namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/Operate 接口的响应。</para>
    /// </summary>
    public class AftersaleOperateResponse : TikTokShopResponse<AftersaleOperateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置售后单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aftersale_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string AftersaleId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置操作结果码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("status_code")]
                        public int StatusCode { get; set; }

                        /// <summary>
                        /// 获取或设置操作结果描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("status_msg")]
                        public string? StatusMessage { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置审核结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public Types.Result[] ResultList { get; set; } = default!;
            }
        }
    }
}
