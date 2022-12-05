namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/simplePlan 接口的响应。</para>
    /// </summary>
    public class BuyinSimplePlanResponse : DouyinShopResponse<BuyinSimplePlanResponse.Types.Data>
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
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置是否成功。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_success")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_success")]
                        public bool IsSuccessful { get; set; }

                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("error_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("error_code")]
                        public int ErrorCode { get; set; }

                        /// <summary>
                        /// 获取或设置错误原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("error_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("error_msg")]
                        public string ErrorMessage { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置操作的商品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置操作结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public Types.Result[] ResultList { get; set; } = default!;
            }
        }
    }
}
