using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /gaming_con/round/upload_rank_list 接口的请求。</para>
    /// </summary>
    public class WebcastGamingConRoundUploadRankListRequest : DouyinMicroAppWebcastRequest
    {
        public static class Types
        {
            public class Rank : WebcastGamingConWorldRankUploadRankListRequest.Types.Rank
            {
                /// <summary>
                /// 获取或设置阵营 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_id")]
                [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                public string GroupId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置​​对局结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("round_result")]
                [System.Text.Json.Serialization.JsonPropertyName("round_result")]
                public int RoundResult { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置应用的 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppWebcastClient"/> 时的 <see cref="DouyinMicroAppWebcastClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置主播的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anchor_open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("anchor_open_id")]
        public string AnchorOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置​房间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_id")]
        [System.Text.Json.Serialization.JsonPropertyName("room_id")]
        public string RoomId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置​​对局 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("round_id")]
        [System.Text.Json.Serialization.JsonPropertyName("round_id")]
        public long RoundId { get; set; }

        /// <summary>
        /// 获取或设置对局榜单列表​​​。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rank_list")]
        [System.Text.Json.Serialization.JsonPropertyName("rank_list")]
        public IList<Types.Rank> RankList { get; set; } = new List<Types.Rank>();
    }
}
