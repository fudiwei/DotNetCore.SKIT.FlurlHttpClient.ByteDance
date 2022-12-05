namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /antispam/orderQuery 接口的响应。</para>
    /// </summary>
    public class AntiSpamOrderQueryResponse : DouyinShopResponse<AntiSpamOrderQueryResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Decision : AntiSpamUserLoginResponse.Types.Data.Types.Decision
                    {
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
