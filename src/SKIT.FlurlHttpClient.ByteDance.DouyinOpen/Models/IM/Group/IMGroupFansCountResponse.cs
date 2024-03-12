namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /im/group/fans/count/ 接口的响应。</para>
    /// </summary>
    public class IMGroupFansCountResponse : DouyinOpenResponse<IMGroupFansCountResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }
        }

        /// <summary>
        /// 获取或设置剩余数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("left_count")]
        [System.Text.Json.Serialization.JsonPropertyName("left_count")]
        public int LeftCount { get; set; }
    }
}
