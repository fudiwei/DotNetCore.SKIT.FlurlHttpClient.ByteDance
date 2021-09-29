namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/waybillReturn 接口的响应。</para>
    /// </summary>
    public class IOPWaybillReturnResponse : TikTokShopResponse<IOPWaybillReturnResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置返回结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_result")]
                [System.Text.Json.Serialization.JsonPropertyName("return_result")]
                public bool Result { get; set; }

                /// <summary>
                /// 获取或设置包裹单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string? DeliveryId { get; set; }
            }
        }
    }
}
