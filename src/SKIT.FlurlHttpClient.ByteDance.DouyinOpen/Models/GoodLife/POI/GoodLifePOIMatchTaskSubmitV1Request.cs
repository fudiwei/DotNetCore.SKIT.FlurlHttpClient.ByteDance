using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/poi/match/task/submit 接口的请求。</para>
    /// </summary>
    public class GoodLifePOIMatchTaskSubmitV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class POI
            {
                /// <summary>
                /// 获取或设置三方 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_id")]
                [System.Text.Json.Serialization.JsonPropertyName("third_id")]
                public string ThirdId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店外部 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ext_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ext_id")]
                public string POIExternalId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi_id")]
                [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                public string? POIId { get; set; }

                /// <summary>
                /// 获取或设置门店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi_name")]
                [System.Text.Json.Serialization.JsonPropertyName("poi_name")]
                public string POIName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string? Province { get; set; }

                /// <summary>
                /// 获取或设置城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string? City { get; set; }

                /// <summary>
                /// 获取或设置经营地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string? Address { get; set; }

                /// <summary>
                /// 获取或设置纬度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("latitude")]
                [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                public double? Latitude { get; set; }

                /// <summary>
                /// 获取或设置经度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("longitude")]
                [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                public double? Longitude { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("datas")]
        [System.Text.Json.Serialization.JsonPropertyName("datas")]
        public IList<Types.POI> POIList { get; set; } = new List<Types.POI>();
    }
}
