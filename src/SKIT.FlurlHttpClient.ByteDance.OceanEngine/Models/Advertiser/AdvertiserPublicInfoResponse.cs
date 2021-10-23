namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/advertiser/public_info 接口的响应。</para>
    /// </summary>
    public class AdvertiserPublicInfoResponse : OceanEngineResponse<AdvertiserPublicInfoResponse.Types.Advertiser[]>
    {
        public static class Types
        {
            public class Advertiser
            {
                /// <summary>
                /// 获取或设置广告主 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long AdvertiserId { get; set; }

                /// <summary>
                /// 获取或设置账户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置公司名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company")]
                [System.Text.Json.Serialization.JsonPropertyName("company")]
                public string Company { get; set; } = default!;

                /// <summary>
                /// 获取或设置一级行业名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_industry_name")]
                [System.Text.Json.Serialization.JsonPropertyName("first_industry_name")]
                public string FirstIndustryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置二级行业名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_industry_name")]
                [System.Text.Json.Serialization.JsonPropertyName("second_industry_name")]
                public string SecondIndustryName { get; set; } = default!;
            }
        }
    }
}
