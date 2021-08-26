using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    /// <summary>
    /// 字节小程序 API 响应的基类。
    /// </summary>
    public abstract class ByteDanceMicroAppResponse : IByteDanceResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int RawStatus { get; internal set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IDictionary<string, string> RawHeaders { get; internal set; } = default!;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] RawBytes { get; internal set; } = default!;

        /// <summary>
        /// 获取字节小程序 API 返回的错误号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error")]
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public virtual int Error { get; set; } = default!;

        /// <summary>
        /// 获取字节小程序 API 返回的错误号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public virtual int ErrorNumber { get; set; }

        /// <summary>
        /// 获取字节小程序 API 返回的详细错误号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errcode")]
        [System.Text.Json.Serialization.JsonPropertyName("errcode")]
        public virtual long ErrorCode { get; set; }

        /// <summary>
        /// 获取字节小程序 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取字节小程序 API 返回的错误提示。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_tips")]
        [System.Text.Json.Serialization.JsonPropertyName("err_tips")]
        public virtual string? ErrorTips { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用字节小程序 API 是否成功（即 HTTP 状态码为 200、且 errcode 值为 0）。
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccessful()
        {
            return RawStatus == 200 && Error == 0 && ErrorNumber == 0 && ErrorCode == 0;
        }
    }
}
