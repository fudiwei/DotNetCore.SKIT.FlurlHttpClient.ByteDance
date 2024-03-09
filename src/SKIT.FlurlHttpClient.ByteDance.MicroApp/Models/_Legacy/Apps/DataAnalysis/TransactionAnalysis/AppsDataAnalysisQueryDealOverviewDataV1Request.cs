using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/data_analysis/query_deal_overview_data 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-02-02 下线。")]
    public class AppsDataAnalysisQueryDealOverviewDataV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long EndTimestamp { get; set; }

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
