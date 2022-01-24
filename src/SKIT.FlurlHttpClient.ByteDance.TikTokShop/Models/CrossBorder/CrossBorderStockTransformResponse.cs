namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /crossBorder/stockTransform 接口的响应。</para>
    /// </summary>
    public class CrossBorderStockTransformResponse : TikTokShopResponse<CrossBorderStockTransformResponse.Types.Data>
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
