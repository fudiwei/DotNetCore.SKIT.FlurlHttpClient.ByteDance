namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/batch_rts 接口的响应。</para>
    /// </summary>
    public class FulfillmentBatchShipPackageResponse : TikTokShopResponse<FulfillmentBatchShipPackageResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class FailedPackage : FulfillmentShipPackageResponse.Types.Data.Types.FailedPackage
                    {
                    }
                }

                /// <summary>
                /// 获取或设置失败包裹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_packages_list")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_packages_list")]
                public Types.FailedPackage[] FailedPackageList { get; set; } = default!;
            }
        }
    }
}
