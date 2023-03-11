using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    /// <summary>
    /// 抖音开放平台 API 响应的基类。
    /// </summary>
    public abstract class DouyinOpenResponse : ICommonResponse
    {
        /// <summary>
        ///
        /// </summary>
        int ICommonResponse.RawStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        IDictionary<string, string> ICommonResponse.RawHeaders { get; set; } = default!;

        /// <summary>
        ///
        /// </summary>
        byte[] ICommonResponse.RawBytes { get; set; } = default!;

        /// <summary>
        /// 获取原始的 HTTP 响应状态码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int RawStatus
        {
            get { return ((ICommonResponse)this).RawStatus; }
            internal set { ((ICommonResponse)this).RawStatus = value; }
        }

        /// <summary>
        /// 获取原始的 HTTP 响应表头集合。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IDictionary<string, string> RawHeaders
        {
            get { return ((ICommonResponse)this).RawHeaders; }
            internal set { ((ICommonResponse)this).RawHeaders = value; }
        }

        /// <summary>
        /// 获取原始的 HTTP 响应正文。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] RawBytes
        {
            get { return ((ICommonResponse)this).RawBytes; }
            internal set { ((ICommonResponse)this).RawBytes = value; }
        }

        /// <summary>
        /// 获取抖音开放平台 API 返回的扩展信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra")]
        [System.Text.Json.Serialization.JsonPropertyName("extra")]
        public virtual DouyinOpenResponseExtra Extra { get; set; } = default!;

        /// <summary>
        /// 获取抖音开放平台 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code")]
        [System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public virtual int ErrorCode { get; set; }

        /// <summary>
        /// 获取抖音开放平台 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public virtual string? ErrorDescription { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用抖音开放平台 API 是否成功（即 HTTP 状态码为 200、且 "error_code" 值为 0）。
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccessful()
        {
            return RawStatus == 200 && ErrorCode == 0 &&
                (Extra?.ErrorCode).GetValueOrDefault() == 0 &&
                (Extra?.SubErrorCode).GetValueOrDefault() == 0;
        }
    }

    /// <summary>
    /// 抖音开放平台 API 响应的返回数据字段。
    /// </summary>
    public abstract class DouyinOpenResponseData
    {
        /// <summary>
        /// 获取或设置错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code")]
        [System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int ErrorCode { get; set; }

        /// <summary>
        /// 获取或设置错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? ErrorDescription { get; set; }
    }

    /// <summary>
    /// 抖音开放平台 API 响应的扩展信息字段。
    /// </summary>
    public sealed class DouyinOpenResponseExtra
    {
        /// <summary>
        /// 获取请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logid")]
        [System.Text.Json.Serialization.JsonPropertyName("logid")]
        public string LogId { get; set; } = default!;

        /// <summary>
        /// 获取毫秒级时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("now")]
        [System.Text.Json.Serialization.JsonPropertyName("now")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long Now { get; set; }

        /// <summary>
        /// 获取错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_code")]
        [System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 获取错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? ErrorDescription { get; set; }

        /// <summary>
        /// 获取子错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_error_code")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_error_code")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? SubErrorCode { get; set; }

        /// <summary>
        /// 获取子错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_description")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_description")]
        public string? SubErrorDescription { get; set; }
    }

    /// <summary>
    /// 抖音开放平台 API 响应的泛型基类。
    /// </summary>
    public abstract class DouyinOpenResponse<TData> : DouyinOpenResponse
        where TData : DouyinOpenResponseData
    {
        /// <summary>
        /// 获取或设置接口返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public TData Data { get; set; } = default!;

        /// <summary>
        /// 获取或设置接口返回消息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.ErrorCode == 0;
        }
    }
}
