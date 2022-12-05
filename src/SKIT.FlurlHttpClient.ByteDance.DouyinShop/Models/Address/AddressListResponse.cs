namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /address/list 接口的响应。</para>
    /// </summary>
    public class AddressListResponse : DouyinShopResponse<AddressListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Address
                    {
                        /// <summary>
                        /// 获取或设置地址 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("address_id")]
                        public int AddressId { get; set; }

                        /// <summary>
                        /// 获取或设置收件人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reciever_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("reciever_name")]
                        public string RecieverName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置省份。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receiver_provinc")]
                        [System.Text.Json.Serialization.JsonPropertyName("receiver_provinc")]
                        public string Province { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置城市。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receiver_city")]
                        [System.Text.Json.Serialization.JsonPropertyName("receiver_city")]
                        public string City { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置区县。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receiver_district")]
                        [System.Text.Json.Serialization.JsonPropertyName("receiver_district")]
                        public string District { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置街道。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receiver_street")]
                        [System.Text.Json.Serialization.JsonPropertyName("receiver_street")]
                        public string? Street { get; set; }

                        /// <summary>
                        /// 获取或设置详情地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receiver_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("receiver_detail")]
                        public string Detail { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否是退货默认地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_default")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_default")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsDefault { get; set; }

                        /// <summary>
                        /// 获取或设置是否是发货默认地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_send_default")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_send_default")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsSendDefault { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimstamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置售后地址列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_list")]
                [System.Text.Json.Serialization.JsonPropertyName("address_list")]
                public Types.Address[] AddressList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置翻页页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_no")]
                [System.Text.Json.Serialization.JsonPropertyName("page_no")]
                public int PageNumber { get; set; }

                /// <summary>
                /// 获取或设置翻页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_size")]
                [System.Text.Json.Serialization.JsonPropertyName("page_size")]
                public int PageSize { get; set; }
            }
        }
    }
}
