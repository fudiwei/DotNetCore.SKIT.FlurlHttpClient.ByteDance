namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/listShopNetsite 接口的响应。</para>
    /// </summary>
    public class LogisticsListShopNetSiteResponse : DouyinShopResponse<LogisticsListShopNetSiteResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class NetSite
                    {
                        public static class Types
                        {
                            public class Address
                            {
                                /// <summary>
                                /// 获取或设置省份名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("province_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("province_name")]
                                public string ProvinceName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置城市名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                                public string CityName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置区县名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("district_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("district_name")]
                                public string DistrictName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置街道名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("street_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("street_name")]
                                public string? StreetName { get; set; }

                                /// <summary>
                                /// 获取或设置详细地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("detail_address")]
                                [System.Text.Json.Serialization.JsonPropertyName("detail_address")]
                                public string Detail { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置网点编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("netsite_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("netsite_code")]
                        public string NetSiteCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置网点名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("netsite_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("netsite_name")]
                        public string NetSiteName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置快递公司类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("company_type")]
                        public int CompanyType { get; set; }

                        /// <summary>
                        /// 获取或设置快递公司编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company")]
                        [System.Text.Json.Serialization.JsonPropertyName("company")]
                        public string CompanyCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置电子面单余额数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int Quantity { get; set; }

                        /// <summary>
                        /// 获取或设置已取单号数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("allocated_quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("allocated_quantity")]
                        public int AllocatedQuantity { get; set; }

                        /// <summary>
                        /// 获取或设置已取消号数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancelled_quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancelled_quantity")]
                        public int CancelledQuantity { get; set; }

                        /// <summary>
                        /// 获取或设置已回收号数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("recycled_quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("recycled_quantity")]
                        public int RecycledQuantity { get; set; }

                        /// <summary>
                        /// 获取或设置寄件人地址列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sender_address")]
                        [System.Text.Json.Serialization.JsonPropertyName("sender_address")]
                        public Types.Address[]? SenderAddressLiser { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结果信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("netsites")]
                [System.Text.Json.Serialization.JsonPropertyName("netsites")]
                public Types.NetSite[] NetSiteList { get; set; } = default!;

                /// <summary>
                /// 获取或设置快递公司类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_type")]
                [System.Text.Json.Serialization.JsonPropertyName("company_type")]
                public int CompanyType { get; set; }

                /// <summary>
                /// 获取或设置快递公司编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logistics_code")]
                [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
                public string LogisticsCompanyCode { get; set; } = default!;
            }
        }
    }
}
