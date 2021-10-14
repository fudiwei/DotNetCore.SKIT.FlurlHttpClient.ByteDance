namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /star/hot_list 接口的请求。</para>
    /// </summary>
    public class StarHotListRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置达人热榜类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int HotListType { get; set; }
    }
}
