namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /freightTemplate/list 接口的请求。</para>
    /// </summary>
    public class FreightTemplateListRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置运费模板名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置翻页页数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 获取或设置翻页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? PageSize { get; set; }
    }
}
