namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /opptyProduct/clue 接口的响应。</para>
    /// </summary>
    public class OpportunityProductClueResponse : TikTokShopResponse<OpportunityProductClueResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置线索文件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = default!;

                /// <summary>
                /// 获取或设置线索数目。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int Count { get; set; }

                /// <summary>
                /// 获取或设置线索文件更新日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_date")]
                [System.Text.Json.Serialization.JsonPropertyName("update_date")]
                public string UpdateDateString { get; set; } = default!;
            }
        }
    }
}
