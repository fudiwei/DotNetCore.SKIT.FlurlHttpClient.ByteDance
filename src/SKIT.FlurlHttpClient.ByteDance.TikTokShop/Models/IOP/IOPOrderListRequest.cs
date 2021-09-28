namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/orderList 接口的请求。</para>
    /// </summary>
    public class IOPOrderListRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置更新时间开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_update_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_update_time")]
        public long StartUpdateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置更新时间结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_update_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_update_time")]
        public long EndUpdateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置分配状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distr_status")]
        [System.Text.Json.Serialization.JsonPropertyName("distr_status")]
        public int? DistributeStatus { get; set; }

        /// <summary>
        /// 获取或设置翻页页数。
        /// <para>默认值：0</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int PageNumber { get; set; }

        /// <summary>
        /// 获取或设置翻页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int PageSize { get; set; } = 10;
    }
}
