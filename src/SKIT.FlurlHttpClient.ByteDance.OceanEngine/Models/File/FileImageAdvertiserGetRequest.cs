using System.Collections.Generic;

/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/file/image/ad/get 接口的请求。</para>
    /// </summary>
    public class FileImageAdvertiserGetRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置图片 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("image_ids")]
        public IList<string> ImageIdList { get; set; } = new List<string>();
    }
}
