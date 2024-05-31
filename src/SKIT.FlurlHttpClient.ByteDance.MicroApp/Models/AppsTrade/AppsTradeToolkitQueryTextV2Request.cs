namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/toolkit/query_text 接口的请求。</para>
    /// </summary>
    public class AppsTradeToolkitQueryTextV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置文案类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text_type")]
        [System.Text.Json.Serialization.JsonPropertyName("text_type")]
        public int? TextType { get; set; }
    }
}
