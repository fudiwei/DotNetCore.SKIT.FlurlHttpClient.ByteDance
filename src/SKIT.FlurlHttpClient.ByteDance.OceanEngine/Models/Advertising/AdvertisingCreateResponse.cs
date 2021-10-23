namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/ad/create 接口的响应。</para>
    /// </summary>
    public class AdvertisingCreateResponse : OceanEngineResponse<AdvertisingCreateResponse.Types.Data>
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
            }
        }
    }
}
