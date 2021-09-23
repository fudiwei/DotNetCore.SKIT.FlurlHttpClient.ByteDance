using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /orderCode/batchGetOrderCodeByShop 接口的请求。</para>
    /// </summary>
    public class OrderCodeBatchGetOrderCodeByShopRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("order_ids")]
        public IList<long> OrderIdList { get; set; } = new List<long>();

        protected internal override string GetApiMethod()
        {
            return string.Intern("orderCode.batchGetOrderCodeByShop");
        }
    }
}
