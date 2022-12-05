namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/common/plan/update/status 接口的响应。</para>
    /// </summary>
    public class POICommonPlanUpdateStatusResponse : DouyinOpenResponse<POICommonPlanUpdateStatusResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置更新失败的计划 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_plan_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_plan_id_list")]
                public long[]? FailedPlanIdList { get; set; } = default!;
            }
        }
    }
}
