namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /im/group/fans/create/ 接口的响应。</para>
    /// </summary>
    public class IMGroupFansCreateResponse : DouyinOpenResponse<IMGroupFansCreateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }
        }

        /// <summary>
        /// 获取或设置群 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string GroupId { get; set; } = default!;
    }
}
