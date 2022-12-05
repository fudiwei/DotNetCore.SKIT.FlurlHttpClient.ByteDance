using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop
{
    /// <summary>
    /// 抖店开放平台 API 响应的基类。
    /// </summary>
    public abstract class DouyinShopResponse : ICommonResponse
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
        /// 获取抖店开放平台 API 返回的请求标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log_id")]
        [System.Text.Json.Serialization.JsonPropertyName("log_id")]
        public virtual string LogId { get; set; } = default!;

        /// <summary>
        /// 获取抖店开放平台 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public virtual int ErrorNumber { get; set; }

        /// <summary>
        /// 获取抖店开放平台 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取抖店开放平台 API 返回的主返回码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public virtual string? ReturnCode { get; set; }

        /// <summary>
        /// 获取抖店开放平台 API 返回的主返回码描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public virtual string? ReturnMessage { get; set; }

        /// <summary>
        /// 获取抖店开放平台 API 返回的子返回码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_code")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_code")]
        public virtual string? SubReturnCode { get; set; }

        /// <summary>
        /// 获取抖店开放平台 API 返回的子返回码描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_msg")]
        public virtual string? SubReturnMessage { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用抖店开放平台 API 是否成功（即 HTTP 状态码为 200、且 `err_no` 值为 0）。
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccessful()
        {
            return RawStatus == 200 && ErrorNumber == 0;
        }
    }

    /// <summary>
    /// 抖店开放平台 API 响应的泛型基类。
    /// </summary>
    public abstract class DouyinShopResponse<TData> : DouyinShopResponse
    {
        /// <summary>
        /// 获取或设置接口返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public TData Data { get; set; } = default!;
    }
}
