using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/adlib/ad/detail/ 接口的请求。</para>
    /// </summary>
    public class ResearchAdlibAdDetailRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置要读取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> FieldList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置广告 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
        public long AdId { get; set; }

        public ResearchAdlibAdDetailRequest SetCompleteFields()
        {
            FieldList ??= new List<string>();
            FieldList.Clear();
            FieldList.Add("ad.id");
            FieldList.Add("ad.first_shown_date");
            FieldList.Add("ad.last_shown_date");
            FieldList.Add("ad.status");
            FieldList.Add("ad.status_statement");
            FieldList.Add("ad.videos");
            FieldList.Add("ad.image_urls");
            FieldList.Add("ad.reach");
            FieldList.Add("advertiser.business_id");
            FieldList.Add("advertiser.business_name");
            FieldList.Add("advertiser.paid_for_by");
            FieldList.Add("advertiser.follower_count");
            FieldList.Add("advertiser.avatar_url");
            FieldList.Add("advertiser.profile_url");
            FieldList.Add("advertiser.targeting_info");
            return this;
        }
    }
}
