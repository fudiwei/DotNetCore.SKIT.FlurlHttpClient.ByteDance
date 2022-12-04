namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/create 接口的响应。</para>
    /// </summary>
    public class VideoCreateResponse : DouyinOpenResponse<VideoCreateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
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
