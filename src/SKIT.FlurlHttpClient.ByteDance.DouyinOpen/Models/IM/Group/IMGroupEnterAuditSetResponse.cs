namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /im/group/enter/audit/set/ 接口的响应。</para>
    /// </summary>
    public class IMGroupEnterAuditSetResponse : DouyinOpenResponse<IMGroupEnterAuditSetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }
        }

        /// <summary>
        /// 获取或设置执行结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Result { get; set; }
    }
}
