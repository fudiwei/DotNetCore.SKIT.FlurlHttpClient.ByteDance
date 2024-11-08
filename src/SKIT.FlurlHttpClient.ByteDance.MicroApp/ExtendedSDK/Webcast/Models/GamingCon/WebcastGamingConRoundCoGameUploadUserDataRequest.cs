using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /gaming_con/round/co_game_upload_user_data​ 接口的请求。</para>
    /// </summary>
    public class WebcastGamingConRoundCoGameUploadUserDataRequest : DouyinMicroAppWebcastRequest
    {
        public static class Types
        {
            public class Anchor
            {
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
            }

            public class User
            {
                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string OpenId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置​用户得分。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("score")]
                [System.Text.Json.Serialization.JsonPropertyName("score")]
                public long Score { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置应用的 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppWebcastClient"/> 时的 <see cref="DouyinMicroAppWebcastClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置​​对局 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("round_id")]
        [System.Text.Json.Serialization.JsonPropertyName("round_id")]
        public long RoundId { get; set; }

        /// <summary>
        /// 获取或设置​​对局状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("round_status")]
        [System.Text.Json.Serialization.JsonPropertyName("round_status")]
        public int RoundStatus { get; set; }

        /// <summary>
        /// 获取或设置主播列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anchor_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("anchor_infos")]
        public IList<Types.Anchor> AnchorList { get; set; } = new List<Types.Anchor>();

        /// <summary>
        /// 获取或设置用户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_list")]
        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
        public IList<Types.User> UserList { get; set; } = new List<Types.User>();
    }
}
