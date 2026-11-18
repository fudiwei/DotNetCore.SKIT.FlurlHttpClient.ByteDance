namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /user/data/add/ 接口的响应。</para>
    /// </summary>
    public class UserDataAddResponse : TikTokV2Response<UserDataAddResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置申请 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("request_id")]
                [System.Text.Json.Serialization.JsonPropertyName("request_id")]
                public long RequestId { get; set; }
            }
        }
    }
}
