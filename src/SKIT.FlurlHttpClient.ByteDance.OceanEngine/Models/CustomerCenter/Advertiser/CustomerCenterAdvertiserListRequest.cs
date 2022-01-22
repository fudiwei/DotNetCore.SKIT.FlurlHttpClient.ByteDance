/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/customer_center/advertiser/list 接口的请求。</para>
    /// </summary>
    public class CustomerCenterAdvertiserListRequest : OceanEngineRequest
    {
        public static class Types
        {
            public class Filter
            {
                /// <summary>
                /// 获取或设置账户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                public string? AccountName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置纵横组织 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cc_account_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cc_account_id")]
        public long CCAccountId { get; set; }

        /// <summary>
        /// 获取或设置账户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_source")]
        [System.Text.Json.Serialization.JsonPropertyName("account_source")]
        public string? AccountSource { get; set; }

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
