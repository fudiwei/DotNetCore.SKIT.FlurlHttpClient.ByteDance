namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/common/plan/save 接口的响应。</para>
    /// </summary>
    public class POICommonPlanSaveResponse : TikTokResponse<POICommonPlanSaveResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plan_id")]
                [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
                public long PlanId { get; set; }
            }
        }
    }
}
