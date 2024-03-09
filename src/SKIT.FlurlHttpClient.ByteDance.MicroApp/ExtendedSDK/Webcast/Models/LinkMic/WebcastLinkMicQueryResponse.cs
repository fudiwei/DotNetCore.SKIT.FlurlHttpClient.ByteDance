namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /linkmic/query 接口的响应。</para>
    /// </summary>
    public class WebcastLinkMicQueryResponse : DouyinMicroAppWebcastResponse
    {
        public static class Types
        {
            public class BaseInfo
            {
                /// <summary>
                /// 获取或设置连麦 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("link_id")]
                [System.Text.Json.Serialization.JsonPropertyName("link_id")]
                public string LinkId { get; set; } = default!;

                /// <summary>
                /// 获取或设置麦位总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置麦位剩余数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("free_count")]
                [System.Text.Json.Serialization.JsonPropertyName("free_count")]
                public int FreeCount { get; set; }
            }

            public class User
            {
                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置加密头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sec_avatar_url")]
                [System.Text.Json.Serialization.JsonPropertyName("sec_avatar_url")]
                public string SecretAvatarUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置加密昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sec_nick_name")]
                [System.Text.Json.Serialization.JsonPropertyName("sec_nick_name")]
                public string SecretNickName { get; set; } = default!;

                /// <summary>
                /// 获取或设置连麦状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("link_state")]
                [System.Text.Json.Serialization.JsonPropertyName("link_state")]
                public int LinkState { get; set; }

                /// <summary>
                /// 获取或设置麦位位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("link_position")]
                [System.Text.Json.Serialization.JsonPropertyName("link_position")]
                public int LinkPosition { get; set; }

                /// <summary>
                /// 获取或设置禁用麦克风状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("disable_microphone")]
                [System.Text.Json.Serialization.JsonPropertyName("disable_microphone")]
                public int MicrophoneDisableState { get; set; }

                /// <summary>
                /// 获取或设置麦克风状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("microphone_state")]
                [System.Text.Json.Serialization.JsonPropertyName("microphone_state")]
                public int MicrophoneState { get; set; }

                /// <summary>
                /// 获取或设置禁用摄像头状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("disable_camera")]
                [System.Text.Json.Serialization.JsonPropertyName("disable_camera")]
                public int CameraDisableState { get; set; }

                /// <summary>
                /// 获取或设置摄像头状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("camera_state")]
                [System.Text.Json.Serialization.JsonPropertyName("camera_state")]
                public int CameraState { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置麦位基本信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base_info")]
        [System.Text.Json.Serialization.JsonPropertyName("base_info")]
        public Types.BaseInfo BaseInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置麦位用户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_list")]
        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
        public Types.User[] UserList { get; set; } = default!;
    }
}
