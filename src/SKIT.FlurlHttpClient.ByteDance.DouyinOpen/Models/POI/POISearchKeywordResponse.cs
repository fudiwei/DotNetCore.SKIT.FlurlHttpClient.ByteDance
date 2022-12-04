namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/search/keyword 接口的响应。</para>
    /// </summary>
    public class POISearchKeywordResponse : DouyinOpenResponse<POISearchKeywordResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class POI
                    {
                        /// <summary>
                        /// 获取或设置 POI ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                        public string POIId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 POI 名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_name")]
                        public string POIName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置国家编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("country_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("country_code")]
                        public string CountryCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置国家。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("country")]
                        [System.Text.Json.Serialization.JsonPropertyName("country")]
                        public string Country { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置省份。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province")]
                        [System.Text.Json.Serialization.JsonPropertyName("province")]
                        public string Province { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置城市编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("city_code")]
                        public string CityCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置城市。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city")]
                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                        public string City { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置区县。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("district")]
                        [System.Text.Json.Serialization.JsonPropertyName("district")]
                        public string District { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置详细地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string Address { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置经纬度坐标（格式：X,Y）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("location")]
                        [System.Text.Json.Serialization.JsonPropertyName("location")]
                        public string Location { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置地理位置列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pois")]
                [System.Text.Json.Serialization.JsonPropertyName("pois")]
                public Types.POI[] POIList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                public long? PageCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
