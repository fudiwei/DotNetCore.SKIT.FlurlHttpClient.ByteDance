using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /gaming_con/world_rank/upload_rank_list 接口的请求。</para>
    /// </summary>
    public class WebcastGamingConWorldRankUploadRankListRequest : DouyinMicroAppWebcastRequest
    {
        public static class Types
        {
            public class Rank
            {
                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string OpenId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置​世界榜单排名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rank")]
                [System.Text.Json.Serialization.JsonPropertyName("rank")]
                public long Ranking { get; set; }

                /// <summary>
                /// 获取或设置世界榜单积分​。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("score")]
                [System.Text.Json.Serialization.JsonPropertyName("score")]
                public long Score { get; set; }

                /// <summary>
                /// 获取或设置连胜次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("winning_streak_count")]
                [System.Text.Json.Serialization.JsonPropertyName("winning_streak_count")]
                public long WinningStreakCount { get; set; }

                /// <summary>
                /// 获取或设置胜点记录。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("winning_points")]
                [System.Text.Json.Serialization.JsonPropertyName("winning_points")]
                public long WinningPoints { get; set; }
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
        /// 获取或设置​世界榜单列表​。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_list")]
        [System.Text.Json.Serialization.JsonPropertyName("rank_list")]
        public IList<Types.Rank> RankList { get; set; } = new List<Types.Rank>();
    }
}
