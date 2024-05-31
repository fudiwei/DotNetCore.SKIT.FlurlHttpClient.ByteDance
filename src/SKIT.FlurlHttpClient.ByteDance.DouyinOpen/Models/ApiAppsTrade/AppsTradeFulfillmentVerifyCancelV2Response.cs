namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/fulfillment/verify_cancel 接口的响应。</para>
    /// </summary>
    public class AppsTradeFulfillmentVerifyCancelV2Response : DouyinOpenResponse<AppsTradeFulfillmentVerifyCancelV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }
        }
    }
}
