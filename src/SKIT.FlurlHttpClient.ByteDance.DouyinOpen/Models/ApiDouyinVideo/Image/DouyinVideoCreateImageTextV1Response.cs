namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/video/create_image_text 接口的响应。</para>
    /// </summary>
    public class DouyinVideoCreateImageTextV1Response : DouyinOpenResponse<DouyinVideoCreateImageTextV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_id")]
                [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                public string VideoId { get; set; } = default!;

                /// <summary>
                /// 获取或设置视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_id")]
                [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                public string ItemId { get; set; } = default!;
            }
        }
    }
}
