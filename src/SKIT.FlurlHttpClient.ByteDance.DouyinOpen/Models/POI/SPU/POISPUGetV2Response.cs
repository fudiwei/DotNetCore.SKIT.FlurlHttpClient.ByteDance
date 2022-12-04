using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/v2/spu/get 接口的响应。</para>
    /// </summary>
    public class POISPUGetV2Response : DouyinOpenResponse<POISPUGetV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class SPU
                    {
                        public static class Types
                        {
                            public class Entry
                            {
                                public static class Types
                                {
                                    public class EntryMiniApp : POISupplierQueryResponse.Types.Data.Types.Detail.Types.Service.Types.Entry.Types.EntryMiniApp
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置入口类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("entry_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("entry_type")]
                                public int EntryType { get; set; }

                                /// <summary>
                                /// 获取或设置入口链接。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("entry_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("entry_url")]
                                public string? EntryUrl { get; set; }

                                /// <summary>
                                /// 获取或设置小程序入口信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("entry_miniApp")]
                                [System.Text.Json.Serialization.JsonPropertyName("entry_miniApp")]
                                public Types.EntryMiniApp? EntryMiniApp { get; set; }
                            }

                            public class Highlight
                            {
                                /// <summary>
                                /// 获取或设置介绍。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("content")]
                                [System.Text.Json.Serialization.JsonPropertyName("content")]
                                public string Content { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置优先级。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("priority")]
                                [System.Text.Json.Serialization.JsonPropertyName("priority")]
                                public int Priority { get; set; }
                            }

                            public class SPUFilterStatus
                            {
                                public static class Types
                                {
                                    public class SPUPOIFilterStatus
                                    {
                                        /// <summary>
                                        /// 获取或设置过滤码。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("code")]
                                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                                        public int Code { get; set; }

                                        /// <summary>
                                        /// 获取或设置是否被过滤。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("filter")]
                                        [System.Text.Json.Serialization.JsonPropertyName("filter")]
                                        public bool IsFilter { get; set; }

                                        /// <summary>
                                        /// 获取或设置 POI ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("poi_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                                        public string? POIId { get; set; }

                                        /// <summary>
                                        /// 获取或设置过滤原因。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("reason")]
                                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                                        public string? Reason { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置 SPU POI 过滤结果列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("spu_poi_filter_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("spu_poi_filter_status")]
                                public Types.SPUPOIFilterStatus[]? SPUPOIFilterStatusList { get; set; }

                                /// <summary>
                                /// 获取或设置供应商 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("supplier_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("supplier_id")]
                                public string? SupplierId { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置 SPU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spu_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("spu_id")]
                        public string SPUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SPU 外部 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spu_ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("spu_ext_id")]
                        public string SPUExternalId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置可用门店外部 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_ext_id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id_list")]
                        public string[] SupplierExternalIdList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SPU 类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spu_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("spu_type")]
                        public int SPUType { get; set; }

                        /// <summary>
                        /// 获取或设置入口信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("entry_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("entry_info")]
                        public Types.Entry? Entry { get; set; }

                        /// <summary>
                        /// 获取或设置前台品类标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("front_category_tag")]
                        [System.Text.Json.Serialization.JsonPropertyName("front_category_tag")]
                        public string[]? FrontCategoryTagList { get; set; }

                        /// <summary>
                        /// 获取或设置推荐语。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("recommend_word")]
                        [System.Text.Json.Serialization.JsonPropertyName("recommend_word")]
                        public string? RecommendWord { get; set; }

                        /// <summary>
                        /// 获取或设置排序权重。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sort_weight")]
                        [System.Text.Json.Serialization.JsonPropertyName("sort_weight")]
                        public long? SortWeight { get; set; }

                        /// <summary>
                        /// 获取或设置原价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("origin_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("origin_price")]
                        public int OriginPrice { get; set; }

                        /// <summary>
                        /// 获取或设置价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public int Price { get; set; }

                        /// <summary>
                        /// 获取或设置图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_list")]
                        public string[]? ImageUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置结算类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_settle_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_settle_type")]
                        public int? SettleType { get; set; }

                        /// <summary>
                        /// 获取或设置分佣率（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("take_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("take_rate")]
                        public double? TakeRate { get; set; }

                        /// <summary>
                        /// 获取或设置 SPU 属性字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attribute")]
                        [System.Text.Json.Serialization.JsonPropertyName("attribute")]
                        public IDictionary<int, object> AttributeMap { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品亮点列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("highlights")]
                        [System.Text.Json.Serialization.JsonPropertyName("highlights")]
                        public Types.Highlight[]? HighlightList { get; set; }

                        /// <summary>
                        /// 获取或设置在线状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置在线状态说明。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("status_desc")]
                        public string StatusDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置库存数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock")]
                        public int Stock { get; set; }

                        /// <summary>
                        /// 获取或设置 SPU 过滤结果列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spu_filter_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("spu_filter_status")]
                        public Types.SPUFilterStatus[]? SPUFilterStatusList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置 SPU 详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_detail")]
                public Types.SPU SPUDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置 SPU 草稿列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_draft")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_draft")]
                public Types.SPU[]? SPUDraftList { get; set; }
            }
        }
    }
}
