namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /recycle/buyerGetOrderDetail 接口的响应。</para>
    /// </summary>
    public class RecycleBuyerGetOrderDetailResponse : DouyinShopResponse<RecycleBuyerGetOrderDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ClueOrder : RecycleBuyerGetOrderListResponse.Types.ClueOrder
                    {
                    }
                }

                /// <summary>
                /// 获取或设置线索单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail")]
                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                public Types.ClueOrder ClueOrder { get; set; } = default!;
            }
        }
    }
}
