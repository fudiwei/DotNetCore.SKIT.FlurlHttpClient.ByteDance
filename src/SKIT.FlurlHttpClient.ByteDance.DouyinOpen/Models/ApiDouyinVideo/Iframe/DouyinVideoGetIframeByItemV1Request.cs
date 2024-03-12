namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/douyin/v1/video/get_iframe_by_item 接口的请求。</para>
    /// </summary>
    public class DouyinVideoGetIframeByItemV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置抖音开放平台 ClientKey。如果不指定将使用构造 <see cref="DouyinOpenClient"/> 时的 <see cref="DouyinOpenClientOptions.ClientKey"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_key")]
        [System.Text.Json.Serialization.JsonPropertyName("client_key")]
        public string? ClientKey { get; set; }

        /// <summary>
        /// 获取或设置视频 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ItemId { get; set; } = string.Empty;
    }
}
