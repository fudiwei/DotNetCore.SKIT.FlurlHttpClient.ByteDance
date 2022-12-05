using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/Operate 接口的请求。</para>
    /// </summary>
    public class AftersaleOperateRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Aftersale
            {
                public static class Types
                {
                    public class Evidence
                    {
                        /// <summary>
                        /// 获取或设置凭证类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置凭证图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aftersale_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
                        public string Url { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置凭证描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string? Description { get; set; }
                    }

                    public class Logistics
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
                                [Newtonsoft.Json.JsonProperty("province_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("province_name")]
                                public string ProvinceName { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置城市 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("city_id")]
                                public int CityId { get; set; }

                                /// <summary>
                                /// 获取或设置城市名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                                public string CityName { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置区县 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("town_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("town_id")]
                                public int DistrictId { get; set; }

                                /// <summary>
                                /// 获取或设置区县名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("town_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("town_name")]
                                public string DistrictName { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置街道 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("street_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("street_id")]
                                public int? StreetId { get; set; }

                                /// <summary>
                                /// 获取或设置街道名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("street_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("street_name")]
                                public string? StreetName { get; set; }

                                /// <summary>
                                /// 获取或设置详细地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("detail")]
                                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                                public string Detail { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置收件人姓名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                                public string ReceiverName { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置收件人电话号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mobile")]
                                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                                public string ReceiverPhoneNumber { get; set; } = string.Empty;
                            }
                        }

                        /// <summary>
                        /// 获取或设置物流单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logistics_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
                        public string? LogisticsNumber { get; set; }

                        /// <summary>
                        /// 获取或设置物流公司编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("company_code")]
                        public string? CompanyCode { get; set; }

                        /// <summary>
                        /// 获取或设置收件地址 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receiver_address_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("receiver_address_id")]
                        public int? ReceiverAddressId { get; set; }

                        /// <summary>
                        /// 获取或设置发件地址 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sender_address_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sender_address_id")]
                        public int? SenderAddressId { get; set; }

                        /// <summary>
                        /// 获取或设置地址信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("after_sale_address_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("after_sale_address_detail")]
                        public Types.Address? Address { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置售后单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aftersale_id")]
                [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
                public string AftersaleId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置操作原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                public string? Reason { get; set; }

                /// <summary>
                /// 获取或设置操作备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置操作凭证列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("evidence")]
                [System.Text.Json.Serialization.JsonPropertyName("evidence")]
                public IList<Types.Evidence>? EvidenceList { get; set; }

                /// <summary>
                /// 获取或设置物流信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logistics")]
                [System.Text.Json.Serialization.JsonPropertyName("logistics")]
                public Types.Logistics? Logistics { get; set; }

                /// <summary>
                /// 获取或设置操作时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long? OperateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置操作的售后单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public IList<Types.Aftersale> AftersaleList { get; set; } = new List<Types.Aftersale>();
    }
}
