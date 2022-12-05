namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/downloadToShop 接口的响应。</para>
    /// </summary>
    public class OrderDownloadToShopResponse : DouyinShopResponse<OrderDownloadToShopResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置返回编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string ReturnCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置返回信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("code_msg")]
                public string? ReturnMessage { get; set; }

                /// <summary>
                /// 获取或设置下载链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? DownloadUrl { get; set; }
            }
        }
    }
}
