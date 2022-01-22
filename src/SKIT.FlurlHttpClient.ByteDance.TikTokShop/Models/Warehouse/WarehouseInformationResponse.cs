namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /warehouse/info 接口的响应。</para>
    /// </summary>
    public class WarehouseInformationResponse : TikTokShopResponse<WarehouseInformationResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : WarehouseListResponse.Types.Data.Types.Warehouse
            {
            }
        }
    }
}
