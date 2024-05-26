namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/ecom/v1/config/limit_op_point/ 接口的请求。</para>
    /// </summary>
    public class ECommerceConfigLimitOperatePointV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("op_type")]
        [System.Text.Json.Serialization.JsonPropertyName("op_type")]
        public int OperateType { get; set; }

        /// <summary>
        /// 获取或设置单日单用户增加积分次数上限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("daily_add_count")]
        [System.Text.Json.Serialization.JsonPropertyName("daily_add_count")]
        public long? DailyAddCount { get; set; }

        /// <summary>
        /// 获取或设置单日单用户减少积分次数上限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("daily_deduct_count")]
        [System.Text.Json.Serialization.JsonPropertyName("daily_deduct_count")]
        public long? DailyDeductCount { get; set; }

        /// <summary>
        /// 获取或设置单次增加积分上限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("single_add_limit")]
        [System.Text.Json.Serialization.JsonPropertyName("single_add_limit")]
        public long? SingleAddLimit { get; set; }

        /// <summary>
        /// 获取或设置单次减少积分上限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("single_deduct_limit")]
        [System.Text.Json.Serialization.JsonPropertyName("single_deduct_limit")]
        public long? SingleDeductLimit { get; set; }
    }
}
