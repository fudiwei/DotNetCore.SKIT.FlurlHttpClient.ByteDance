namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/tp/poi/supplier/query 接口的响应。</para>
    /// </summary>
    public class OpenApiThirdPartyPOISupplierQueryV1Response : ByteDanceMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SyncResult
                    {
                        /// <summary>
                        /// 获取或设置最近一次同步状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("last_sync_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("last_sync_status")]
                        public int LastSyncStatus { get; set; }

                        /// <summary>
                        /// 获取或设置同步失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fail_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                        public string? FailReason { get; set; }
                    }

                    public class Detail
                    {
                        public static class Types
                        {
                            public class Service
                            {
                                public static class Types
                                {
                                    public class Entry
                                    {
                                        public static class Types
                                        {
                                            public class MiniApp
                                            {
                                                /// <summary>
                                                /// 获取或设置小程序 AppId。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("app_id")]
                                                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                                                public string AppId { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置小程序页面路径。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("path")]
                                                [System.Text.Json.Serialization.JsonPropertyName("path")]
                                                public string PagePath { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置小程序页面参数。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("params")]
                                                [System.Text.Json.Serialization.JsonPropertyName("params")]
                                                public string? PageParameters { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置入口小程序信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("entry_mini_app")]
                                        [System.Text.Json.Serialization.JsonPropertyName("entry_mini_app")]
                                        public Types.MiniApp? MiniApp { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置服务类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("service_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("service_type")]
                                public int? ServiceType { get; set; }

                                /// <summary>
                                /// 获取或设置服务状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("enable")]
                                [System.Text.Json.Serialization.JsonPropertyName("enable")]
                                public int? ServiceStatus { get; set; }

                                /// <summary>
                                /// 获取或设置服务入口参数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("entry")]
                                [System.Text.Json.Serialization.JsonPropertyName("entry")]
                                public Types.Entry? Entry { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置抖音 POI ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                        public string POIId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商铺类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置商铺名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置外部商铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
                        public string SupplierExternalId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商铺提供的服务列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("services")]
                        [System.Text.Json.Serialization.JsonPropertyName("services")]
                        public Types.Service[]? ServiceList { get; set; }

                        /// <summary>
                        /// 获取或设置商铺状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置最近一次的商铺同步结果信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sync_status")]
                [System.Text.Json.Serialization.JsonPropertyName("sync_status")]
                public Types.SyncResult SyncResult { get; set; } = default!;

                /// <summary>
                /// 获取或设置最近一次的商铺同步的数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("data_detail")]
                public Types.Detail? Detail { get; set; }
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
