namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/item/base 接口的请求。</para>
    /// </summary>
    public class DataExternalItemBaseRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置视频 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ItemId { get; set; } = string.Empty;
    }
}
