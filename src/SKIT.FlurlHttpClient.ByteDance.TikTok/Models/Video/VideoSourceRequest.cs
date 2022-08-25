using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/source 接口的请求。</para>
    /// </summary>
    public class VideoSourceRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置视频 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("item_ids")]
        public IList<string> ItemIdList { get; set; } = new List<string>();
    }
}
