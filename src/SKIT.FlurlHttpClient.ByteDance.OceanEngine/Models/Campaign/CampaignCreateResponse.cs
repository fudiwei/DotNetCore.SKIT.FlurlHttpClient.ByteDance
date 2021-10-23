namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/campaign/create 接口的响应。</para>
    /// </summary>
    public class CampaignCreateResponse : OceanEngineResponse<CampaignCreateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置广告组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("campaign_id")]
                [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
                public long CampaignId { get; set; }
            }
        }
    }
}
