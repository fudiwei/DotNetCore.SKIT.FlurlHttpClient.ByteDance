using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/file/material/bind 接口的请求。</para>
    /// </summary>
    public class FileMaterialBindRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置素材归属的广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置待推送的广告主 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target_advertiser_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("target_advertiser_ids")]
        public IList<long> TargetAdvertiserIdList { get; set; } = new List<long>();

        /// <summary>
        /// 获取或设置图片 ID 列表。与字段 <see cref="VideoIdList"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("image_ids")]
        public IList<string>? ImageIdList { get; set; }

        /// <summary>
        /// 获取或设置视频 ID 列表。与字段 <see cref="ImageIdList"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("video_ids")]
        public IList<string>? VideoIdList { get; set; }
    }
}
