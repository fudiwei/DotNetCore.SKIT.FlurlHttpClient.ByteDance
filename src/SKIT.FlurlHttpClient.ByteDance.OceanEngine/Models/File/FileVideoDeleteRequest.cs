using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/file/video/delete 接口的请求。</para>
    /// </summary>
    public class FileVideoDeleteRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置视频 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("video_ids")]
        public IList<string> VideoIdList { get; set; } = new List<string>();
    }
}
