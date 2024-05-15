namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/{version}/packages/search 接口的请求。</para>
    /// </summary>
    public class FulfillmentSearchPackagesRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置创建时间范围起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_ge")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_ge")]
        public long? CreateTimestampGreaterThan { get; set; }

        /// <summary>
        /// 获取或设置创建时间范围截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_lt")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_lt")]
        public long? CreateTimestampLessThan { get; set; }

        /// <summary>
        /// 获取或设置更新时间范围起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_ge")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_ge")]
        public long? UpdateTimestampGreaterThan { get; set; }

        /// <summary>
        /// 获取或设置更新时间范围截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_lt")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_lt")]
        public long? UpdateTimestampLessThan { get; set; }

        /// <summary>
        /// 获取或设置包裹状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_status")]
        [System.Text.Json.Serialization.JsonPropertyName("package_status")]
        public string? PackageStatus { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? PageSize { get; set; }

        /// <summary>
        /// 获取或设置分页令牌。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? PageToken { get; set; }
    }
}
