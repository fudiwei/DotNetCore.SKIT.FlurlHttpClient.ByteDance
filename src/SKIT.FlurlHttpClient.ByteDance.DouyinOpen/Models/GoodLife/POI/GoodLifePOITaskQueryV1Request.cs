using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/poi/task/query 接口的请求。</para>
    /// </summary>
    public class GoodLifePOITaskQueryV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置任务 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<long> TaskIdList { get; set; } = new List<long>();
    }
}
