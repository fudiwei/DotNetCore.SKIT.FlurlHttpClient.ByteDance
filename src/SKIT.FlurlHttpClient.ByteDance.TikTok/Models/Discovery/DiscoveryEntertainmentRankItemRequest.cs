namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /discovery/ent/rank/item 接口的请求。</para>
    /// </summary>
    public class DiscoveryEntertainmentRankItemRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置榜单类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置榜单版本。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Version { get; set; }
    }
}
