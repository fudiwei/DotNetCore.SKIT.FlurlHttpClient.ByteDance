namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/shipping_info/update 接口的响应。</para>
    /// </summary>
    public class FulfillmentUpdatePackageShippingInfoResponse : TikTokShopLegacyResponse<FulfillmentUpdatePackageShippingInfoResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置更新结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_success")]
                [System.Text.Json.Serialization.JsonPropertyName("update_success")]
                public bool Result { get; set; }

                /// <summary>
                /// 获取或设置失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_reason")]
                public string? FailedReason { get; set; } = default!;
            }
        }
    }
}
