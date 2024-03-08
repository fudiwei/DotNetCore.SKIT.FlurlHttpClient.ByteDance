namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/set 接口的请求。</para>
    /// </summary>
    public class WebcastCardSetRequest : DouyinMicroAppWebcastRequest
    {
        public static class Types
        {
            public class CardValue
            {
                public static class Types
                {
                    public class TitleInfo : WebcastCardDefaultSetRequest.Types.CardValue.Types.TitleInfo
                    { 
                    }

                    public class StatusTagInfo : WebcastCardDefaultSetRequest.Types.CardValue.Types.StatusTagInfo
                    {
                    }

                    public class PropertyTagInfo : WebcastCardDefaultSetRequest.Types.CardValue.Types.PropertyTagInfo
                    {
                    }

                    public class ButtonInfo : WebcastCardDefaultSetRequest.Types.CardValue.Types.ButtonInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_id")]
                [System.Text.Json.Serialization.JsonPropertyName("image_id")]
                public string ImageId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置状态标签信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("status_tag")]
                public Types.StatusTagInfo? StatusTagInfo { get; set; }

                /// <summary>
                /// 获取或设置属性标签信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("property_tag")]
                public Types.PropertyTagInfo? PropertyTagInfo { get; set; }

                /// <summary>
                /// 获取或设置标题信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public Types.TitleInfo? TitleInfo { get; set; }

                /// <summary>
                /// 获取或设置按钮信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("btn")]
                [System.Text.Json.Serialization.JsonPropertyName("btn")]
                public Types.ButtonInfo? ButtonInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string PagePath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置讲解卡类型。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_type")]
        [System.Text.Json.Serialization.JsonPropertyName("card_type")]
        public int CardType { get; set; } = 1;

        /// <summary>
        /// 获取或设置讲解卡内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public Types.CardValue CardValue { get; set; } = new Types.CardValue();
    }
}
