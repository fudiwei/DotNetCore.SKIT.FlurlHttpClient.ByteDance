namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/file/video/delete 接口的响应。</para>
    /// </summary>
    public class FileVideoDeleteResponse : OceanEngineResponse<FileVideoDeleteResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置删除失败的视频 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_video_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_video_ids")]
                public string[] FailedVideoIdList { get; set; } = default!;
            }
        }
    }
}
