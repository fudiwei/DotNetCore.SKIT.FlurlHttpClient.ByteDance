namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    /// <summary>
    /// TikTok Shop API 请求的基类。
    /// </summary>
    public abstract class TikTokShopRequest : CommonRequestBase, ICommonRequest
    {
        /// <summary>
        /// 获取或设置接口调用凭证。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置店铺密码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual string? ShopCipher { get; set; }

        /// <summary>
        /// 获取或设置系统时间戳。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual long? Timestamp { get; set; }

        /// <summary>
        /// 获取或设置 API 版本号。
        /// <para>默认值：202309</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual int ApiVersion { get; set; } = 202309;
    }
}
