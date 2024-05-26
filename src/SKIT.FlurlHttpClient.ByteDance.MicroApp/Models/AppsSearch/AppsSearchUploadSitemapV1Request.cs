using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/search/upload_sitemap/ 接口的请求。</para>
    /// </summary>
    public class AppsSearchUploadSitemapV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置页面路径列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_paths")]
        [System.Text.Json.Serialization.JsonPropertyName("page_paths")]
        public IList<string> PagePathList { get; set; } = new List<string>();
    }
}
