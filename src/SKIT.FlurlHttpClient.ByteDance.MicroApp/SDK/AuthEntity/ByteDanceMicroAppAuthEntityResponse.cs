using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity
{
    public class ErrData
    {
        [Newtonsoft.Json.JsonProperty("err_code")]
        [System.Text.Json.Serialization.JsonPropertyName("err_code")]
        public int ErrCode { get; set; }

        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ErrMsg { get; set; }
    }
    public abstract class ByteDanceMicroAppAuthEntityResponse: ICommonResponse
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



        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public int? ErrNo { get; set; }

        [Newtonsoft.Json.JsonProperty("err_tips")]
        [System.Text.Json.Serialization.JsonPropertyName("err_tips")]
        public string? ErrTips { get; set; }

        [Newtonsoft.Json.JsonProperty("err")]
        [System.Text.Json.Serialization.JsonPropertyName("err")]
        public ErrData? Err { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用字节小程序 API 是否成功（即 HTTP 状态码为 200、且 `errcode` 值为 0）。
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccessful()
        {
            return RawStatus == 200 && (Err?.ErrCode == 0 || ErrNo == 0);
        }
    }
}
