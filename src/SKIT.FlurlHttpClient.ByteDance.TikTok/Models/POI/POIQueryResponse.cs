namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/query 接口的响应。</para>
    /// </summary>
    public class POIQueryResponse : TikTokResponse<POIQueryResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置高德地图 POI ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amap_id")]
                [System.Text.Json.Serialization.JsonPropertyName("amap_id")]
                public string AMapId { get; set; } = default!;

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
                /// 获取或设置经度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("longitude")]
                [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                public double? Longitude { get; set; }

                /// <summary>
                /// 获取或设置纬度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("latitude")]
                [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                public double? Latitude { get; set; }

                /// <summary>
                /// 获取或设置所在省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string? Province { get; set; }

                /// <summary>
                /// 获取或设置所在城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string? City { get; set; }

                /// <summary>
                /// 获取或设置地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string? Address { get; set; }
            }
        }
    }
}
