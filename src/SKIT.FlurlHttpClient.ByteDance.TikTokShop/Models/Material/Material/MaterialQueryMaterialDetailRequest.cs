using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/queryMaterialDetail 接口的请求。</para>
    /// </summary>
    public class MaterialQueryMaterialDetailRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置素材 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("object_id")]
        [System.Text.Json.Serialization.JsonPropertyName("object_id")]
        public string ObjectId { get; set; } = string.Empty;

        protected internal override string GetApiMethod()
        {
            return string.Intern("material.queryMaterialDetail");
        }
    }
}
