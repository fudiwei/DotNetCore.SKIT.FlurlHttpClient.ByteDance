namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/platform/v2/data_analysis/query_real_time_user_data/ 接口的请求。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryRealTimeUserDataV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置宿主名称。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? HostName { get; set; }

        /// <summary>
        /// 获取或设置版本类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? VersionType { get; set; }
    }
}
