namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /return_refund/{version}/reject_reasons 接口的响应。</para>
    /// </summary>
    public class ReturnRefundGetRejectReasonsResponse : TikTokShopResponse<ReturnRefundGetRejectReasonsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Reason
                    {
                        /// <summary>
                        /// 获取或设置取消原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置取消原因文本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public string Text { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置原因列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reasons")]
                [System.Text.Json.Serialization.JsonPropertyName("reasons")]
                public Types.Reason[] ReasonList { get; set; } = default!;
            }
        }
    }
}
