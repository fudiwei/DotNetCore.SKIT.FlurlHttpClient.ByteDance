using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi
{
    /// <summary>
    /// 字节小程序泛知识角色系统 API 响应的基类。
    /// </summary>
    public abstract class ByteDanceMicroAppRoleApiResponse: ICommonResponse
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
        /// 获取字节小程序 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public virtual int ErrorNumber { get; set; }

        /// <summary>
        /// 获取字节小程序 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_tips")]
        [System.Text.Json.Serialization.JsonPropertyName("err_tips")]
        public virtual string? ErrorTips { get; set; }

        /// <summary>
        /// 获取字节小程序 API 返回的错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err")]
        [System.Text.Json.Serialization.JsonPropertyName("err")]
        public virtual ByteDanceMicroAppRoleApiResponseError? Error { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用字节小程序 API 是否成功（即 HTTP 状态码为 200、且 `err_no` 值为 0）。
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccessful()
        {
            return RawStatus == 200 && ErrorNumber == 0 && (Error == null || Error.ErrorCode == 0);
        }
    }

    public class ByteDanceMicroAppRoleApiResponseError
    {
        /// <summary>
        /// 获取字节小程序 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_code")]
        [System.Text.Json.Serialization.JsonPropertyName("err_code")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// 获取字节小程序 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ErrorMessage { get; set; }
    }
}
