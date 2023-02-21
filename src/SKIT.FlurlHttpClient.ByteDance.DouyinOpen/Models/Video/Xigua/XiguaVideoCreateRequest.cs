namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /xigua/video/create 接口的请求。</para>
    /// </summary>
    public class XiguaVideoCreateRequest : ToutiaoVideoCreateRequest
    {
        /// <summary>
        /// 获取或设置视频摘要。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("abstract")]
        [System.Text.Json.Serialization.JsonPropertyName("abstract")]
        public string Abstract { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置将传入的指定时间点对应帧设置为视频封面（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_tsp")]
        [System.Text.Json.Serialization.JsonPropertyName("cover_tsp")]
        public double? CoverTSP { get; set; }

        /// <summary>
        /// 获取或设置是否声明原创。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("claim_origin")]
        [System.Text.Json.Serialization.JsonPropertyName("claim_origin")]
        public bool IsClaimOrigin { get; set; }

        /// <summary>
        /// 获取或设置是否给视频开通可以赞赏的入口。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("praise")]
        [System.Text.Json.Serialization.JsonPropertyName("praise")]
        public bool AllowPraise { get; set; }
    }
}
