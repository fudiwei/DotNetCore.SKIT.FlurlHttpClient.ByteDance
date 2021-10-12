using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/v1/settle 接口的响应。</para>
    /// </summary>
    public class AppsECPayV1SettleResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// 获取或设置担保交易分帐单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_no")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_no")]
        public string SettleNumber { get; set; } = default!;
    }
}
