namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/order/bill/token 接口的响应。</para>
    /// </summary>
    public class POIOrderBillTokenResponse : TikTokResponse<POIOrderBillTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置账单下载凭证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bill_token")]
                [System.Text.Json.Serialization.JsonPropertyName("bill_token")]
                public string DownloadToken { get; set; } = default!;
            }
        }
    }
}
