using System.Collections.Generic;

/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1.0/enterprise/info 接口的请求。</para>
    /// </summary>
    public class EnterpriseInfoRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置企业号 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("e_douyin_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("e_douyin_ids")]
        public IList<string> EDouyinIdList { get; set; } = new List<string>();
    }
}
