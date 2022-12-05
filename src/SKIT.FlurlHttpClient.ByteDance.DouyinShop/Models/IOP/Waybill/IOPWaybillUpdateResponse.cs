namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/waybillUpdate 接口的响应。</para>
    /// </summary>
    public class IOPWaybillUpdateResponse : DouyinShopResponse<IOPWaybillUpdateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : IOPWaybillReturnResponse.Types.Data
            {
            }
        }
    }
}
