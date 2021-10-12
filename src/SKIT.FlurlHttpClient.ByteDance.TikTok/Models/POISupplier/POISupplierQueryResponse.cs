using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/supplier/query 接口的响应。</para>
    /// </summary>
    public class POISupplierQueryResponse : TikTokResponse<POISupplierQueryResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
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

                            public class Attribute : Dictionary<int, object>
                            {
                                public static class Types
                                {
                                    public class HotelService
                                    {
                                        /// <summary>
                                        /// 获取或设置设施/服务编码。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("code")]
                                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                                        public string? Code { get; set; }

                                        /// <summary>
                                        /// 获取或设置设施/服务名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string? Name { get; set; }
                                    }

                                    public class HotelFacility : HotelService
                                    {
                                    }

                                    public class HotelFeature : HotelService
                                    {
                                    }

                                    public class HotelPolicy
                                    {
                                        public static class Types
                                        {
                                            public class Breakfast
                                            {
                                                /// <summary>
                                                /// 获取或设置早餐类型。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("type")]
                                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                                public int Type { get; set; }

                                                /// <summary>
                                                /// 获取或设置早餐价格（单位：分）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("price")]
                                                [System.Text.Json.Serialization.JsonPropertyName("price")]
                                                public int? Price { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置入住时间字符串（格式：HH:mm）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("check_in_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("check_in_time")]
                                        public string? CheckinTimeString { get; set; }

                                        /// <summary>
                                        /// 获取或设置离店时间字符串（格式：HH:mm）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("check_out_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("check_out_time")]
                                        public string? CheckoutTimeString { get; set; }

                                        /// <summary>
                                        /// 获取或设置早餐信息。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("breakfast")]
                                        [System.Text.Json.Serialization.JsonPropertyName("breakfast")]
                                        public Types.Breakfast? Breakfast { get; set; }

                                        /// <summary>
                                        /// 获取或设置儿童政策。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("child")]
                                        [System.Text.Json.Serialization.JsonPropertyName("child")]
                                        public string? Kid { get; set; }

                                        /// <summary>
                                        /// 获取或设置宠物政策。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("pet")]
                                        [System.Text.Json.Serialization.JsonPropertyName("pet")]
                                        public string? Pet { get; set; }
                                    }

                                    public class ScenicInstruction
                                    {
                                        public static class Types
                                        {
                                            public class Node
                                            {
                                                /// <summary>
                                                /// 获取或设置节点类型。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("node_type")]
                                                [System.Text.Json.Serialization.JsonPropertyName("node_type")]
                                                public int NodeType { get; set; }

                                                /// <summary>
                                                /// 获取或设置节点内容。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("content")]
                                                [System.Text.Json.Serialization.JsonPropertyName("content")]
                                                public string? Content { get; set; }
                                            }

                                            public class PreferentialPolicyExtra
                                            {
                                                public static class Types
                                                {
                                                    public class Facility
                                                    {
                                                        /// <summary>
                                                        /// 获取或设置设施名称。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("name")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                                        public string? Name { get; set; }
                                                    }

                                                    public class Policy
                                                    {
                                                        /// <summary>
                                                        /// 获取或设置适用条件。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("condition")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("condition")]
                                                        public string? Condition { get; set; }

                                                        /// <summary>
                                                        /// 获取或设置优待内容。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("discount")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("discount")]
                                                        public string? Discount { get; set; }

                                                        /// <summary>
                                                        /// 获取或设置限定人群。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("population")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("population")]
                                                        public string? Population { get; set; }
                                                    }
                                                }

                                                /// <summary>
                                                /// 获取或设置设施列表。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("facility")]
                                                [System.Text.Json.Serialization.JsonPropertyName("facility")]
                                                public Types.Facility[]? FacilityList { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置宠物携带类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("pet")]
                                        [System.Text.Json.Serialization.JsonPropertyName("pet")]
                                        public int? PetType { get; set; }

                                        /// <summary>
                                        /// 获取或设置玩法介绍富文本节点列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("play_intro")]
                                        [System.Text.Json.Serialization.JsonPropertyName("play_intro")]
                                        public Types.Node[]? PlayIntroductionNodeList { get; set; }

                                        /// <summary>
                                        /// 获取或设置景点介绍富文本节点列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("scenic_intro")]
                                        [System.Text.Json.Serialization.JsonPropertyName("scenic_intro")]
                                        public Types.Node[]? ScenicIntroductionNodeList { get; set; }

                                        /// <summary>
                                        /// 获取或设置交通介绍富文本节点列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("traffic")]
                                        [System.Text.Json.Serialization.JsonPropertyName("traffic")]
                                        public Types.Node[]? TrafficNodeList { get; set; }

                                        /// <summary>
                                        /// 获取或设置开放时间。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("open_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("open_time")]
                                        public string? OpenTime { get; set; }

                                        /// <summary>
                                        /// 获取或设置开放时间扩展信息富文本节点列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("open_time_ext")]
                                        [System.Text.Json.Serialization.JsonPropertyName("open_time_ext")]
                                        public Types.Node[]? OpenTimeExtraList { get; set; }

                                        /// <summary>
                                        /// 获取或设置优待政策扩展信息列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("preferential_policy_ext")]
                                        [System.Text.Json.Serialization.JsonPropertyName("preferential_policy_ext")]
                                        public Types.PreferentialPolicyExtra[]? PreferentialPolicyExtraList { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置酒店服务列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonIgnore]
                                [System.Text.Json.Serialization.JsonIgnore]
                                public Types.HotelService[]? HotelServiceList
                                {
                                    get
                                    {
                                        if (this.TryGetValue(1101, out object obj) && obj is Types.HotelService[] value)
                                        {
                                            return value;
                                        }

                                        return null;
                                    }
                                    set
                                    {
                                        this[1101] = value!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置酒店服务列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonIgnore]
                                [System.Text.Json.Serialization.JsonIgnore]
                                public Types.HotelFacility[]? HotelFacilityList
                                {
                                    get
                                    {
                                        if (this.TryGetValue(1102, out object obj) && obj is Types.HotelFacility[] value)
                                        {
                                            return value;
                                        }

                                        return null;
                                    }
                                    set
                                    {
                                        this[1102] = value!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置酒店特色项目列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonIgnore]
                                [System.Text.Json.Serialization.JsonIgnore]
                                public Types.HotelFeature[]? HotelFeatureList
                                {
                                    get
                                    {
                                        if (this.TryGetValue(1103, out object obj) && obj is Types.HotelFeature[] value)
                                        {
                                            return value;
                                        }

                                        return null;
                                    }
                                    set
                                    {
                                        this[1103] = value!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置酒店政策信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonIgnore]
                                [System.Text.Json.Serialization.JsonIgnore]
                                public Types.HotelPolicy? HotelPolicy
                                {
                                    get
                                    {
                                        if (this.TryGetValue(1104, out object obj) && obj is Types.HotelPolicy value)
                                        {
                                            return value;
                                        }

                                        return null;
                                    }
                                    set
                                    {
                                        this[1104] = value!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置景区须知信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonIgnore]
                                [System.Text.Json.Serialization.JsonIgnore]
                                public Types.ScenicInstruction? ScenicInstruction
                                {
                                    get
                                    {
                                        if (this.TryGetValue(3101, out object obj) && obj is Types.ScenicInstruction value)
                                        {
                                            return value;
                                        }

                                        return null;
                                    }
                                    set
                                    {
                                        this[3101] = value!;
                                    }
                                }
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
                                        public Types.EntryMiniApp? MiniApp { get; set; }
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
                        /// 获取或设置接入方店铺外部 ID。
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
                        /// 获取或设置店铺属性信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attributes")]
                        [System.Text.Json.Serialization.JsonPropertyName("attributes")]
                        public Types.Attribute? Attribute { get; set; }

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
