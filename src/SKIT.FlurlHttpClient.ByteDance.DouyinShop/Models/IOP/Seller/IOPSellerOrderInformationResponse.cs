namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/sellerOrderInfo 接口的响应。</para>
    /// </summary>
    public class IOPSellerOrderInformationResponse : DouyinShopResponse<IOPSellerOrderInformationResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class DistributeOrder : IOPSellerOrderListResponse.Types.Data.Types.DistributeOrder
                    {
                    }
                }

                /// <summary>
                /// 获取或设置代打订单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("distr_order_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("distr_order_detail")]
                public Types.DistributeOrder DistributeOrder { get; set; } = default!;
            }
        }
    }
}
