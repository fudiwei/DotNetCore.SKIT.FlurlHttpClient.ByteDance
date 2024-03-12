namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /task/posting/user/ 接口的响应。</para>
    /// </summary>
    public class TaskPostingUserResponse : DouyinOpenResponse<TaskPostingUserResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置核销结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public bool Result { get; set; }
            }
        }
    }
}
