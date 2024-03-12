namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /share-id/ 接口的请求。</para>
    /// </summary>
    public class ShareIdRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置是否需要指定分享结果。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool? RequireCallback { get; set; }

        /// <summary>
        /// 获取或设置多来源样式 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SourceStyleId { get; set; }

        /// <summary>
        /// 获取或设置追踪分享默认 HashTag。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? DefaultHashTag { get; set; }

        /// <summary>
        /// 获取或设置分享来源附加参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? LinkParameter { get; set; }
    }
}
