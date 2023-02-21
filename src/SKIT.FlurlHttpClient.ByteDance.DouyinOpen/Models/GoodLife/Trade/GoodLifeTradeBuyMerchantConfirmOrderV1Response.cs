namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/trade/buy/merchant_confirm_order 接口的响应。</para>
    /// </summary>
    public class GoodLifeTradeBuyMerchantConfirmOrderV1Response : DouyinOpenResponse<GoodLifeTradeBuyMerchantConfirmOrderV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }
        }
    }
}
