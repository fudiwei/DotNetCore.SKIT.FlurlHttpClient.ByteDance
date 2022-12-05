namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/goods/product/save 接口的响应。</para>
    /// </summary>
    public class GoodLifeGoodsProductSaveV1Response : DouyinOpenResponse<GoodLifeGoodsProductSaveV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public string ProductId { get; set; } = default!;
            }
        }
    }
}
