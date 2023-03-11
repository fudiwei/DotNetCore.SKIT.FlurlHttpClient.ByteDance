namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    /// <summary>
    /// TikTok Shop API 请求的基类。
    /// </summary>
    public abstract class TikTokShopRequest : ICommonRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="TikTokShopClient"/> 时的 <see cref="TikTokShopClientOptions.Timeout"/> 参数，这在需要指定特定耗时请求（比如上传或下载文件）的超时时间时很有用。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual int? Timeout { get; set; }

        /// <summary>
        /// 获取或设置店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? ShopId { get; set; }

        /// <summary>
        /// 获取或设置接口调用凭证。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置系统时间戳。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual long? Timestamp { get; set; }
    }
}
