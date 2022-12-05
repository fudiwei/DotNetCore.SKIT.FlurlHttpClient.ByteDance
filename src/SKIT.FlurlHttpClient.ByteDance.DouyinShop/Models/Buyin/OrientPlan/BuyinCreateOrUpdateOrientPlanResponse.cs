namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/createOrUpdateOrienPlan 接口的响应。</para>
    /// </summary>
    public class BuyinCreateOrUpdateOrientPlanResponse : DouyinShopResponse<BuyinCreateOrUpdateOrientPlanResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置定向计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plan_id")]
                [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
                public string OrientPlanId { get; set; } = default!;
            }
        }
    }
}
