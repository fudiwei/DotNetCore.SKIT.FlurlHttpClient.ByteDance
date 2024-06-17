namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/tp/poi/base/query/amap 接口的响应。</para>
    /// </summary>
    public class OpenApiThirdPartyPOIBaseQueryAMapV1Response : DouyinMicroAppOpenApiLegacyResponseBase
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置纬度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("latitude")]
                [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                public decimal Latitude { get; set; }

                /// <summary>
                /// 获取或设置经度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("longitude")]
                [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                public decimal Longitude { get; set; }

                /// <summary>
                /// 获取或设置抖音 POI ID。
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
                /// 获取或设置高德 POI ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amap_id")]
                [System.Text.Json.Serialization.JsonPropertyName("amap_id")]
                public string AMapId { get; set; } = default!;

                /// <summary>
                /// 获取或设置省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string Province { get; set; } = default!;

                /// <summary>
                /// 获取或设置城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string City { get; set; } = default!;

                /// <summary>
                /// 获取或设置地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string Address { get; set; } = default!;
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
