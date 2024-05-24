namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v1/capacity/query_clue_component_info 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQueryClueComponentInfoV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ClueComponent
                    {
                        public static class Types
                        {
                            public class Region
                            {
                                /// <summary>
                                /// 获取或设置地区编号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("region")]
                                [System.Text.Json.Serialization.JsonPropertyName("region")]
                                public string RegionCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置省份编号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("province_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("province_code")]
                                public string ProvinceCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置省份名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("province_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("province_name")]
                                public string ProvinceName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置城市编号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("city_code")]
                                public string CityCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置城市名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                                public string CityName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置区县编号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("district_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("district_code")]
                                public string DistrictCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置区县名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("district_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("district_name")]
                                public string DistrictName { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置线索组件 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("config_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("config_id")]
                        public string ConfigId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置线索组件名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("config_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("config_name")]
                        public string ConfigName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置地区编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region")]
                        [System.Text.Json.Serialization.JsonPropertyName("region")]
                        public string Region { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置地区名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("region_name")]
                        public string RegionName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务类目 ID 字符串（以逗号分隔）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                        public string CategoryIdString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务类目名称字符串（以逗号分隔）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                        public string CategoryNameString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("state")]
                        [System.Text.Json.Serialization.JsonPropertyName("state")]
                        public string State { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置地区列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("region_list")]
                        public Types.Region[]? RegionList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置线索组件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("clue_component_list")]
                [System.Text.Json.Serialization.JsonPropertyName("clue_component_list")]
                public Types.ClueComponent[] ClueComponentList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置非定向邀约小程序或小程序类目是否符合要求。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cert_status")]
                [System.Text.Json.Serialization.JsonPropertyName("cert_status")]
                public bool? CertStatus { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
