namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/operation/live_application 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppOperationLiveApplicationV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置申请原因以及挂载内容介绍。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intro")]
        [System.Text.Json.Serialization.JsonPropertyName("intro")]
        public string Introduction { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置预计首次开播时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("firstLiveTime")]
        [System.Text.Json.Serialization.JsonPropertyName("firstLiveTime")]
        public long FirstLiveTimestamp { get; set; }

        /// <summary>
        /// 获取或设置预估每周开播频率。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("liveFrequency")]
        [System.Text.Json.Serialization.JsonPropertyName("liveFrequency")]
        public int LiveFrequency { get; set; }

        /// <summary>
        /// 获取或设置是否有广告预算。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hasAdBudget")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("hasAdBudget")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool HasAdBudget { get; set; }

        /// <summary>
        /// 获取或设置投放预算（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adBudgetAmount")]
        [System.Text.Json.Serialization.JsonPropertyName("adBudgetAmount")]
        public int? AdBudgetAmount { get; set; }

        /// <summary>
        /// 获取或设置销售对接人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adPersonName")]
        [System.Text.Json.Serialization.JsonPropertyName("adPersonName")]
        public string? AdPersonName { get; set; }
    }
}
