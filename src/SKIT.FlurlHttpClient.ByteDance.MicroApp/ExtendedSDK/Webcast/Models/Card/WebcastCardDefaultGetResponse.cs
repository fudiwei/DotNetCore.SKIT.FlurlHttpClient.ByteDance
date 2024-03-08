namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/default/get 接口的响应。</para>
    /// </summary>
    public class WebcastCardDefaultGetResponse : DouyinMicroAppWebcastResponse
    {
        public static class Types
        {
            public class CardValue
            {
                public static class Types
                {
                    public class TitleInfo
                    {
                        /// <summary>
                        /// 获取或设置主标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("main_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("main_title")]
                        public string MainTitle { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置副标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_title")]
                        public string? SubTitle { get; set; }
                    }

                    public class StatusTagInfo
                    {
                        /// <summary>
                        /// 获取或设置标签类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_type")]
                        public int? TagType { get; set; }

                        /// <summary>
                        /// 获取或设置活动开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_timestamp")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
                        public long? StartTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置活动结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stop_timestamp")]
                        [System.Text.Json.Serialization.JsonPropertyName("stop_timestamp")]
                        public long? StopTimestamp { get; set; }
                    }

                    public class PropertyTagInfo
                    {
                        /// <summary>
                        /// 获取或设置店铺 Logo 图片 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("store_logo_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("store_logo_id")]
                        public string? StoreLogoImageId { get; set; }

                        /// <summary>
                        /// 获取或设置店铺名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("store_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("store_name")]
                        public string? StoreName { get; set; }
                    }

                    public class ButtonInfo
                    {
                        /// <summary>
                        /// 获取或设置按钮类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("btn_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("btn_type")]
                        public int? ButtonType { get; set; }

                        /// <summary>
                        /// 获取或设置价格字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public string? PriceString { get; set; }

                        /// <summary>
                        /// 获取或设置颜色十六进制值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("color")]
                        [System.Text.Json.Serialization.JsonPropertyName("color")]
                        public string? Color { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_id")]
                [System.Text.Json.Serialization.JsonPropertyName("image_id")]
                public string ImageId { get; set; } = default!;

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
        /// 获取或设置讲解卡类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_type")]
        [System.Text.Json.Serialization.JsonPropertyName("card_type")]
        public int CardType { get; set; }

        /// <summary>
        /// 获取或设置讲解卡内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value")]
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public Types.CardValue CardValue { get; set; } = default!;

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置审核意见。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_opinion")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_opinion")]
        public string? AuditOpinion { get; set; }
    }
}
