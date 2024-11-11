namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /customer_service/{version}/performance 接口的请求。</para>
    /// </summary>
    public class CustomerServiceGetPerformanceRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置 API 版本号。
        /// <para>默认值：202407</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int ApiVersion { get; set; } = 202407;

        /// <summary>
        /// 获取或设置日期范围起始时间字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SupportDateStringGreaterThan { get; set; }

        /// <summary>
        /// 获取或设置日期范围截止时间字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SupportDateStringLessThan { get; set; }
    }
}
