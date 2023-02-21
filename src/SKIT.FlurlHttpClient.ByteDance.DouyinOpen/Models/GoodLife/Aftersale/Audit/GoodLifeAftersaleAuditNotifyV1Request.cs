using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/after_sale/audit/notify 接口的请求。</para>
    /// </summary>
    public class GoodLifeAftersaleAuditNotifyV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class RejectReason
            {
                /// <summary>
                /// 获取或设置拒绝错误码列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason_code")]
                [System.Text.Json.Serialization.JsonPropertyName("reason_code")]
                public IList<int> ReasonCodeList { get; set; } = new List<int>();

                /// <summary>
                /// 获取或设置拒绝描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string? Description { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置外部售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_after_sale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_after_sale_id")]
        public string OutAftersaleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_id")]
        public string AftersaleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否审核通过。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_approved")]
        [System.Text.Json.Serialization.JsonPropertyName("is_approved")]
        public bool IsApproved { get; set; }

        /// <summary>
        /// 获取或设置拒绝原因信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public Types.RejectReason? RejectReason { get; set; }
    }
}
