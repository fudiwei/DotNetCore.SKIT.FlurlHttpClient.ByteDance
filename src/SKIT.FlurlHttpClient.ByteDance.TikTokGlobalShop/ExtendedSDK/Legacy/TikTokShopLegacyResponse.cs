using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy
{
    /// <summary>
    /// TikTok Shop API 响应的基类。
    /// </summary>
    [Obsolete("此类型专为旧版 API 设计，将于 2024-12-31 下线。")]
    public abstract class TikTokShopLegacyResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取 TikTok Shop API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public virtual int ErrorCode { get; set; }

        /// <summary>
        /// 获取 TikTok Shop API 返回的错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取 TikTok Shop API 返回的请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        [System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public virtual string? RequestId { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用 TikTok API 是否成功。
        /// <para>
        /// （即 HTTP 状态码为 200，且 <see cref="ErrorCode"/> 值为 0）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorCode == 0;
        }
    }

    /// <summary>
    /// TikTok Shop API 响应的泛型基类。
    /// </summary>
    [Obsolete("此类型专为旧版 API 设计，将于 2024-12-31 下线。")]
    public abstract class TikTokShopLegacyResponse<TData> : TikTokShopLegacyResponse
    {
        /// <summary>
        /// 获取或设置接口返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public TData Data { get; set; } = default!;
    }
}
