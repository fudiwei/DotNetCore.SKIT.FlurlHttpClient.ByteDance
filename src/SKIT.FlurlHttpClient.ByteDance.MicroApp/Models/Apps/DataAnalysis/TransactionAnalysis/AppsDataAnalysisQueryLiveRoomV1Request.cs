namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/data_analysis/query_live_room 接口的请求。</para>
    /// </summary>
    public class AppsDataAnalysisQueryLiveRoomV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置主播昵称。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? AnchorName { get; set; }
    }
}
