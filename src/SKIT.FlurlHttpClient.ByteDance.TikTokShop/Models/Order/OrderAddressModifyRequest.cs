namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/addressModify 接口的请求。</para>
    /// </summary>
    public class OrderAddressModifyRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class PostAddress
            {
                public static class Types
                {
                    public class Area
                    {
                        /// <summary>
                        /// 获取或设置地区 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public int Id { get; set; }

                        /// <summary>
                        /// 获取或设置地区名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置省份信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public Types.Area Province { get; set; } = new Types.Area();

                /// <summary>
                /// 获取或设置城市信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public Types.Area City { get; set; } = new Types.Area();

                /// <summary>
                /// 获取或设置区县信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("town")]
                [System.Text.Json.Serialization.JsonPropertyName("town")]
                public Types.Area District { get; set; } = new Types.Area();

                /// <summary>
                /// 获取或设置街道信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("street")]
                [System.Text.Json.Serialization.JsonPropertyName("street")]
                public Types.Area? Street { get; set; }

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("address_detail")]
                public string Detail { get; set; } = string.Empty;

                /// <summary>
                /// <i>（使用默认值即可，无需修改）</i>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("land_mark")]
                [System.Text.Json.Serialization.JsonPropertyName("land_mark")]
                public string LandMark { get; set; } = "land";
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收货地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_addr")]
        [System.Text.Json.Serialization.JsonPropertyName("post_addr")]
        public Types.PostAddress PostAddress { get; set; } = new Types.PostAddress();

        /// <summary>
        /// 获取或设置收货地址邮政编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_code")]
        [System.Text.Json.Serialization.JsonPropertyName("post_code")]
        public string? PostCode { get; set; }

        /// <summary>
        /// 获取或设置收货人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_receiver")]
        [System.Text.Json.Serialization.JsonPropertyName("post_receiver")]
        public string? PostReceiver { get; set; }

        /// <summary>
        /// 获取或设置收货人电话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_tel")]
        [System.Text.Json.Serialization.JsonPropertyName("post_tel")]
        public string? PostPhoneNumber { get; set; }
    }
}
