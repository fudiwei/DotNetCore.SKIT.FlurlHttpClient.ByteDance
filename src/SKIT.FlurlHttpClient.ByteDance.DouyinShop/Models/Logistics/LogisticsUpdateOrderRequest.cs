using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/updateOrder 接口的请求。</para>
    /// </summary>
    public class LogisticsUpdateOrderRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Contact : LogisticsNewCreateOrderRequest.Types.Contact
            {
            }

            public class Address : LogisticsNewCreateOrderRequest.Types.Address
            {
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

            public class Receiver : Sender
            {
                /// <summary>
                /// 获取或设置收货地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public Address? Address { get; set; }
            }

            public class Item : LogisticsNewCreateOrderRequest.Types.Order.Types.Item
            {
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
        public string LogisticsNumber { get; set; } = string.Empty;

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
        [System.Text.Json.Serialization.JsonPropertyName("receiver_info")]
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
        /// 获取或设置总体积字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("volume")]
        [System.Text.Json.Serialization.JsonPropertyName("volume")]
        public string? TotalVolumeString { get; set; }

        /// <summary>
        /// 获取或设置总重量（单位：克）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weight")]
        [System.Text.Json.Serialization.JsonPropertyName("weight")]
        public int? TotalWeight { get; set; }

        /// <summary>
        /// 获取或设置用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public long? UserId { get; set; }
    }
}
