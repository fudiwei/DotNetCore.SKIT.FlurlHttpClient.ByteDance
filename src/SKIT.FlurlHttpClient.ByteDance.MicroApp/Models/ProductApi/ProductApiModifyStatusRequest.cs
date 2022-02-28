namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/api/modify_status 接口的请求。</para>
    /// </summary>
    public class ProductApiModifyStatusRequest : ByteDanceMicroAppRequest
    {
        public static class Types
        {
            public class ProductStatusInfo
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string? AppId { get; set; }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public long? ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置商品状态信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_status_info")]
        [System.Text.Json.Serialization.JsonPropertyName("product_status_info")]
        public Types.ProductStatusInfo ProductStatusInfo { get; set; } = new Types.ProductStatusInfo();
    }
}
