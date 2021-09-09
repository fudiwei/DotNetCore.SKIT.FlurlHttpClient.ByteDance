using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /coupons/abandon 接口的请求。</para>
    /// </summary>
    public class CouponsAbandonRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置卡券券码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_no")]
        [System.Text.Json.Serialization.JsonPropertyName("cert_no")]
        public string CertNumber { get; set; } = string.Empty;

        protected internal override string GetApiMethod()
        {
            return string.Intern("coupons.abandon");
        }
    }
}
