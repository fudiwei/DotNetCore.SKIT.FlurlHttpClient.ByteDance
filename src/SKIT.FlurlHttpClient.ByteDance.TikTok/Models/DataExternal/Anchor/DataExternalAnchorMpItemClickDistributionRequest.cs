namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/anchor/mp_item_click_distribution 接口的请求。</para>
    /// </summary>
    public class DataExternalAnchorMpItemClickDistributionRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置小程序 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string MiniAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置日期类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int DateType { get; set; }
    }
}
