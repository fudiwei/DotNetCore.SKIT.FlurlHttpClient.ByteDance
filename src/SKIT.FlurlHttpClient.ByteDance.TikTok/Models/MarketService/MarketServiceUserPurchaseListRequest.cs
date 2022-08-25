namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /market/service/user/purchase/list 接口的请求。</para>
    /// </summary>
    public class MarketServiceUserPurchaseListRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ServiceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否为测试环境。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool IsTestEnvironment { get; set; }
    }
}
