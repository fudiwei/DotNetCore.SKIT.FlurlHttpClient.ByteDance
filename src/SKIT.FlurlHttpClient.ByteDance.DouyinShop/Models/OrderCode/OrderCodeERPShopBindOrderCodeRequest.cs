using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /orderCode/erpShopBindOrderCode 接口的请求。</para>
    /// </summary>
    public class OrderCodeERPShopBindOrderCodeRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Order
            {
                public static class Types
                {
                    public class Detail
                    {
                        /// <summary>
                        /// 获取或设置该订单购买的商品对应平台的 SKUId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("combo_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("combo_id")]
                        public long ComboId { get; set; }

                        /// <summary>
                        /// 获取或设置发货数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_qty")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_qty")]
                        public int Quantity { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 条形码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_barcode")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_barcode")]
                        public string? SKUBarCode { get; set; }

                        /// <summary>
                        /// 获取或设置商品唯一标识编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unique_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("unique_code")]
                        public string? UniqueCode { get; set; }

                        /// <summary>
                        /// 获取或设置批次属性 01。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lot01")]
                        [System.Text.Json.Serialization.JsonPropertyName("lot01")]
                        public string? Lot01 { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                public string OrderId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置订单码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_code")]
                [System.Text.Json.Serialization.JsonPropertyName("order_code")]
                public string? OrderCode { get; set; }

                /// <summary>
                /// 获取或设置运单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logistics_code")]
                [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
                public string? LogisticsNumber { get; set; }

                /// <summary>
                /// 获取或设置物流公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logistics_id")]
                [System.Text.Json.Serialization.JsonPropertyName("logistics_id")]
                public int? LogisticsCompanyId { get; set; }

                /// <summary>
                /// 获取或设置商品明细列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("order_detail")]
                public IList<Types.Detail> DetailList { get; set; } = new List<Types.Detail>();
            }
        }

        /// <summary>
        /// 获取或设置商家包裹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_package_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_package_id")]
        public long ShopPackageId { get; set; }

        /// <summary>
        /// 获取或设置送检方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_type")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_type")]
        public int DeliveryType { get; set; }

        /// <summary>
        /// 获取或设置出仓方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ship_type")]
        [System.Text.Json.Serialization.JsonPropertyName("ship_type")]
        public int ShipType { get; set; }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public IList<Types.Order> OrderList { get; set; } = new List<Types.Order>();
    }
}
