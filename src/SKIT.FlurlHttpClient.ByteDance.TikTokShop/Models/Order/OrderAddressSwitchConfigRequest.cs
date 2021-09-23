using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/addresSwitchConfig 接口的请求。</para>
    /// </summary>
    public class OrderAddressSwitchConfigRequest : TikTokShopRequest
    {
        protected internal override string GetApiMethod()
        {
            return string.Intern("order.addresSwitchConfig");
        }
    }
}
