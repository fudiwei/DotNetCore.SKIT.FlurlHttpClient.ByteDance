namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/templateList 接口的请求。</para>
    /// </summary>
    public class LogisticsTemplateListRequest : TikTokShopRequest
    {
        protected internal override string GetApiMethod()
        {
            return string.Intern("logistics.templateList");
        }
    }
}
