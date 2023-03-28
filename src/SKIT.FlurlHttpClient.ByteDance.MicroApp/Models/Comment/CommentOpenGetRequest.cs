namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /comment/open/get 接口的请求。</para>
    /// </summary>
    public class CommentOpenGetRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// <inheritdoc />
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置小程序的 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商品或课程 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("origin_id")]
        [System.Text.Json.Serialization.JsonPropertyName("origin_id")]
        public string OriginId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置业务线类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_line")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_line")]
        public int BusinessLineType { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：20</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Limit { get; set; } = 20;
    }
}
