namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/utility/check_redeem_amounts/ 接口的响应。</para>
    /// </summary>
    public class MinisUtilityCheckRedeemAmountsResponse : TikTokV2Response<MinisUtilityCheckRedeemAmountsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置是否有效。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid")]
                [System.Text.Json.Serialization.JsonPropertyName("valid")]
                public bool IsValid { get; set; }
            }
        }
    }
}
