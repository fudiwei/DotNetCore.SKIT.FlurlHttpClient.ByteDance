using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /return_refund/{version}/returns/search 接口的请求。</para>
    /// </summary>
    public class ReturnRefundSearchReturnsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("order_ids")]
        public IList<string>? OrderIdList { get; set; }

        /// <summary>
        /// 获取或设置买家用户 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_user_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_user_ids")]
        public IList<string>? BuyerUserIdList { get; set; }

        /// <summary>
        /// 获取或设置退货 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("return_ids")]
        public IList<string>? ReturnIdList { get; set; }

        /// <summary>
        /// 获取或设置退货类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_types")]
        [System.Text.Json.Serialization.JsonPropertyName("return_types")]
        public IList<string>? ReturnTypeList { get; set; }

        /// <summary>
        /// 获取或设置退货状态列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_status")]
        [System.Text.Json.Serialization.JsonPropertyName("return_status")]
        public IList<string>? ReturnStatusList { get; set; }

        /// <summary>
        /// 获取或设置仲裁状态列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("arbitration_status")]
        [System.Text.Json.Serialization.JsonPropertyName("arbitration_status")]
        public IList<string>? ArbitrationStatusList { get; set; }

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
        /// 获取或设置语种。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("locale")]
        [System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

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
