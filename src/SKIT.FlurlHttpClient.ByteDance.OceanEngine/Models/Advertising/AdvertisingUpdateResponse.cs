namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/ad/update 接口的响应。</para>
    /// </summary>
    public class AdvertisingUpdateResponse : OceanEngineResponse<AdvertisingUpdateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置广告计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
                public long AdvertisingId { get; set; }

                /// <summary>
                /// 获取或设置此次修改是否需要审核。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_audit")]
                [System.Text.Json.Serialization.JsonPropertyName("need_audit")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool RequireAudit { get; set; }
            }
        }
    }
}
