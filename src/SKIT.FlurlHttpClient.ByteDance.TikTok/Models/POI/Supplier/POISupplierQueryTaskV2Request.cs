using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/v2/supplier/query/task 接口的请求。</para>
    /// </summary>
    public class POISupplierQueryTaskV2Request : TikTokRequest
    {
        /// <summary>
        /// 获取或设置第三方上传任务 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> SupplierTaskIdList { get; set; } = new List<string>();
    }
}
