namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/book/user_cancel_book 接口的响应。</para>
    /// </summary>
    public class AppsTradeBookUserCancelBookV2Response : DouyinOpenResponse<AppsTradeBookUserCancelBookV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }
        }
    }
}
