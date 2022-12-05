namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/downloadSettleItemToShop 接口的响应。</para>
    /// </summary>
    public class OrderDownloadSettleItemToShopResponse : DouyinShopResponse<OrderDownloadSettleItemToShopResponse.Types.Data>
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
                /// 获取或设置下载 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("download_id")]
                [System.Text.Json.Serialization.JsonPropertyName("download_id")]
                public string? DownloadId { get; set; }
            }
        }
    }
}
