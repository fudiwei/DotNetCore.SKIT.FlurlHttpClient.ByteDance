namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/coupon/sync 接口的响应。</para>
    /// </summary>
    public class POICouponSyncV2Response : DouyinOpenResponse<POICouponSyncV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                /// <summary>
                /// 获取或设置是否同步成功。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_suc")]
                [System.Text.Json.Serialization.JsonPropertyName("is_suc")]
                public bool IsSucceeded { get; set; }

                /// <summary>
                /// 获取或设置优惠券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                public string? CouponId { get; set; }
            }
        }
    }
}
