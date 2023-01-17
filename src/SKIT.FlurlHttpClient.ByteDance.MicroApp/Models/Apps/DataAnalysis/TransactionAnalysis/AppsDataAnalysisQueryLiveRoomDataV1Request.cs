namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/data_analysis/query_live_room_data 接口的请求。</para>
    /// </summary>
    public class AppsDataAnalysisQueryLiveRoomDataV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long LiveRoomId { get; set; }
    }
}
