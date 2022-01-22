namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Events
{
    /// <summary>
    /// <para>表示 doudian_refund_ReturnApplyAgreed 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/31/117 </para>
    /// </summary>
    public class RefundReturnApplyAgreedEvent : TikTokShopEvent<RefundReturnApplyAgreedEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : RefundReturnAgreedEvent.Types.Data
            {
                public static class Types
                {
                    public class Address
                    {
                        /// <summary>
                        /// 获取或设置省份 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("province_id")]
                        public int ProvinceId { get; set; }

                        /// <summary>
                        /// 获取或设置省份名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province")]
                        [System.Text.Json.Serialization.JsonPropertyName("province")]
                        public string ProvinceName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置城市 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("city_id")]
                        public int CityId { get; set; }

                        /// <summary>
                        /// 获取或设置城市名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city")]
                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                        public string CityName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置区县 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("town_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("town_id")]
                        public int DistrictId { get; set; }

                        /// <summary>
                        /// 获取或设置区县名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("town")]
                        [System.Text.Json.Serialization.JsonPropertyName("town")]
                        public string DistrictName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置街道 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("street_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("street_id")]
                        public int? StreetId { get; set; }

                        /// <summary>
                        /// 获取或设置街道名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("street")]
                        [System.Text.Json.Serialization.JsonPropertyName("street")]
                        public string? StreetName { get; set; }

                        /// <summary>
                        /// 获取或设置详细地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail")]
                        public string Detail { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收件人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收件人电话号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mobile")]
                        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                        public string PhoneNumber { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置退货地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("addr")]
                [System.Text.Json.Serialization.JsonPropertyName("addr")]
                public Types.Address Address { get; set; } = default!;
            }
        }
    }
}
