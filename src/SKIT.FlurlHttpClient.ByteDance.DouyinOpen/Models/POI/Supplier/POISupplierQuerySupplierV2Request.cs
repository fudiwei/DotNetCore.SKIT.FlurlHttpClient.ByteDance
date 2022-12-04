using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/v2/supplier/query/supplier 接口的请求。</para>
    /// </summary>
    public class POISupplierQuerySupplierV2Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置接入方店铺外部 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> SupplierExternalIdList { get; set; } = new List<string>();
    }
}
