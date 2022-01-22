namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /crossBorder/warehouseInOutboundEvent 接口的响应。</para>
    /// </summary>
    public class CrossBorderWarehouseInOutboundEventResponse : TikTokShopResponse<CrossBorderWarehouseInOutboundEventResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : CrossBorderStockTakingResponse.Types.Data
            {
            }
        }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.ErrorCode == 0;
        }
    }
}
