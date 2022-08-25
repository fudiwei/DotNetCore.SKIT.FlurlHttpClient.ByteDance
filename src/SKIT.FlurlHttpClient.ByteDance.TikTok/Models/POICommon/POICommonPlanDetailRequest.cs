using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/common/plan/detail 接口的请求。</para>
    /// </summary>
    public class POICommonPlanDetailRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置通用佣金计划 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id_list")]
        public IList<long> PlanIdList { get; set; } = new List<long>();
    }
}
