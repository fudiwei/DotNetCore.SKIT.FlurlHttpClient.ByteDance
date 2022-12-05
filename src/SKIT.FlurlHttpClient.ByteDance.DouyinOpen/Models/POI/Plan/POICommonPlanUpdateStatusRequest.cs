using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/common/plan/update/status 接口的请求。</para>
    /// </summary>
    public class POICommonPlanUpdateStatusRequest : DouyinOpenRequest
    {
        public static class Types
        {
            public class Plan
            {
                /// <summary>
                /// 获取或设置计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plan_id")]
                [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
                public long PlanId { get; set; }

                /// <summary>
                /// 获取或设置计划状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置待更新的计划列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_update_list")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_update_list")]
        public IList<Types.Plan> PlanList { get; set; } = new List<Types.Plan>();
    }
}
