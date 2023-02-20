namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/add_app_subscribe_notification_tpl 接口的响应。</para>
    /// </summary>
    public class AppsCapacityAddAppSubscribeNotificationTemplateV1Response : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置小程序消息模版 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_id")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
                public string MessageId { get; set; } = default!;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
