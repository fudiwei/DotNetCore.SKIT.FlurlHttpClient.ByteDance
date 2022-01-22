namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/advertiser/avatar/submit 接口的请求。</para>
    /// </summary>
    public class AdvertiserAvatarSubmitRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置头像 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_id")]
        [System.Text.Json.Serialization.JsonPropertyName("image_id")]
        public string ImageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置品牌名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_info")]
        [System.Text.Json.Serialization.JsonPropertyName("source_info")]
        public string? SourceInfo { get; set; }
    }
}
