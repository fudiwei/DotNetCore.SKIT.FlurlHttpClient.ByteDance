using System;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/agent/info 接口的响应。</para>
    /// </summary>
    public class AgentInfoResponse : OceanEngineResponse<AgentInfoResponse.Types.Agent[]>
    {
        public static class Types
        {
            public class Agent
            {
                /// <summary>
                /// 获取或设置代理商 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agent_id")]
                [System.Text.Json.Serialization.JsonPropertyName("agent_id")]
                public long? AgentId { get; set; }

                /// <summary>
                /// 获取或设置代理商名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agent_name")]
                [System.Text.Json.Serialization.JsonPropertyName("agent_name")]
                public string? AgentName { get; set; }

                /// <summary>
                /// 获取或设置客户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customer_id")]
                [System.Text.Json.Serialization.JsonPropertyName("customer_id")]
                public long? CustomerId { get; set; }

                /// <summary>
                /// 获取或设置客户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customer_name")]
                [System.Text.Json.Serialization.JsonPropertyName("customer_name")]
                public string? CustomerName { get; set; }

                /// <summary>
                /// 获取或设置公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_id")]
                [System.Text.Json.Serialization.JsonPropertyName("company_id")]
                public long? CompanyId { get; set; }

                /// <summary>
                /// 获取或设置公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_name")]
                [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                public string? CompanyName { get; set; }

                /// <summary>
                /// 获取或设置用户状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_status")]
                [System.Text.Json.Serialization.JsonPropertyName("account_status")]
                public string? AccountStatus { get; set; }

                /// <summary>
                /// 获取或设置角色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("role")]
                [System.Text.Json.Serialization.JsonPropertyName("role")]
                public string? Role { get; set; }

                /// <summary>
                /// 获取或设置注册时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                public DateTimeOffset? CreateTime { get; set; }
            }
        }
    }
}
