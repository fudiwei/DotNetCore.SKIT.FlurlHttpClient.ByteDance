namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /namek/fulfilment/prepare 接口的请求。</para>
    /// </summary>
    public class NamekFulfilmentPrepareRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置二维码解析数据。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? EncryptedData { get; set; }

        /// <summary>
        /// 获取或设置团购券码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Code { get; set; }
    }
}
