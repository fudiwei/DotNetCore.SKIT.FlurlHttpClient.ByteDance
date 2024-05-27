namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/platform/v2/data_analysis/query_live_room/ 接口的请求。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryLiveRoomV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置主播昵称。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? AnchorName { get; set; }
    }
}
