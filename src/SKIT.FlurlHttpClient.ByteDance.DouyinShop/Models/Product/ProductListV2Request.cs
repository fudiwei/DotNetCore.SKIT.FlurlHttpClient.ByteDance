namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/listV2 接口的请求。</para>
    /// </summary>
    public class ProductListV2Request : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置商品上下架状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置商品审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("check_status")]
        [System.Text.Json.Serialization.JsonPropertyName("check_status")]
        public int? CheckStatus { get; set; }

        /// <summary>
        /// 获取或设置商品类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_type")]
        [System.Text.Json.Serialization.JsonPropertyName("product_type")]
        public int? ProductType { get; set; }

        /// <summary>
        /// 获取或设置创建时间区间开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long? CreateStartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置创建时间区间结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? CreateEndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置更新时间区间开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("update_start_time")]
        public long? UpdateStartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置更新时间区间结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("update_end_time")]
        public long? UpdateEndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置翻页页数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 获取或设置翻页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? PageSize { get; set; }
    }
}
