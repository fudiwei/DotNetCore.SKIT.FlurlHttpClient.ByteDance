namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /opptyProduct/getApplyProgress 接口的响应。</para>
    /// </summary>
    public class OpportunityProductGetApplyProgressResponse : DouyinShopResponse<OpportunityProductGetApplyProgressResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置机会品提报状态编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置机会品提报状态中文描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("status_desc")]
                public string StatusDescription { get; set; } = default!;
            }
        }
    }
}
