namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/book/merchant_cancel_book 接口的响应。</para>
    /// </summary>
    public class AppsTradeBookMerchantCancelBookV2Response : DouyinOpenResponse<AppsTradeBookMerchantCancelBookV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }
        }
    }
}
