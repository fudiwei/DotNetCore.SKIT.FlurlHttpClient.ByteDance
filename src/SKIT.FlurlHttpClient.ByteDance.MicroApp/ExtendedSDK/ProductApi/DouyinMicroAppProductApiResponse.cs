namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi
{
    /// <summary>
    /// 抖音小程序泛知识课程库 API 响应的基类。
    /// </summary>
    public abstract class DouyinMicroAppProductApiResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取抖音小程序 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public virtual int ErrorNumber { get; set; }

        /// <summary>
        /// 获取抖音小程序 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取抖音小程序 API 返回的日志 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log_id")]
        [System.Text.Json.Serialization.JsonPropertyName("log_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
        public virtual string? LogId { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用抖音小程序 API 是否成功。
        /// <para>
        /// （即 HTTP 状态码为 200，且 <see cref="ErrorNumber"/> 值为 0）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorNumber == 0;
        }
    }
}
