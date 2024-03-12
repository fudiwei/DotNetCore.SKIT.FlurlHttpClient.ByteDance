namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /task/posting/bind_video/ 接口的响应。</para>
    /// </summary>
    public class TaskPostingBindVideoResponse : DouyinOpenResponse<TaskPostingBindVideoResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }
        }
    }
}
