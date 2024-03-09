namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_ad_income 接口的请求。</para>
    /// </summary>
    public class AppsCapacityQueryAdIncomeV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置开始日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StartDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结束日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string EndDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置宿主名称。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? HostName { get; set; }
    }
}
