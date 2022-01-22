namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/advertiser/avatar/submit 接口的响应。</para>
    /// </summary>
    public class AdvertiserAvatarSubmitResponse : OceanEngineResponse<AdvertiserAvatarSubmitResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置广告主 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("advertiser_id")]
                [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
                public long AdvertiserId { get; set; }
            }
        }
    }
}
