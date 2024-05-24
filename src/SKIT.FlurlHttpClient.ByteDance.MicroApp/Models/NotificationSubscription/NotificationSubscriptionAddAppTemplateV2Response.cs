namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/notification/v2/subscription/add_app_tpl/ 接口的响应。</para>
    /// </summary>
    public class NotificationSubscriptionAddAppTemplateV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置消息模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_id")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
                public string MessageId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
