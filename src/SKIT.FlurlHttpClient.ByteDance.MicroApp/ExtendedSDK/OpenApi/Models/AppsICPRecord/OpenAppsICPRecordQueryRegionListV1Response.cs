namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/icp_record/query_region_list/ 接口的响应。</para>
    /// </summary>
    public class OpenAppsICPRecordQueryRegionListV1Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Region
                    {
                        /// <summary>
                        /// 获取或设置区域编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string Code { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置区域名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置区域类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置子区域列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_region")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_region")]
                        public Region[]? Children { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置区域列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("region_list")]
                [System.Text.Json.Serialization.JsonPropertyName("region_list")]
                public Types.Region[] RegionList { get; set; } = default!;
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
