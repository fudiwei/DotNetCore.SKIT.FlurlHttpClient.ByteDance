namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/orienPlanCtrl 接口的请求。</para>
    /// </summary>
    public class BuyinOrientPlanControlRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置定向计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orien_plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("orien_plan_id")]
        public string OrientPlanId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public int Action { get; set; }
    }
}
