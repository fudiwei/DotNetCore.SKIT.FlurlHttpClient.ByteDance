namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    /// <summary>
    /// TikTok API v2 响应的基类。
    /// </summary>
    public abstract class TikTokResponseV2 : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取 TikTok API 返回的错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error")]
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public virtual TikTokResponseV2Error Error { get; set; } = default!;

        /// <summary>
        /// 获取一个值，该值指示调用 TikTok API 是否成功。
        /// <para>
        ///（即 HTTP 状态码为 200，且 <see cref="Error.Code"/> 值为 "ok"）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && (string.IsNullOrEmpty(Error?.Code) || "ok".Equals(Error?.Code));
        }
    }

    /// <summary>
    /// TikTok API v2 响应的错误信息字段。
    /// </summary>
    public sealed class TikTokResponseV2Error
    {
        /// <summary>
        /// 获取或设置错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = default!;

        /// <summary>
        /// 获取或设置错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 获取请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log_id")]
        [System.Text.Json.Serialization.JsonPropertyName("log_id")]
        public string LogId { get; set; } = default!;
    }

    /// <summary>
    /// TikTok API v2 响应的泛型基类。
    /// </summary>
    public abstract class TikTokResponseV2<TData> : TikTokResponseV2
    {
        /// <summary>
        /// 获取或设置接口返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public TData Data { get; set; } = default!;
    }
}
