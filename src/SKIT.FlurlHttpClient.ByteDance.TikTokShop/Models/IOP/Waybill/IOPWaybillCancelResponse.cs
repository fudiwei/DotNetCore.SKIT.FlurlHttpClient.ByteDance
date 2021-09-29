namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/waybillCancel 接口的响应。</para>
    /// </summary>
    public class IOPWaybillCancelResponse : TikTokShopResponse<IOPWaybillCancelResponse.Types.Data>
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
            }
        }
    }
}
