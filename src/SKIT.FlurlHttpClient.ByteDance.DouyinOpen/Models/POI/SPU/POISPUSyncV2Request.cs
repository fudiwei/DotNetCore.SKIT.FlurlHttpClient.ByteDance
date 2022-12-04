using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/spu/sync 接口的请求。</para>
    /// </summary>
    public class POISPUSyncV2Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class Entry
            {
                public static class Types
                {
                    public class EntryMiniApp : POISupplierSyncRequest.Types.Service.Types.Entry.Types.EntryMiniApp
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
                public string Content { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置优先级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("priority")]
                [System.Text.Json.Serialization.JsonPropertyName("priority")]
                public int Priority { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置 SPU 外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("spu_ext_id")]
        public string SPUExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置可用门店外部 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_ext_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id_list")]
        public IList<string> SupplierExternalIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置商品名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

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
        public IList<string>? FrontCategoryTagList { get; set; }

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
        public IList<string>? ImageUrlList { get; set; }

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
        public IDictionary<int, object> AttributeMap { get; set; } = new Dictionary<int, object>();

        /// <summary>
        /// 获取或设置商品亮点列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("highlights")]
        [System.Text.Json.Serialization.JsonPropertyName("highlights")]
        public IList<Types.Highlight>? HighlightList { get; set; }

        /// <summary>
        /// 获取或设置下单是否依赖日期。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_depends_on_date")]
        [System.Text.Json.Serialization.JsonPropertyName("order_depends_on_date")]
        public bool? IsOrderDependsOnDate { get; set; }

        /// <summary>
        /// 获取或设置在线状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置库存数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock")]
        [System.Text.Json.Serialization.JsonPropertyName("stock")]
        public int Stock { get; set; }
    }
}
