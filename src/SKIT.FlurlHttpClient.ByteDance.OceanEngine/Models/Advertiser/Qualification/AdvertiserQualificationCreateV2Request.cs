using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/advertiser/qualification/create_v2 接口的请求。</para>
    /// </summary>
    public class AdvertiserQualificationCreateV2Request : OceanEngineRequest
    {
        public static class Types
        {
            public class Qualification
            {
                /// <summary>
                /// 获取或设置资质图片类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_qualification_type")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_qualification_type")]
                public string ImageType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置资质图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification_img_id")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification_img_id")]
                public string ImageId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置资质类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification_type")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification_type")]
        public string QualificationType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置资质列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualifications")]
        [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
        public IList<Types.Qualification> QualificationList { get; set; } = new List<Types.Qualification>();
    }
}
