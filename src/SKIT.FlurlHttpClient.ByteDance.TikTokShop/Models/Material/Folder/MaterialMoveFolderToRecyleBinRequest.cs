using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/moveFolderToRecycleBin 接口的请求。</para>
    /// </summary>
    public class MaterialMoveFolderToRecyleBinRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置文件夹 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("object_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("object_ids")]
        public IList<string> ObjectIdList { get; set; } = new List<string>();
    }
}
