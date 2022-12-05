namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/ext/presale_groupon/order/create 接口的响应。</para>
    /// </summary>
    public class POIExternalPresaleGrouponOrderCreateResponse : DouyinOpenResponse<POIExternalPresaleGrouponOrderCreateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置订单外部 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_ext_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_ext_id")]
                public string OrderExternalId { get; set; } = default!;
            }
        }
    }
}
