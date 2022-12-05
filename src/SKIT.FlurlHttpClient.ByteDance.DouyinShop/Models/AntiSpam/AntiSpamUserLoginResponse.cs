namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /antispam/userLogin 接口的响应。</para>
    /// </summary>
    public class AntiSpamUserLoginResponse : DouyinShopResponse<AntiSpamUserLoginResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Decision
                    {
                        /// <summary>
                        /// 获取或设置决策类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("decision")]
                        [System.Text.Json.Serialization.JsonPropertyName("decision")]
                        public string DecisionType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置决策详情。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("decision_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("decision_detail")]
                        public string DecisionDetail { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置提示信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hit_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("hit_status")]
                        public string HitStatus { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置决策信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("decision")]
                [System.Text.Json.Serialization.JsonPropertyName("decision")]
                public Types.Decision Decision { get; set; } = default!;
            }
        }
    }
}
