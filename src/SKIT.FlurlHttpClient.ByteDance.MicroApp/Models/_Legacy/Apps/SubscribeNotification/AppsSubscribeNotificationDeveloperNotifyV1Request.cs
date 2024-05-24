using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/subscribe_notification/developer/v1/notify 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-12-27 下线。")]
    public class AppsSubscribeNotificationDeveloperNotifyV1Request : DouyinMicroAppRequest
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tpl_id")]
        [System.Text.Json.Serialization.JsonPropertyName("tpl_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板内容信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public IDictionary<string, string> Data { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// 获取或设置跳转的页面。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public string? PagePath { get; set; }
    }
}
