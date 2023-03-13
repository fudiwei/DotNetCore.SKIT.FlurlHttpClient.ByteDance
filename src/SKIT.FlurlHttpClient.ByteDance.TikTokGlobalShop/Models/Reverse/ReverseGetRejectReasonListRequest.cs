namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /reverse/reverse_reason/list 接口的请求。</para>
    /// </summary>
    public class ReverseGetRejectReasonListRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? ActionType { get; set; }

        /// <summary>
        /// 获取或设置原因类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? ReasonType { get; set; }

        /// <summary>
        /// 获取或设置配送状态。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? FulfillmentStatus { get; set; }
    }
}
