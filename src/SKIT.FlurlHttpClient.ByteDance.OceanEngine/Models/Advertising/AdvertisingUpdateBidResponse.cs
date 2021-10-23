namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/ad/update/bid 接口的响应。</para>
    /// </summary>
    public class AdvertisingUpdateBidResponse : OceanEngineResponse<AdvertisingUpdateBidResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Failure : AdvertisingUpdateStatusResponse.Types.Data.Types.Failure
                    {
                    }
                }

                /// <summary>
                /// 获取或设置成功的广告计划 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_ids")]
                public long[] SuccessAdvertisingId { get; set; } = default!;

                /// <summary>
                /// 获取或设置失败列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errors")]
                [System.Text.Json.Serialization.JsonPropertyName("errors")]
                public Types.Failure[] FailureList { get; set; } = default!;
            }
        }
    }
}
