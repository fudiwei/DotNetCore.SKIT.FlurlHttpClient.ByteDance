using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /crossBorder/queryBalance 接口的请求。</para>
    /// </summary>
    public class CrossBorderQueryBalanceRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
        public int ShopId { get; set; }

        protected internal override string GetApiMethod()
        {
            return string.Intern("crossBorder.queryBalance");
        }
    }
}
