namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/ad/update/status 接口的响应。</para>
    /// </summary>
    public class AdvertisingUpdateStatusResponse : OceanEngineResponse<AdvertisingUpdateStatusResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Failure
                    {
                        /// <summary>
                        /// 获取或设置广告计划 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
                        public long AdvertisingId { get; set; }

                        /// <summary>
                        /// 获取或设置错误信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("error_message")]
                        [System.Text.Json.Serialization.JsonPropertyName("error_message")]
                        public string ErrorMessage { get; set; } = default!;
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
