namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.UPDATE_AUTHORIZED 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/notify ]]>
    /// </para>
    /// </summary>
    public class ComponentUpdateAuthorizedEvent : DouyinMicroAppOpenApiEvent
    {
        /// <summary>
        /// 获取或设置授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthorizationCode")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthorizationCode")]
        [System.Xml.Serialization.XmlElement("AuthorizationCode")]
        public string AuthorizationCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权码有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthorizationCodeExpiresIn")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthorizationCodeExpiresIn")]
        [System.Xml.Serialization.XmlElement("AuthorizationCodeExpiresIn")]
        public long AuthorizationCodeExpiresIn { get; set; }
    }
}
