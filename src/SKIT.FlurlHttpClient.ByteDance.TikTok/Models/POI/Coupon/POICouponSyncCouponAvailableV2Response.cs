namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/coupon/sync/coupon_available 接口的响应。</para>
    /// </summary>
    public class POICouponSyncCouponAvailableV2Response : TikTokResponse<POICouponSyncCouponAvailableV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置是否同步成功。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_suc")]
                [System.Text.Json.Serialization.JsonPropertyName("is_suc")]
                public bool IsSucceeded { get; set; }
            }
        }
    }
}
