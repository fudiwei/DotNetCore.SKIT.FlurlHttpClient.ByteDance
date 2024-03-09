namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /match/v2/taskbox/query_bill_link/ 接口的响应。</para>
    /// </summary>
    public class MatchTaskBoxQueryBillLinkV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置账单文件下载链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bill_link")]
                [System.Text.Json.Serialization.JsonPropertyName("bill_link")]
                public string BillLink { get; set; } = default!;
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
