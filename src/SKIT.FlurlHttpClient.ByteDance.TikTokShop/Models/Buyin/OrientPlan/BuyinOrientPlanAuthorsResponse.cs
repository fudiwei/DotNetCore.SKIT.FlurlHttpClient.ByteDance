namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/orienPlanAuthors 接口的响应。</para>
    /// </summary>
    public class BuyinOrientPlanAuthorsResponse : TikTokShopResponse<BuyinOrientPlanAuthorsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Author
                    {
                        /// <summary>
                        /// 获取或设置定向计划 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("orien_plan_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("orien_plan_id")]
                        public string OrientPlanId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置达人百应 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyin_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyin_id")]
                        public int BuyinId { get; set; }

                        /// <summary>
                        /// 获取或设置达人昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                        public string AuthorName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置联系方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact_phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact_phone")]
                        public string ContactPhoneNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置申请 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("apply_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
                        public int ApplyId { get; set; }

                        /// <summary>
                        /// 获取或设置申请信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("apply_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("apply_info")]
                        public string ApplyInformation { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                        public int AuditStatus { get; set; }

                        /// <summary>
                        /// 获取或设置申请时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("apply_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("apply_time")]
                        public long ApplyTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置申请通过时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("apply_suc_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("apply_suc_time")]
                        public long? ApplySuccessTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置移除时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long? EndTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品定向计划作者列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orien_plan_authors")]
                [System.Text.Json.Serialization.JsonPropertyName("orien_plan_authors")]
                public Types.Author[] AuthorList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
