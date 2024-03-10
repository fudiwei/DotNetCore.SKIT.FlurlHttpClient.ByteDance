namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 union_auth_info_for_c 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/union_auth/union_auth_info ]]> <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/union_auth/union_auth_info_for_c ]]>
    /// </para>
    /// </summary>
    public class UnionAuthInfoForCEvent : DouyinOpenEvent<UnionAuthInfoForCEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置 B 端应用 ClientKey。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("b_client_key")]
                [System.Text.Json.Serialization.JsonPropertyName("b_client_key")]
                public string BClientKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户在 B 端下的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("b_open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("b_open_id")]
                public string BOpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置 C 端应用 ClientKey。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("c_client_key")]
                [System.Text.Json.Serialization.JsonPropertyName("c_client_key")]
                public string CClientKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户在 C 端下的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("c_open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("c_open_id")]
                public string COpenId { get; set; } = default!;
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
