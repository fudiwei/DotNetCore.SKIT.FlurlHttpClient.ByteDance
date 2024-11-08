using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /gaming_con/world_rank/complete_upload_user_result 接口的请求。</para>
    /// </summary>
    public class WebcastGamingConWorldRankCompleteUploadUserResultRequest : DouyinMicroAppWebcastRequest
    {
        /// <summary>
        /// 获取或设置应用的 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppWebcastClient"/> 时的 <see cref="DouyinMicroAppWebcastClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置是否是线上数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_online_version")]
        [System.Text.Json.Serialization.JsonPropertyName("is_online_version")]
        public bool IsOnlineVersion { get; set; }

        /// <summary>
        /// 获取或设置​当前榜单的生效版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("world_rank_version")]
        [System.Text.Json.Serialization.JsonPropertyName("world_rank_version")]
        public string WorldRankVersion { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上传完成时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complete_time")]
        [System.Text.Json.Serialization.JsonPropertyName("complete_time")]
        public long? CompleteTimestamp { get; set; }
    }
}
