using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/supplier/match 接口的请求。</para>
    /// </summary>
    public class POISupplierMatchV2Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class MatchData
            {
                /// <summary>
                /// 获取或设置高德地图 POI ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amap_id")]
                [System.Text.Json.Serialization.JsonPropertyName("amap_id")]
                public string? AMapId { get; set; }

                /// <summary>
                /// 获取或设置 POI ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi_id")]
                [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                public string? POIId { get; set; }

                /// <summary>
                /// 获取或设置 POI 名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi_name")]
                [System.Text.Json.Serialization.JsonPropertyName("poi_name")]
                public string? POIName { get; set; }

                /// <summary>
                /// 获取或设置门店外部 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
                public string? SupplierExternalId { get; set; }

                /// <summary>
                /// 获取或设置经度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("longitude")]
                [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                public decimal? Longitude { get; set; }

                /// <summary>
                /// 获取或设置纬度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("latitude")]
                [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                public decimal? Latitude { get; set; }

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

                /// <summary>
                /// 获取或设置扩展信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extra")]
                [System.Text.Json.Serialization.JsonPropertyName("extra")]
                public string? Extra { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置匹配数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("match_data_list")]
        [System.Text.Json.Serialization.JsonPropertyName("match_data_list")]
        public IList<Types.MatchData> MatchDataList { get; set; } = new List<Types.MatchData>();
    }
}
