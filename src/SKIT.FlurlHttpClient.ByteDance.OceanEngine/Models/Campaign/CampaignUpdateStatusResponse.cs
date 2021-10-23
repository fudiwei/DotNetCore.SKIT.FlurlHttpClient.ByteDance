namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/campaign/update/status 接口的响应。</para>
    /// </summary>
    public class CampaignUpdateStatusResponse : OceanEngineResponse<CampaignUpdateStatusResponse.Types.Data>
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
                        /// 获取或设置广告组 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("campaign_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
                        public long CampaignId { get; set; }

                        /// <summary>
                        /// 获取或设置错误信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("error_message")]
                        [System.Text.Json.Serialization.JsonPropertyName("error_message")]
                        public string ErrorMessage { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置成功的广告组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("campaign_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("campaign_ids")]
                public long[] SuccessCampaignId { get; set; } = default!;

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
