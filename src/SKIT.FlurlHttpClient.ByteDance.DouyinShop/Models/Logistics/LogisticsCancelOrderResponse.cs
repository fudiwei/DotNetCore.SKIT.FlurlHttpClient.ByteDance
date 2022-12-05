namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/cancelOrder 接口的响应。</para>
    /// </summary>
    public class LogisticsCancelOrderResponse : DouyinShopResponse<LogisticsCancelOrderResponse.Types.Data>
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
                        /// 获取或设置是否成功。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("success")]
                        [System.Text.Json.Serialization.JsonPropertyName("success")]
                        public bool? IsSucceeded { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结果信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cancel_result")]
                [System.Text.Json.Serialization.JsonPropertyName("cancel_result")]
                public Types.Result Result { get; set; } = default!;
            }
        }
    }
}
