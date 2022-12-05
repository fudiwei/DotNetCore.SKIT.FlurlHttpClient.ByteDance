namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/goods/stock/sync 接口的响应。</para>
    /// </summary>
    public class GoodLifeGoodsStockSyncV1Response : DouyinOpenResponse<GoodLifeGoodsStockSyncV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
            }
        }
    }
}
