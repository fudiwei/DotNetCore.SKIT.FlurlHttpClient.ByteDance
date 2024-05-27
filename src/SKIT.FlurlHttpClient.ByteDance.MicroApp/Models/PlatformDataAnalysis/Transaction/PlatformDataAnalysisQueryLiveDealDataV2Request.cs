namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/platform/v2/data_analysis/query_live_deal_data/ 接口的请求。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryLiveDealDataV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long LiveRoomId { get; set; }
    }
}
