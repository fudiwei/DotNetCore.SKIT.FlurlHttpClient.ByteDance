namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /return_refund/{version}/cancellations 接口的响应。</para>
    /// </summary>
    public class ReturnRefundCreateCancellationResponse : TikTokShopResponse<ReturnRefundCreateCancellationResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置取消 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cancel_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cancel_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string CancelId { get; set; } = default!;

                /// <summary>
                /// 获取或设置取消状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cancel_status")]
                [System.Text.Json.Serialization.JsonPropertyName("cancel_status")]
                public string CancelStatus { get; set; } = default!;
            }
        }
    }
}
