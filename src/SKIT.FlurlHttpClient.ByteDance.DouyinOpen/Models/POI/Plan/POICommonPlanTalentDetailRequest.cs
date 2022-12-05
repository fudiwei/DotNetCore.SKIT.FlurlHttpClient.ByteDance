using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/common/plan/talent/detail 接口的请求。</para>
    /// </summary>
    public class POICommonPlanTalentDetailRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置通用佣金计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 获取或设置达人抖音号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("douyin_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("douyin_id_list")]
        public IList<string> DouyinIdList { get; set; } = new List<string>();
    }
}
