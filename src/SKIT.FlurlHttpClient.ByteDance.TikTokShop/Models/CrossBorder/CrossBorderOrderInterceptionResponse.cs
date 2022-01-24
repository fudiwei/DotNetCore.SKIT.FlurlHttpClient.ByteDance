namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /crossBorder/OrderInterception 接口的响应。</para>
    /// </summary>
    public class CrossBorderOrderInterceptionResponse : TikTokShopResponse<CrossBorderOrderInterceptionResponse.Types.Data>
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
