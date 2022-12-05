using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/orienPlanAuthorsAdd 接口的请求。</para>
    /// </summary>
    public class BuyinOrientPlanAuthorsAddRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置定向计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orien_plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("orien_plan_id")]
        public string OrientPlanId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置达人百应 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyin_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("buyin_ids")]
        public IList<int> BuyinIdList { get; set; } = new List<int>();
    }
}
