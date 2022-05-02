using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Events
{
    /// <summary>
    /// <para>表示 receive_msg 事件的数据。</para>
    /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/develop/webhooks/event-list </para>
    /// </summary>
    public class ReceiveMessageEvent : TikTokEvent<ReceiveMessageEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                public static class Types
                {
                    public class Action
                    {
                        /// <summary>
                        /// 获取或设置文本信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置文本链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置文本点击后的事件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("action_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("action_type")]
                        public string ActionType { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置消息类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("message_type")]
                [System.Text.Json.Serialization.JsonPropertyName("message_type")]
                public string MessageType { get; set; } = default!;

                /// <summary>
                /// 获取或设置文本消息内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public string? Text { get; set; }

                /// <summary>
                /// 获取或设置资源类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("resource_type")]
                [System.Text.Json.Serialization.JsonPropertyName("resource_type")]
                public string? ResourceType { get; set; }

                /// <summary>
                /// 获取或设置资源高度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("resource_height")]
                [System.Text.Json.Serialization.JsonPropertyName("resource_height")]
                public int? ResourceHeight { get; set; }

                /// <summary>
                /// 获取或设置资源宽度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("resource_width")]
                [System.Text.Json.Serialization.JsonPropertyName("resource_width")]
                public int? ResourceWidth { get; set; }

                /// <summary>
                /// 获取或设置资源 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("resource_url")]
                [System.Text.Json.Serialization.JsonPropertyName("resource_url")]
                public string? ResourceUrl { get; set; }

                /// <summary>
                /// 获取或设置卡片标题或消息内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置卡片描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置卡片图标 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("icon_url")]
                [System.Text.Json.Serialization.JsonPropertyName("icon_url")]
                public string? IconUrl { get; set; }

                /// <summary>
                /// 获取或设置卡片跳转链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("link_url")]
                [System.Text.Json.Serialization.JsonPropertyName("link_url")]
                public string? LinkUrl { get; set; }

                /// <summary>
                /// 获取或设置附带内容字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actions")]
                [System.Text.Json.Serialization.JsonPropertyName("actions")]
                public IDictionary<string, Types.Action>? ActionMap { get; set; }
            }
        }
    }
}
