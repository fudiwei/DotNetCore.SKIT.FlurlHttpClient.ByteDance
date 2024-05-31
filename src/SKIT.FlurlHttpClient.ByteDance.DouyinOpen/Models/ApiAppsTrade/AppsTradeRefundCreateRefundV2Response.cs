namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/refund/create_refund 接口的响应。</para>
    /// </summary>
    public class AppsTradeRefundCreateRefundV2Response : DouyinOpenResponse<AppsTradeRefundCreateRefundV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置退款单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_id")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
                public string RefundId { get; set; } = default!;
            }
        }
    }
}
