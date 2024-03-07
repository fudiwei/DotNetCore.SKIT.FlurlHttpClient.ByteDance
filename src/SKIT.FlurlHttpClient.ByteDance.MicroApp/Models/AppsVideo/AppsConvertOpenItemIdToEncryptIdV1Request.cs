using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/convert_video_id/open_item_id_to_encrypt_id/ 接口的请求。</para>
    /// </summary>
    public class AppsConvertOpenItemIdToEncryptIdV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置访问密钥。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_key")]
        [System.Text.Json.Serialization.JsonPropertyName("access_key")]
        public string? AccessKey { get; set; }

        /// <summary>
        /// 获取或设置视频 ItemId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("video_ids")]
        public IList<string> OpenItemIdList { get; set; } = new List<string>();
    }
}
