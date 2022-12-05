using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/poi/poi/update 接口的请求。</para>
    /// </summary>
    public class GoodLifePOIUpdateV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class POI
            {
                public static class Types
                {
                    public class POIInfo
                    {
                        /// <summary>
                        /// 获取或设置门店名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_name")]
                        public string? POIName { get; set; }

                        /// <summary>
                        /// 获取或设置店面照片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("head_image_urls")]
                        [System.Text.Json.Serialization.JsonPropertyName("head_image_urls")]
                        public IList<string>? HeadImageUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置行业代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("industry_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
                        public string? IndustryCode { get; set; }

                        /// <summary>
                        /// 获取或设置地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string? Address { get; set; }

                        /// <summary>
                        /// 获取或设置营业状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_status")]
                        public int? OpenStatus { get; set; }

                        /// <summary>
                        /// 获取或设置营业时间字符串列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_time")]
                        public IList<string>? OpenTimeStringList { get; set; }

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

                    public class Service : POISupplierSyncRequest.Types.Service
                    {
                        public static new class Types
                        {
                            public class Entry : POISupplierSyncRequest.Types.Service.Types.Entry
                            {
                                public static new class Types
                                {
                                    public class EntryMiniApp : POISupplierSyncRequest.Types.Service.Types.Entry.Types.EntryMiniApp
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置小程序入口信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("entry_mini_app")]
                                [System.Text.Json.Serialization.JsonPropertyName("entry_mini_app")]
                                public new Types.EntryMiniApp? EntryMiniApp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置入口信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("entry")]
                        [System.Text.Json.Serialization.JsonPropertyName("entry")]
                        public new Types.Entry? Entry { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置三方 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_id")]
                [System.Text.Json.Serialization.JsonPropertyName("third_id")]
                public string ThirdId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi_id")]
                [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                public string POIId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi_type")]
                [System.Text.Json.Serialization.JsonPropertyName("poi_type")]
                public int? POIType { get; set; }

                /// <summary>
                /// 获取或设置门店信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi_info")]
                [System.Text.Json.Serialization.JsonPropertyName("poi_info")]
                public Types.POIInfo? POIInfo { get; set; }

                /// <summary>
                /// 获取或设置服务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("services")]
                [System.Text.Json.Serialization.JsonPropertyName("services")]
                public IList<Types.Service>? ServiceList { get; set; }
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
