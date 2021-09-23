using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /orderCode/downloadOrderCodeByShop 接口的请求。</para>
    /// </summary>
    public class OrderCodeDownloadOrderCodeByShopRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long OrderId { get; set; }

        protected internal override string GetApiMethod()
        {
            return string.Intern("orderCode.downloadOrderCodeByShop");
        }
    }
}
