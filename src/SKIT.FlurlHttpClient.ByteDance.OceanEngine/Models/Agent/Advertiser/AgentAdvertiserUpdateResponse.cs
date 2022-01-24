namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/agent/advertiser/update 接口的响应。</para>
    /// </summary>
    public class AgentAdvertiserUpdateResponse : OceanEngineResponse<AgentAdvertiserUpdateResponse.Types.Data>
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

                /// <summary>
                /// 获取或设置此次修改是否需要审核。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_audit")]
                [System.Text.Json.Serialization.JsonPropertyName("need_audit")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                public bool RequireAudit { get; set; }
            }
        }
    }
}
