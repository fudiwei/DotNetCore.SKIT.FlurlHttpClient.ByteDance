namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v3/fund/bills/ 接口的响应。</para>
    /// </summary>
    public class AppsFundBillsV3Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置账单下载链接列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fund_bill_list")]
                [System.Text.Json.Serialization.JsonPropertyName("fund_bill_list")]
                public string[] DownloadUrlList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
