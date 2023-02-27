using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 life_member_join 事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/member/member.join </para>
    /// </summary>
    public class LifeMemberJoinEvent : DouyinOpenEvent<LifeMemberJoinEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置商家 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_id")]
                [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string AccountId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                public string MobileNumber { get; set; } = default!;
            }
        }

        internal static class Converters
        {
            internal class EventPropertyContentNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Content?>
            {
            }

            internal class EventPropertyContentSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Content?>
            {
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.EventPropertyContentNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.EventPropertyContentSystemTextJsonConverter))]
        public override Types.Content EventContent { get; set; } = default!;
    }
}
