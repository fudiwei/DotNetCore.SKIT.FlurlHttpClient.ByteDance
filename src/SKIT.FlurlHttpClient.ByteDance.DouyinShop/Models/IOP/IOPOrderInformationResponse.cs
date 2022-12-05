namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/orderInfo 接口的响应。</para>
    /// </summary>
    public class IOPOrderInformationResponse : DouyinShopResponse<IOPOrderInformationResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : IOPOrderListResponse.Types.Data.Types.DistributeOrder
            {
            }
        }
    }
}
