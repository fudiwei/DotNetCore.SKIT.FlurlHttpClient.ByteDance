using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /gaming_con/world_rank/upload_user_result 接口的请求。</para>
    /// </summary>
    public class WebcastGamingConWorldRankUploadUserResultRequest : DouyinMicroAppWebcastRequest
    {
        public static class Types
        {
            public class User : WebcastGamingConWorldRankUploadRankListRequest.Types.Rank
            {
            }
        }

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
        /// 获取或设置用户累计战绩数据列表​。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_list")]
        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
        public IList<Types.User> UserList { get; set; } = new List<Types.User>();
    }
}
