namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/order/bill/token 接口的响应。</para>
    /// </summary>
    public class POIOrderBillTokenResponse : DouyinOpenResponse<POIOrderBillTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
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
