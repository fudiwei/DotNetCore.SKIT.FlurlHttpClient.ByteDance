using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/poi/match/relation/query 接口的请求。</para>
    /// </summary>
    public class GoodLifePOIMatchRelationQueryV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置门店外部 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> POIExternalIdList { get; set; } = new List<string>();
    }
}
