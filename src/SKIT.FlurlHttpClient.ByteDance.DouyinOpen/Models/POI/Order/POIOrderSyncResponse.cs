namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/order/sync 接口的响应。</para>
    /// </summary>
    public class POIOrderSyncResponse : DouyinOpenResponse<POIOrderSyncResponse.Types.Data>
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
            }
        }
    }
}
