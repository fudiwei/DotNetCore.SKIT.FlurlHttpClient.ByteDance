using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /im/save/retain_consult_card/ 接口的请求。</para>
    /// </summary>
    public class IMSaveRetainConsultCardRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置卡片 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string? CardId { get; set; }

        /// <summary>
        /// 获取或设置图片 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string? MediaId { get; set; }

        /// <summary>
        /// 获取或设置输入组件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("components")]
        [System.Text.Json.Serialization.JsonPropertyName("components")]
        public IList<int> ComponentIdList { get; set; } = new List<int>();

        /// <summary>
        /// 获取或设置卡片标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;
    }
}
