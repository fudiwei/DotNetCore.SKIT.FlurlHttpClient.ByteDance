namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/ext/presale_groupon/order/create 接口的请求。</para>
    /// </summary>
    public class POIExternalPresaleGrouponOrderCreateRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public override string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置达人抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cps_user_short_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cps_user_short_id")]
        public string? CPSUserShortId { get; set; }

        /// <summary>
        /// 获取或设置达人分佣率（单位：万分数）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cps_take_rate")]
        [System.Text.Json.Serialization.JsonPropertyName("cps_take_rate")]
        public double? COSTakeRate { get; set; }

        /// <summary>
        /// 获取或设置用户预留手机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("user_phone")]
        public string? UserPhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置商品外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("spu_ext_id")]
        public string SPUExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置购买数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("num")]
        [System.Text.Json.Serialization.JsonPropertyName("num")]
        public int Count { get; set; }

        /// <summary>
        /// 获取或设置总价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_price")]
        [System.Text.Json.Serialization.JsonPropertyName("total_price")]
        public int TotalPrice { get; set; }
    }
}
