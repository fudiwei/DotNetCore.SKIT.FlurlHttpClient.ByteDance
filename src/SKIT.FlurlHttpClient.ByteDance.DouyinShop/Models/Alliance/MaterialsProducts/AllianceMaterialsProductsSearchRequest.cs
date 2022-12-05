using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /alliance/materialsProductsSearch 接口的请求。</para>
    /// </summary>
    public class AllianceMaterialsProductsSearchRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置商品标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 获取或设置商品一级类目 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_cids")]
        [System.Text.Json.Serialization.JsonPropertyName("first_cids")]
        public IList<int>? FirstCategoryIdList { get; set; }

        /// <summary>
        /// 获取或设置商品二级类目 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("second_cids")]
        [System.Text.Json.Serialization.JsonPropertyName("second_cids")]
        public IList<int>? SecondCategoryIdList { get; set; }

        /// <summary>
        /// 获取或设置商品三级类目 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("third_cids")]
        [System.Text.Json.Serialization.JsonPropertyName("third_cids")]
        public IList<int>? ThirdCategoryIdList { get; set; }

        /// <summary>
        /// 获取或设置商品售价区间最小值（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price_min")]
        [System.Text.Json.Serialization.JsonPropertyName("price_min")]
        public int? MinPrice { get; set; }

        /// <summary>
        /// 获取或设置商品售价区间最大值（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price_max")]
        [System.Text.Json.Serialization.JsonPropertyName("price_max")]
        public int? MaxPrice { get; set; }

        /// <summary>
        /// 获取或设置商品历史总销量区间最小值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sell_num_min")]
        [System.Text.Json.Serialization.JsonPropertyName("sell_num_min")]
        public int? MinSales { get; set; }

        /// <summary>
        /// 获取或设置商品历史总销量区间最大值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sell_num_max")]
        [System.Text.Json.Serialization.JsonPropertyName("sell_num_max")]
        public int? MaxSales { get; set; }

        /// <summary>
        /// 获取或设置商品佣金区间最小值（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cos_fee_min")]
        [System.Text.Json.Serialization.JsonPropertyName("cos_fee_min")]
        public int? MinCOSFee { get; set; }

        /// <summary>
        /// 获取或设置商品佣金区间最大值（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cos_fee_max")]
        [System.Text.Json.Serialization.JsonPropertyName("cos_fee_max")]
        public int? MaxCOSFee { get; set; }

        /// <summary>
        /// 获取或设置商品佣金比例区间最小值（范围：0～100）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cos_ratio_min")]
        [System.Text.Json.Serialization.JsonPropertyName("cos_ratio_min")]
        public double? MinCOSRatio { get; set; }

        /// <summary>
        /// 获取或设置商品佣金比例区间最大值（范围：0～100）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cos_ratio_max")]
        [System.Text.Json.Serialization.JsonPropertyName("cos_ratio_max")]
        public double? MaxCOSRatio { get; set; }

        /// <summary>
        /// 获取或设置翻页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 获取或设置翻页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 获取或设置排序方式类型。
        /// <para>默认值：0</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sort_type")]
        public int SortByType { get; set; }

        /// <summary>
        /// 获取或设置排序字段类型。
        /// <para>默认值：0</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_type")]
        [System.Text.Json.Serialization.JsonPropertyName("search_type")]
        public int SortFieldType { get; set; }
    }
}
