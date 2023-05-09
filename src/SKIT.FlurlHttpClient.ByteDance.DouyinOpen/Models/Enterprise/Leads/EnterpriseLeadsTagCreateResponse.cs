using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/leads/tag/create 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-05-31 下线。")]
    public class EnterpriseLeadsTagCreateResponse : DouyinOpenResponse<EnterpriseLeadsTagCreateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置标签 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag_id")]
                [System.Text.Json.Serialization.JsonPropertyName("tag_id")]
                public long TagId { get; set; }
            }
        }
    }
}
