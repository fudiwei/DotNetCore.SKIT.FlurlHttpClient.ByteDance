namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/v1/microapp/operation/live_application 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppOperationLiveApplicationV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置第三方应用 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAppId { get; set; }

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("hasAdBudget")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
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
