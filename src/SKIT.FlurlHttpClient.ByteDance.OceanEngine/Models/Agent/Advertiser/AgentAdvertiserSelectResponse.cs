namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/agent/advertiser/select 接口的响应。</para>
    /// </summary>
    public class AgentAdvertiserSelectResponse : OceanEngineResponse<AgentAdvertiserSelectResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Pagination
                    {
                        /// <summary>
                        /// 获取或设置分页页码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page")]
                        [System.Text.Json.Serialization.JsonPropertyName("page")]
                        public int PageNumber { get; set; }

                        /// <summary>
                        /// 获取或设置分页每页数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page_size")]
                        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
                        public int PageSize { get; set; }

                        /// <summary>
                        /// 获取或设置总数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_number")]
                        public int TotalCount { get; set; }

                        /// <summary>
                        /// 获取或设置总页数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_page")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_page")]
                        public int TotalPage { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置广告主 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public long[] AdvertiserIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置账号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_source")]
                [System.Text.Json.Serialization.JsonPropertyName("account_source")]
                public string? AccountSource { get; set; }

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public Types.Pagination Pagination { get; set; } = default!;
            }
        }
    }
}
