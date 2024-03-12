using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/supplier/query 接口的响应。</para>
    /// </summary>
    public class POISupplierQueryResponse : DouyinOpenResponse<POISupplierQueryResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class SyncStatus
                    {
                        /// <summary>
                        /// 获取或设置最近一次同步状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("last_sync_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("last_sync_status")]
                        public int? LastSyncStatus { get; set; }

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
                            public class Category
                            {
                                /// <summary>
                                /// 获取或设置一级分类。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("first_category")]
                                [System.Text.Json.Serialization.JsonPropertyName("first_category")]
                                public string? FirstCategory { get; set; }

                                /// <summary>
                                /// 获取或设置二级分类。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("second_category")]
                                [System.Text.Json.Serialization.JsonPropertyName("second_category")]
                                public string? SecondCategory { get; set; }

                                /// <summary>
                                /// 获取或设置三级分类。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("third_category")]
                                [System.Text.Json.Serialization.JsonPropertyName("third_category")]
                                public string? ThirdCategory { get; set; }
                            }

                            public class Service
                            {
                                public static class Types
                                {
                                    public class Entry
                                    {
                                        public static class Types
                                        {
                                            public class EntryMiniApp
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
                                                public string? PagePath { get; set; }

                                                /// <summary>
                                                /// 获取或设置服务参数（JSON 格式）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("params")]
                                                [System.Text.Json.Serialization.JsonPropertyName("params")]
                                                public string? ParameterJson { get; set; }

                                                /// <summary>
                                                /// 获取或设置是否是测试版。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("is_test")]
                                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                                                [System.Text.Json.Serialization.JsonPropertyName("is_test")]
                                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                                                public bool? IsTest { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置入口类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("entry_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("entry_type")]
                                        public int EntryType { get; set; }

                                        /// <summary>
                                        /// 获取或设置小程序入口信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("entry_mini_app")]
                                        [System.Text.Json.Serialization.JsonPropertyName("entry_mini_app")]
                                        public Types.EntryMiniApp? EntryMiniApp { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置上线状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("enable")]
                                [System.Text.Json.Serialization.JsonPropertyName("enable")]
                                public int Status { get; set; }

                                /// <summary>
                                /// 获取或设置服务类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("service_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("service_type")]
                                public int ServiceType { get; set; }

                                /// <summary>
                                /// 获取或设置入口信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("entry")]
                                [System.Text.Json.Serialization.JsonPropertyName("entry")]
                                public Types.Entry? Entry { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置 POI ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                        public string POIId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置店铺名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置店铺介绍。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置店铺类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置分类信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_info")]
                        public Types.Category? Category { get; set; }

                        /// <summary>
                        /// 获取或设置门店外部 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
                        public string SupplierExternalId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置在线状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置店铺地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string? Address { get; set; }

                        /// <summary>
                        /// 获取或设置联系座机号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact_tel")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact_tel")]
                        public string? ContactTelephone { get; set; }

                        /// <summary>
                        /// 获取或设置联系手机号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact_phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact_phone")]
                        public string? ContactMobilephone { get; set; }

                        /// <summary>
                        /// 获取或设置店铺属性字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attributes")]
                        [System.Text.Json.Serialization.JsonPropertyName("attributes")]
                        public IDictionary<int, object> AttributeMap { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("services")]
                        [System.Text.Json.Serialization.JsonPropertyName("services")]
                        public Types.Service[]? ServiceList { get; set; }

                        /// <summary>
                        /// 获取或设置图片列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("images")]
                        [System.Text.Json.Serialization.JsonPropertyName("images")]
                        public string[]? ImageList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置同步状态信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sync_status")]
                [System.Text.Json.Serialization.JsonPropertyName("sync_status")]
                public Types.SyncStatus SyncStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("data_detail")]
                public Types.Detail Detail { get; set; } = default!;
            }
        }
    }
}
