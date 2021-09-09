using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/getShopCategory 接口的请求。</para>
    /// </summary>
    public class ShopGetShopCategoryRequest : TikTokShopRequest
    {
        protected internal override string GetApiMethod()
        {
            return string.Intern("shop.getShopCategory");
        }
    }
}
