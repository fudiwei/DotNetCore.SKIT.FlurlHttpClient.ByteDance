using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/fulfilment/certificate/verify_record/query 接口的请求。</para>
    /// </summary>
    public class GoodLifeFulfilmentCertificateVerifyRecordQueryV1Request : TikTokRequest
    {
        /// <summary>
        /// 获取或设置商家团购账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string>? POIIdList { get; set; }

        /// <summary>
        /// 获取或设置起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// <para>默认值："0"</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PageCursor { get; set; } = "0";

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PageSize { get; set; } = 10;
    }
}
