namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/poi/match/task/query 接口的请求。</para>
    /// </summary>
    public class GoodLifePOIMatchTaskQueryV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long TaskId { get; set; }
    }
}
