namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/business_platform/partner_organization/list 接口的响应。</para>
    /// </summary>
    public class BusinessPlatformPartnerOrganizationListResponse : OceanEngineResponse<BusinessPlatformPartnerOrganizationListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class PartnerOrganization
                    {
                        /// <summary>
                        /// 获取或设置组织 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("partner_organization_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("partner_organization_id")]
                        public long PartnerOrganizationId { get; set; }

                        /// <summary>
                        /// 获取或设置合作状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remark")]
                        [System.Text.Json.Serialization.JsonPropertyName("remark")]
                        public string? Remark { get; set; }
                    }

                    public class Pagination : AgentAdvertiserSelectResponse.Types.Data.Types.Pagination
                    {
                    }
                }

                /// <summary>
                /// 获取或设置合作组织列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.PartnerOrganization[] PartnerOrganizationList { get; set; } = default!;

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
