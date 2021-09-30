namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/orienPlanAuthorsAdd 接口的响应。</para>
    /// </summary>
    public class BuyinOrientPlanAuthorsAddResponse : TikTokShopResponse<BuyinOrientPlanAuthorsAddResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Failure
                    {
                        /// <summary>
                        /// 获取或设置达人百应 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyin_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyin_id")]
                        public int BuyinId { get; set; }

                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("error_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("error_code")]
                        public int ErrorCode { get; set; }

                        /// <summary>
                        /// 获取或设置错误原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("error_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("error_msg")]
                        public string ErrorMessage { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置添加成功的作者 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("success_ids")]
                public int[] SucceededIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置添加失败的作者 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_ids")]
                public Types.Failure[] FailureList { get; set; } = default!;
            }
        }
    }
}
