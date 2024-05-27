using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v2/activity/add_self_test_accounts/ 接口的请求。</para>
    /// </summary>
    public class PromotionActivityAddSelfTestAccountsV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string ActivityId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置测试账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("test_accounts")]
        [System.Text.Json.Serialization.JsonPropertyName("test_accounts")]
        public IList<string> TestAccountList { get; set; } = new List<string>();
    }
}
