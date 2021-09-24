namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /btas/listBrand 接口的请求。</para>
    /// </summary>
    public class BTASListBrandRequest : TikTokShopRequest
    {
        protected internal override string GetApiMethod()
        {
            return string.Intern("btas.listBrand");
        }
    }
}
