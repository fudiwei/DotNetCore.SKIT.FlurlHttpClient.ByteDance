using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/updateOrder 接口的请求。</para>
    /// </summary>
    public class LogisticsUpdateOrderRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Contact
            {
                /// <summary>
                /// 获取或设置姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置固定电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                public string? TeleNumber { get; set; }

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                public string? MobileNumber { get; set; }
            }

            public class Address
            {
                /// <summary>
                /// 获取或设置国家编码。
                /// <para>默认值：CHN</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("country_code")]
                [System.Text.Json.Serialization.JsonPropertyName("country_code")]
                public string CountryCode { get; set; } = "CHN";

                /// <summary>
                /// 获取或设置省份名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_name")]
                [System.Text.Json.Serialization.JsonPropertyName("province_name")]
                public string ProvinceName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置城市名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city_name")]
                [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                public string CityName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置区县名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("district_name")]
                [System.Text.Json.Serialization.JsonPropertyName("district_name")]
                public string DistrictName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置街道名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("street_name")]
                [System.Text.Json.Serialization.JsonPropertyName("street_name")]
                public string StreetName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_address")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_address")]
                public string Detail { get; set; } = string.Empty;
            }
        
            public class Sender
            {
                /// <summary>
                /// 获取或设置联系方式信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact")]
                [System.Text.Json.Serialization.JsonPropertyName("contact")]
                public Contact? Contact { get; set; }
            }

            public class Receiver
            {
                /// <summary>
                /// 获取或设置联系方式信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact")]
                [System.Text.Json.Serialization.JsonPropertyName("contact")]
                public Contact? Contact { get; set; }

                /// <summary>
                /// 获取或设置收货地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public Address? Address { get; set; }
            }

            public class Item
            {
                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_name")]
                [System.Text.Json.Serialization.JsonPropertyName("item_name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品规格。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_specs")]
                [System.Text.Json.Serialization.JsonPropertyName("item_specs")]
                public string? Specification { get; set; }

                /// <summary>
                /// 获取或设置商品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_count")]
                [System.Text.Json.Serialization.JsonPropertyName("item_count")]
                public int Count { get; set; }

                /// <summary>
                /// 获取或设置单件体积（单位：立方厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_volume")]
                [System.Text.Json.Serialization.JsonPropertyName("item_volume")]
                public int? Volume { get; set; }

                /// <summary>
                /// 获取或设置单件重量（单位：克）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_weight")]
                [System.Text.Json.Serialization.JsonPropertyName("item_weight")]
                public int? Weight { get; set; }

                /// <summary>
                /// 获取或设置单件净重（单位：克）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_net_weight")]
                [System.Text.Json.Serialization.JsonPropertyName("item_net_weight")]
                public int? NetWeight { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置快递公司编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_code")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
        public string LogisticsCompanyCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("track_no")]
        [System.Text.Json.Serialization.JsonPropertyName("track_no")]
        public string TrackingNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置寄件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender_info")]
        [System.Text.Json.Serialization.JsonPropertyName("sender_info")]
        public Types.Sender? Sender { get; set; }

        /// <summary>
        /// 获取或设置收件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver_info")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver_address")]
        public Types.Receiver? Receiver { get; set; }

        /// <summary>
        /// 获取或设置商品明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public IList<Types.Item>? ItemList { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置备用扩展字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra")]
        [System.Text.Json.Serialization.JsonPropertyName("extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// 获取或设置用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// 获取或设置体积信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("volume")]
        [System.Text.Json.Serialization.JsonPropertyName("volume")]
        public string? Volume { get; set; }

        /// <summary>
        /// 获取或设置总重量（单位：克）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weight")]
        [System.Text.Json.Serialization.JsonPropertyName("weight")]
        public int? Weight { get; set; }

        internal protected override string GetApiMethod()
        {
            return string.Intern("logistics.updateOrder");
        }
    }
}
