namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.MODIFY_APP_ICON 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/modify-icon ]]>
    /// </para>
    /// </summary>
    public class ModifyAppIconEvent : DouyinMicroAppOpenApiEvent
    {
        public static class Types
        {
            public class ModifyResult
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
        /// 获取或设置修改结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ModifyAppIconResults")]
        [System.Text.Json.Serialization.JsonPropertyName("ModifyAppIconResults")]
        [System.Xml.Serialization.XmlElement("ModifyAppIconResults")]
        public Types.ModifyResult ModifyResult { get; set; } = default!;
    }
}
