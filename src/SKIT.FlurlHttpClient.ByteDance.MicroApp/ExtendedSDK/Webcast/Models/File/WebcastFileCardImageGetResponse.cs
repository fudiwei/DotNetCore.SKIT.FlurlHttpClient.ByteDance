namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /file/card_image/get 接口的响应。</para>
    /// </summary>
    public class WebcastFileCardImageGetResponse : DouyinMicroAppWebcastResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_id")]
                [System.Text.Json.Serialization.JsonPropertyName("image_id")]
                public string ImageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置图片状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_status")]
                [System.Text.Json.Serialization.JsonPropertyName("image_status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置审核意见。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_opinion")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_opinion")]
                public string? AuditOpinion { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images_status")]
        [System.Text.Json.Serialization.JsonPropertyName("images_status")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
