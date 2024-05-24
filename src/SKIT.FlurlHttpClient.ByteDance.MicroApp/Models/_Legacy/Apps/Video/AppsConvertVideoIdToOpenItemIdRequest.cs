using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/convert_video_id/video_id_to_open_item_id 接口的请求。</para>
    /// </summary>
    public class AppsConvertVideoIdToOpenItemIdRequest : DouyinMicroAppRequest
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
        /// 获取或设置访问密钥。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_key")]
        [System.Text.Json.Serialization.JsonPropertyName("access_key")]
        public string? AccessKey { get; set; }

        /// <summary>
        /// 获取或设置视频 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("video_ids")]
        public IList<string> VideoIdList { get; set; } = new List<string>();
    }
}
