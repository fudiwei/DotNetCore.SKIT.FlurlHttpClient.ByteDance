namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/sellerDistribute 接口的响应。</para>
    /// </summary>
    public class IOPSellerDistributeResponse : TikTokShopResponse<IOPSellerDistributeResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置要分配的厂商的店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_shop_id")]
                        public long SupplierShopId { get; set; }

                        /// <summary>
                        /// 获取或设置代打订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("distr_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("distr_order_id")]
                        public string DistributeOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置错误状态码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("err_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
                        public int ErrorNumber { get; set; }

                        /// <summary>
                        /// 获取或设置错误描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("message")]
                        [System.Text.Json.Serialization.JsonPropertyName("message")]
                        public string? ErrorMessage { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置分配结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("distribute_order_reuslts")]
                [System.Text.Json.Serialization.JsonPropertyName("distribute_order_reuslts")]
                public Types.Result[] ResultList { get; set; } = default!;
            }
        }
    }
}
