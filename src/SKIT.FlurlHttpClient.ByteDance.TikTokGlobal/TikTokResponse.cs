namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    /// <summary>
    /// TikTok API 响应的基类。
    /// </summary>
    public abstract class TikTokResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取 TikTok API 返回的扩展信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra")]
        [System.Text.Json.Serialization.JsonPropertyName("extra")]
        public virtual TikTokResponseExtra Extra { get; set; } = default!;

        /// <summary>
        /// 获取 TikTok API 返回的错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error")]
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public virtual TikTokResponseError Error { get; set; } = default!;

        /// <summary>
        /// 获取一个值，该值指示调用 TikTok API 是否成功。
        /// <para>
        ///（即 HTTP 状态码为 200，且 <see cref="Error.Code"/> 值为 0）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && (Error?.Code).GetValueOrDefault() == 0;
        }
    }

    /// <summary>
    /// TikTok API 响应的返回数据字段。
    /// </summary>
    public abstract class TikTokResponseData
    {
        /// <summary>
        /// 获取或设置错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code")]
        [System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long ErrorCode { get; set; }

        /// <summary>
        /// 获取或设置错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("error_msg")]
        public string? ErrorMessage { get; set; }
    }

    /// <summary>
    /// TikTok API 响应的扩展信息字段。
    /// </summary>
    public sealed class TikTokResponseExtra
    {
        /// <summary>
        /// 获取请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logid")]
        [System.Text.Json.Serialization.JsonPropertyName("logid")]
        public string LogId { get; set; } = default!;

        /// <summary>
        /// 获取错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("error_detail")]
        public string? ErrorDetail { get; set; }
    }

    /// <summary>
    /// TikTok API 响应的错误信息字段。
    /// </summary>
    public sealed class TikTokResponseError
    {
        /// <summary>
        /// 获取错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int Code { get; set; }

        /// <summary>
        /// 获取错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }
    }

    /// <summary>
    /// TikTok API 响应的泛型基类。
    /// </summary>
    public abstract class TikTokResponse<TData> : TikTokResponse
        where TData : TikTokResponseData
    {
        /// <summary>
        /// 获取或设置接口返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public TData Data { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.ErrorCode == 0;
        }
    }
}
