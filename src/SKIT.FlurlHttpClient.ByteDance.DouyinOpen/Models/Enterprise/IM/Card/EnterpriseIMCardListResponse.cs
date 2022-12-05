namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /enterprise/im/card/list 接口的响应。</para>
    /// </summary>
    public class EnterpriseIMCardListResponse : DouyinOpenResponse<EnterpriseIMCardListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Card
                    {
                        /// <summary>
                        /// 获取或设置卡片 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string CardId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置卡片名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_name")]
                        public string? CardName { get; set; }

                        /// <summary>
                        /// 获取或设置卡片类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_type")]
                        public string CardType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置卡片内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                        public string? RejectReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置卡片列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cards")]
                [System.Text.Json.Serialization.JsonPropertyName("cards")]
                public Types.Card[] CardList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                public long? PageCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
