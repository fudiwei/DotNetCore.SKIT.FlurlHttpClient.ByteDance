namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/item/play 接口的请求。</para>
    /// </summary>
    public class DataExternalItemPlayRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置视频 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ItemId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置日期类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int DateType { get; set; }
    }
}
