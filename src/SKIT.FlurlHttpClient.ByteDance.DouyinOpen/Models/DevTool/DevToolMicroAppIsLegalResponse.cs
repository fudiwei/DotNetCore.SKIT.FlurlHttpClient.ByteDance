namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /devtool/micapp/is_legal 接口的响应。</para>
    /// </summary>
    public class DevToolMicroAppIsLegalResponse : DouyinOpenResponse<DevToolMicroAppIsLegalResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                /// <summary>
                /// 获取或设置是否是合法信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_legal")]
                [System.Text.Json.Serialization.JsonPropertyName("is_legal")]
                public bool IsLegal { get; set; }
            }
        }
    }
}
