using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/supplier/sync 接口的请求。</para>
    /// </summary>
    public class POISupplierSyncRequest : DouyinOpenRequest
    {
        public static class Types
        {
            public class Merchant
            {
                public static class Types
                {
                    public class BusinessLicense
                    {
                        /// <summary>
                        /// 获取或设置营业执照外部 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ext_id")]
                        public string? ExternalId { get; set; }

                        /// <summary>
                        /// 获取或设置营业执照公司名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company")]
                        [System.Text.Json.Serialization.JsonPropertyName("company")]
                        public string? Company { get; set; }

                        /// <summary>
                        /// 获取或设置营业执照链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }
                    }

                    public class IndustryLicense
                    {
                        /// <summary>
                        /// 获取或设置行业许可证外部 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ext_id")]
                        public string? ExternalId { get; set; }

                        /// <summary>
                        /// 获取或设置行业许可证链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }
                    }

                    public class OtherInfo
                    {
                        /// <summary>
                        /// 获取或设置补充材料外部 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ext_id")]
                        public string? ExternalId { get; set; }

                        /// <summary>
                        /// 获取或设置补充材料链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }
                    }

                    public class PowerOfAttorney
                    {
                        /// <summary>
                        /// 获取或设置合作协议外部 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ext_id")]
                        public string? ExternalId { get; set; }

                        /// <summary>
                        /// 获取或设置合作协议链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商家营业执照信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_license")]
                [System.Text.Json.Serialization.JsonPropertyName("business_license")]
                public Types.BusinessLicense? BusinessLicense { get; set; }

                /// <summary>
                /// 获取或设置商家行业许可证信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_license")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_license")]
                public IList<Types.IndustryLicense>? IndustryLicenseList { get; set; }

                /// <summary>
                /// 获取或设置补充信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("other_info")]
                [System.Text.Json.Serialization.JsonPropertyName("other_info")]
                public IList<Types.OtherInfo>? OtherInfoList { get; set; }

                /// <summary>
                /// 获取或设置合作协议信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("power_of_attorney")]
                [System.Text.Json.Serialization.JsonPropertyName("power_of_attorney")]
                public Types.PowerOfAttorney? PowerOfAttorney { get; set; }
            }

            public class ServiceProvider
            {
                /// <summary>
                /// 获取或设置服务商营业执照外部 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_license_ext_id")]
                [System.Text.Json.Serialization.JsonPropertyName("business_license_ext_id")]
                public string? BusinessLicenseExternalId { get; set; }

                /// <summary>
                /// 获取或设置服务商行业许可证外部 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_license_ext_id")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_license_ext_id")]
                public IList<string>? IndustryLicenseExternalIdList { get; set; }
            }

            public class Recommend
            {
                /// <summary>
                /// 获取或设置推荐描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置推荐内容图片或视频 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_url")]
                [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                public string? ImageOrVideoUrl { get; set; }
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
                                public string AppId { get; set; } = string.Empty;

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
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("is_test")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
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
        public string POIId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置店铺名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

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
        /// 获取或设置品类编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type_code")]
        [System.Text.Json.Serialization.JsonPropertyName("type_code")]
        public string? TypeCode { get; set; }

        /// <summary>
        /// 获取或设置品类描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type_name")]
        [System.Text.Json.Serialization.JsonPropertyName("type_name")]
        public string? TypeName { get; set; }

        /// <summary>
        /// 获取或设置门店外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
        public string SupplierExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置在线状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

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
        /// 获取或设置人均消费（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avg_cost")]
        [System.Text.Json.Serialization.JsonPropertyName("avg_cost")]
        public int? AverageCost { get; set; }

        /// <summary>
        /// 获取或设置商家资质信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer_info")]
        [System.Text.Json.Serialization.JsonPropertyName("customer_info")]
        public Types.Merchant? Merchant { get; set; }

        /// <summary>
        /// 获取或设置服务商资质信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_provider")]
        [System.Text.Json.Serialization.JsonPropertyName("service_provider")]
        public Types.ServiceProvider? ServiceProvider { get; set; }

        /// <summary>
        /// 获取或设置店铺属性字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attributes")]
        [System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public IDictionary<int, object> Attribute { get; set; } = new Dictionary<int, object>();

        /// <summary>
        /// 获取或设置推荐列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recommends")]
        [System.Text.Json.Serialization.JsonPropertyName("recommends")]
        public IList<Types.Recommend>? RecommendList { get; set; }

        /// <summary>
        /// 获取或设置服务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("services")]
        [System.Text.Json.Serialization.JsonPropertyName("services")]
        public IList<Types.Service>? ServiceList { get; set; }

        /// <summary>
        /// 获取或设置营业时间范围字符串列表（格式：HH:mm-HH:mm）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_time")]
        [System.Text.Json.Serialization.JsonPropertyName("open_time")]
        public IList<string>? OpenTimeRangeList { get; set; }

        /// <summary>
        /// 获取或设置标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tags")]
        [System.Text.Json.Serialization.JsonPropertyName("tags")]
        public IList<string>? TagList { get; set; }

        /// <summary>
        /// 获取或设置图片列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images")]
        [System.Text.Json.Serialization.JsonPropertyName("images")]
        public IList<string>? ImageList { get; set; }
    }
}
