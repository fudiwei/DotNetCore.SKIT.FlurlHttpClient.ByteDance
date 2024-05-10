namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/uploadfile 接口的响应。</para>
    /// </summary>
    public class FulfillmentUploadFileResponse : TikTokShopLegacyResponse<FulfillmentUploadFileResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置文件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_id")]
                [System.Text.Json.Serialization.JsonPropertyName("file_id")]
                public string FileId { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_name")]
                [System.Text.Json.Serialization.JsonPropertyName("file_name")]
                public string FileName { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_type")]
                [System.Text.Json.Serialization.JsonPropertyName("file_type")]
                public string FileType { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_url")]
                [System.Text.Json.Serialization.JsonPropertyName("file_url")]
                public string FileUrl { get; set; } = default!;
            }
        }
    }
}
