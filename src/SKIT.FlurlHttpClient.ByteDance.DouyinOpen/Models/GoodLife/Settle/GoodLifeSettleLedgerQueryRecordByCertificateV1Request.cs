using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/settle/ledger/query_record_by_cert 接口的请求。</para>
    /// </summary>
    public class GoodLifeSettleLedgerQueryRecordByCertificateV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置券 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> CertificateIdList { get; set; } = new List<string>();
    }
}
