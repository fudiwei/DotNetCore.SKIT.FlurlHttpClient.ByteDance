namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /warehouse/info 接口的响应。</para>
    /// </summary>
    public class WarehouseInformationResponse : DouyinShopResponse<WarehouseInformationResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : WarehouseListResponse.Types.Data.Types.Warehouse
            {
            }
        }
    }
}
