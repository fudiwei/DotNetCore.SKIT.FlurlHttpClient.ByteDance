namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast
{
    /// <summary>
    /// 抖音小程序直播小玩法 API 响应的基类。
    /// </summary>
    public abstract class DouyinMicroAppWebcastResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取抖音小程序 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errcode")]
        [System.Text.Json.Serialization.JsonPropertyName("errcode")]
        public virtual long ErrorCode { get; set; }

        /// <summary>
        /// 获取抖音小程序 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
        public virtual string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取抖音应答时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ByteTimestamp { get { return GetRawHeaders().GetFirstValueOrEmpty("Byte-Timestamp"); } }

        /// <summary>
        /// 获取抖音应答随机串。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ByteNonce { get { return GetRawHeaders().GetFirstValueOrEmpty("Byte-Nonce-Str"); } }

        /// <summary>
        /// 获取抖音应答签名。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ByteSignature { get { return GetRawHeaders().GetFirstValueOrEmpty("Byte-Signature"); } }

        /// <summary>
        /// 获取一个值，该值指示调用抖音小程序 API 是否成功。
        /// <para>
        ///（即 HTTP 状态码为 200，且 <see cref="ErrorCode"/> 值为 0）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorCode == 0;
        }
    }
}
