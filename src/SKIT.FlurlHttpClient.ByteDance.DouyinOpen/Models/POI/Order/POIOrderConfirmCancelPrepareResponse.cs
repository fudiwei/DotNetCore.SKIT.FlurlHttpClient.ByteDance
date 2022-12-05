namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/order/confirm/cancel_prepare 接口的响应。</para>
    /// </summary>
    public class POIOrderConfirmCancelPrepareResponse : DouyinOpenResponse<POIOrderConfirmCancelPrepareResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
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

                /// <summary>
                /// 获取或设置券码 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code_list")]
                [System.Text.Json.Serialization.JsonPropertyName("code_list")]
                public string[] CodeList { get; set; } = default!;
            }
        }
    }
}
