using System.Collections.Generic;

/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/business_platform/partner_organization/list 接口的请求。</para>
    /// </summary>
    public class BusinessPlatformPartnerOrganizationListRequest : OceanEngineRequest
    {
        public static class Types
        {
            public class Filter
            {
                /// <summary>
                /// 获取或设置纵横组织 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("partner_organization_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("partner_organization_ids")]
                public IList<long>? PartnerOrganizationList { get; set; }

                /// <summary>
                /// 获取或设置合作状态列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public IList<string>? StatusList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置账户管家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organization_id")]
        [System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public long OrganizationId { get; set; }

        /// <summary>
        /// 获取或设置过滤条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filtering")]
        [System.Text.Json.Serialization.JsonPropertyName("filtering")]
        public Types.Filter? Filter { get; set; }

        /// <summary>
        /// 获取或设置分页页码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }
    }
}
