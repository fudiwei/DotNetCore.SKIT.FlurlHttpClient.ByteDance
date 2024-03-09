namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.APPLY_PHONE_NUMBER_CAPABILITY 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/operation/microapp/phone-number-application ]]>
    /// </para>
    /// </summary>
    public class ApplyPhoneNumberCapabilityEvent : DouyinMicroAppOpenApiEvent
    {
        public static class Types
        {
            public class ApplyResult
            {
                /// <summary>
                /// 获取或设置审核结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置审核拒绝原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                [System.Xml.Serialization.XmlElement("reason", IsNullable = true)]
                public string? RejectReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置申请结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ApplyPhoneNumberCapabilityResults")]
        [System.Text.Json.Serialization.JsonPropertyName("ApplyPhoneNumberCapabilityResults")]
        [System.Xml.Serialization.XmlElement("ApplyPhoneNumberCapabilityResults")]
        public Types.ApplyResult ApplyResult { get; set; } = default!;
    }
}
