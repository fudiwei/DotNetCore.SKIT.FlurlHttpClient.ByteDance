namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/fulfillment/order_can_use 接口的响应。</para>
    /// </summary>
    public class AppsTradeFulfillmentOrderCanUseV2Response : DouyinOpenResponse<AppsTradeFulfillmentOrderCanUseV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Certificate : AppsTradeFulfillmentQueryUserCertificatesV2Response.Types.Data.Types.Order.Types.Certificate
                    {
                    }
                }

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置券列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificates")]
                [System.Text.Json.Serialization.JsonPropertyName("certificates")]
                public Types.Certificate[] CertificateList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否可用。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_use")]
                [System.Text.Json.Serialization.JsonPropertyName("can_use")]
                public bool CanUse { get; set; }
            }
        }
    }
}
