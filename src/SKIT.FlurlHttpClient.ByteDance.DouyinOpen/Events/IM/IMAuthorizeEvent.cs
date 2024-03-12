namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 im_authorize 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/private-message/im_authorize_wenhook ]]>
    /// </para>
    /// </summary>
    public class IMAuthorizeEvent : DouyinOpenEvent<IMAuthorizeEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置操作类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operation_type")]
                [System.Text.Json.Serialization.JsonPropertyName("operation_type")]
                public int OperationType { get; set; }

                /// <summary>
                /// 获取或设置授权状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_status")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_status")]
                public int AuthStatus { get; set; }

                /// <summary>
                /// 获取或设置授权场景。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public string Source { get; set; } = default!;

                /// <summary>
                /// 获取或设置扩展字段。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extra")]
                [System.Text.Json.Serialization.JsonPropertyName("extra")]
                public string? Extra { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置到期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long ExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string? PagePath { get; set; }

                /// <summary>
                /// 获取或设置页面参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query")]
                [System.Text.Json.Serialization.JsonPropertyName("query")]
                public string? PageQuery { get; set; }

                /// <summary>
                /// 获取或设置自定义参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_im_extra")]
                [System.Text.Json.Serialization.JsonPropertyName("data_im_extra")]
                public string? DataIMExtra { get; set; }
            }
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("content")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public override Types.Content EventContent { get; set; } = default!;
    }
}
