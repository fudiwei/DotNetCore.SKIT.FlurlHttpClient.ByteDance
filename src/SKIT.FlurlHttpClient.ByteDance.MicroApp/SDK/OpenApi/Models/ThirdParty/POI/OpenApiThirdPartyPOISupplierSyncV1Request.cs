using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/tp/poi/supplier/sync 接口的请求。</para>
    /// </summary>
    public class OpenApiThirdPartyPOISupplierSyncV1Request : ByteDanceMicroAppOpenApiRequest
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
                                public string AppId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置小程序页面路径。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("path")]
                                [System.Text.Json.Serialization.JsonPropertyName("path")]
                                public string PagePath { get; set; } = string.Empty;

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
        public string POIId { get; set; } = string.Empty;

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
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置外部商铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
        public string SupplierExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商铺地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// 获取或设置商铺提供的服务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("services")]
        [System.Text.Json.Serialization.JsonPropertyName("services")]
        public IList<Types.Service>? ServiceList { get; set; }

        /// <summary>
        /// 获取或设置商铺状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
