namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1.0/enterprise/info 接口的响应。</para>
    /// </summary>
    public class EnterpriseInfoResponse : OceanEngineResponse<EnterpriseInfoResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Enterprise
                    {
                        /// <summary>
                        /// 获取或设置企业号 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("e_douyin_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("e_douyin_id")]
                        public string EDouyinId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置企业号名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("e_douyin_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("e_douyin_name")]
                        public string Name { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置企业号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Enterprise[] EnterpriseList { get; set; } = default!;
            }
        }
    }
}
