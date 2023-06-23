namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.AUTHORIZED 事件的数据。</para>
    /// <para>REF: https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/authorization/notify </para>
    /// </summary>
    public class ComponentAuthorizedEvent : ByteDanceMicroAppOpenApiEvent, ByteDanceMicroAppOpenApiEvent.Serialization.IJsonSerializable, ByteDanceMicroAppOpenApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthorizationCode")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthorizationCode")]
        [System.Xml.Serialization.XmlElement("AuthorizationCode")]
        public string AuthCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权码有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthorizationCodeExpiresIn")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthorizationCodeExpiresIn")]
        [System.Xml.Serialization.XmlElement("AuthorizationCodeExpiresIn")]
        public long AuthCodeExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置代创建的小程序名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppName")]
        [System.Text.Json.Serialization.JsonPropertyName("AppName")]
        [System.Xml.Serialization.XmlElement("AppName", IsNullable = true)]
        public string? AppName { get; set; }

        /// <summary>
        /// 获取或设置代创建的小程序图标路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppIcon")]
        [System.Text.Json.Serialization.JsonPropertyName("AppIcon")]
        [System.Xml.Serialization.XmlElement("AppIcon", IsNullable = true)]
        public string? AppIconPath { get; set; }

        /// <summary>
        /// 获取或设置代创建的小程序公司主体名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CompanyName")]
        [System.Text.Json.Serialization.JsonPropertyName("CompanyName")]
        [System.Xml.Serialization.XmlElement("CompanyName", IsNullable = true)]
        public string? CompanyName { get; set; }

        /// <summary>
        /// 获取或设置代创建的小程序超管掩码邮箱。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppSuperAdminEmail")]
        [System.Text.Json.Serialization.JsonPropertyName("AppSuperAdminEmail")]
        [System.Xml.Serialization.XmlElement("AppSuperAdminEmail", IsNullable = true)]
        public string? SuperAdminEmail { get; set; }

        /// <summary>
        /// 获取或设置代创建的小程序超管掩码手机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppSuperAdminMobile")]
        [System.Text.Json.Serialization.JsonPropertyName("AppSuperAdminMobile")]
        [System.Xml.Serialization.XmlElement("AppSuperAdminMobile", IsNullable = true)]
        public string? SuperAdminMobileNumber { get; set; }
    }
}
