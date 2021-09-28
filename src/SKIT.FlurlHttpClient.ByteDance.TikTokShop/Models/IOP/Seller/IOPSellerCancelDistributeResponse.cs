namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/sellerCancleDistribute 接口的响应。</para>
    /// </summary>
    public class IOPSellerCancelDistributeResponse : TikTokShopResponse<IOPSellerCancelDistributeResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置取消成功的订单 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("succ_distr_order_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("succ_distr_order_ids")]
                public string[] SuccessfulDistributeOrderIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置取消失败的订单 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_distr_order_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_distr_order_ids")]
                public string[] FailedDistributeOrderIdList { get; set; } = default!;
            }
        }
    }
}
