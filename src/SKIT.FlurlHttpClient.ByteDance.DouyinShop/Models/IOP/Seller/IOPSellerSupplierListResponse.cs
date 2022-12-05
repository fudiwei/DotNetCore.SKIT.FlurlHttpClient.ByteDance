namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/sellerSupplierList 接口的响应。</para>
    /// </summary>
    public class IOPSellerSupplierListResponse : DouyinShopResponse<IOPSellerSupplierListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SupplierShop
                    {
                        /// <summary>
                        /// 获取或设置厂商店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_shop_id")]
                        public long SupplierShopId { get; set; }

                        /// <summary>
                        /// 获取或设置厂商店铺名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_shop_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_shop_name")]
                        public string SupplierShopName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置绑定状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bind_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("bind_status")]
                        public int BindStatus { get; set; }

                        /// <summary>
                        /// 获取或设置申请时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("apply_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("apply_time")]
                        public long ApplyTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置绑定时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("band_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("band_time")]
                        public long? BindTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置拒绝时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refuse_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("refuse_time")]
                        public long? RefuseTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置厂商店铺列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_shop_list")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_shop_list")]
                public Types.SupplierShop[] SupplierShopList { get; set; } = default!;

                /// <summary>
                /// 获取或设置翻页页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page")]
                [System.Text.Json.Serialization.JsonPropertyName("page")]
                public int PageNumber { get; set; }

                /// <summary>
                /// 获取或设置翻页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_size")]
                [System.Text.Json.Serialization.JsonPropertyName("page_size")]
                public int PageSize { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
