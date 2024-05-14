namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /return_refund/{version}/refunds/calculate 接口的响应。</para>
    /// </summary>
    public class ReturnRefundCalculateRefundResponse : TikTokShopResponse<ReturnRefundCalculateRefundResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class RefundAmount : ReturnRefundSearchReturnsResponse.Types.Data.Types.Return.Types.RefundAmount
                    {
                    }
                }

                /// <summary>
                /// 获取或设置退款金额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("order_refund_amount")]
                public Types.RefundAmount RefundAmount { get; set; } = default!;
            }
        }
    }
}
