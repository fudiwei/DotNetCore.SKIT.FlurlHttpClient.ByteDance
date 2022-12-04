namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/order/confirm/prepare 接口的响应。</para>
    /// </summary>
    public class POIOrderConfirmPrepareResponse : TikTokResponse<POIOrderConfirmPrepareResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置核销单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("confirm_apply_id")]
                [System.Text.Json.Serialization.JsonPropertyName("confirm_apply_id")]
                public string ConfirmApplyId { get; set; } = default!;
            }
        }
    }
}
