namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/book/book_result_callback 接口的响应。</para>
    /// </summary>
    public class AppsTradeBookResultCallbackV2Response : DouyinOpenResponse<AppsTradeBookResultCallbackV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }
        }
    }
}
