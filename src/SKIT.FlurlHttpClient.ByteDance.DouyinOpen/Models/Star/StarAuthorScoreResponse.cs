namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /star/author_score 接口的响应。</para>
    /// </summary>
    public class StarAuthorScoreResponse : DouyinOpenResponse<StarAuthorScoreResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nick_name")]
                [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置性价比指数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cp_score")]
                [System.Text.Json.Serialization.JsonPropertyName("cp_score")]
                public decimal CPScore { get; set; }

                /// <summary>
                /// 获取或设置种草指数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_score")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_score")]
                public decimal ShopScore { get; set; }

                /// <summary>
                /// 获取或设置传播指数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spread_score")]
                [System.Text.Json.Serialization.JsonPropertyName("spread_score")]
                public decimal SpreadScore { get; set; }

                /// <summary>
                /// 获取或设置星图指数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("star_score")]
                [System.Text.Json.Serialization.JsonPropertyName("star_score")]
                public decimal StarScore { get; set; }

                /// <summary>
                /// 获取或设置合作指数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cooperation_score")]
                [System.Text.Json.Serialization.JsonPropertyName("cooperation_score")]
                public decimal CooperationScore { get; set; }

                /// <summary>
                /// 获取或设置涨粉指数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("growth_score")]
                [System.Text.Json.Serialization.JsonPropertyName("growth_score")]
                public decimal GrowthScore { get; set; }

                /// <summary>
                /// 获取或设置粉丝数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("follower")]
                [System.Text.Json.Serialization.JsonPropertyName("follower")]
                public int FansCount { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("update_timestamp")]
                public long UpdateTimestamp { get; set; }
            }
        }
    }
}
