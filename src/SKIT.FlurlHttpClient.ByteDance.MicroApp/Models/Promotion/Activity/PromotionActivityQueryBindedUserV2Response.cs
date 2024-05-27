namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v2/activity/query_binded_user/ 接口的响应。</para>
    /// </summary>
    public class PromotionActivityQueryBindedUserV2Response : DouyinMicroAppResponse
    {
        /// <summary>
        /// 获取或设置是否已圈选。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_binded")]
        [System.Text.Json.Serialization.JsonPropertyName("is_binded")]
        public bool IsBinded { get; set; }
    }
}
