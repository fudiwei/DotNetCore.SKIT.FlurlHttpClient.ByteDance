namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /return_refund/{version}/returns 接口的响应。</para>
    /// </summary>
    public class ReturnRefundCreateReturnResponse : TikTokShopResponse<ReturnRefundCreateReturnResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置退货 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_id")]
                [System.Text.Json.Serialization.JsonPropertyName("return_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string ReturnId { get; set; } = default!;

                /// <summary>
                /// 获取或设置退货状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_status")]
                [System.Text.Json.Serialization.JsonPropertyName("return_status")]
                public string ReturnStatus { get; set; } = default!;
            }
        }
    }
}
