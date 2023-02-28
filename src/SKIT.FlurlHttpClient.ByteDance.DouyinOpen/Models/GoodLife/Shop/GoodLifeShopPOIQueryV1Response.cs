namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/shop/poi/query 接口的响应。</para>
    /// </summary>
    public class GoodLifeShopPOIQueryV1Response : DouyinOpenResponse<GoodLifeShopPOIQueryV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class POI
                    {
                        public static class Types
                        {
                            public class AccountInfo
                            {
                                public static class Types
                                {
                                    public class Account
                                    {
                                        /// <summary>
                                        /// 获取或设置账户 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("account_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                        public string AccountId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置账户昵称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("account_name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                                        public string AccountName { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置账户类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("account_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                                        public string AccountType { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置供应商账户信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("parent_account")]
                                [System.Text.Json.Serialization.JsonPropertyName("parent_account")]
                                public Types.Account? ParentAccount { get; set; }

                                /// <summary>
                                /// 获取或设置门店账户信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("poi_account")]
                                [System.Text.Json.Serialization.JsonPropertyName("poi_account")]
                                public Types.Account? POIAccount { get; set; }
                            }

                            public class POIInfo
                            {
                                /// <summary>
                                /// 获取或设置门店 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("poi_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                                public string POIId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置门店名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("poi_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("poi_name")]
                                public string POIName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置门店地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address")]
                                [System.Text.Json.Serialization.JsonPropertyName("address")]
                                public string Address { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置纬度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("latitude")]
                                [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                                public double Latitude { get; set; }

                                /// <summary>
                                /// 获取或设置经度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("longitude")]
                                [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                                public double Longitude { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置账户信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account")]
                        [System.Text.Json.Serialization.JsonPropertyName("account")]
                        public Types.AccountInfo AccountInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置门店信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi")]
                        public Types.POIInfo POIInfo { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置门店列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pois")]
                [System.Text.Json.Serialization.JsonPropertyName("pois")]
                public Types.POI[] POIList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
