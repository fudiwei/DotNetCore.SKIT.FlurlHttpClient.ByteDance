using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /gaming_con/round/sync_status 接口的请求。</para>
    /// </summary>
    public class WebcastGamingConRoundSyncStatusRequest : DouyinMicroAppWebcastRequest
    {
        public static class Types
        {
            public class GroupResult
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
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                public int Result { get; set; }
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
        /// 获取或设置本局开始时间戳​。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置本局结束时间戳​。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置对局状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置阵型的结果数据​。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_result_list")]
        [System.Text.Json.Serialization.JsonPropertyName("group_result_list")]
        public IList<Types.GroupResult>? GroupResultList { get; set; }
    }
}
