using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /yunc/createOutboundOrderToB 接口的请求。</para>
    /// </summary>
    public class YuncCreateOutboundOrderToBusinessRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Sender
            {
                /// <summary>
                /// 获取或设置省份编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_code")]
                [System.Text.Json.Serialization.JsonPropertyName("province_code")]
                public string? ProvinceCode { get; set; }

                /// <summary>
                /// 获取或设置省份名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string? ProvinceName { get; set; }

                /// <summary>
                /// 获取或设置城市编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city_code")]
                [System.Text.Json.Serialization.JsonPropertyName("city_code")]
                public string? CityCode { get; set; }

                /// <summary>
                /// 获取或设置城市名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string? CityName { get; set; }

                /// <summary>
                /// 获取或设置区县编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("district_code")]
                [System.Text.Json.Serialization.JsonPropertyName("district_code")]
                public string? DistrictCode { get; set; }

                /// <summary>
                /// 获取或设置区县名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("district")]
                [System.Text.Json.Serialization.JsonPropertyName("district")]
                public string? DistrictName { get; set; }

                /// <summary>
                /// 获取或设置街道编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("street_code")]
                [System.Text.Json.Serialization.JsonPropertyName("street_code")]
                public int? StreetCode { get; set; }

                /// <summary>
                /// 获取或设置街道名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("street")]
                [System.Text.Json.Serialization.JsonPropertyName("street")]
                public string? StreetName { get; set; }

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail")]
                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                public string? Detail { get; set; }

                /// <summary>
                /// 获取或设置姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                public string? MobileNumber { get; set; }
            }

            public class Receiver : Sender
            {
            }

            public class OrderLine
            {
                /// <summary>
                /// 获取或设置出库单行号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("line_no")]
                [System.Text.Json.Serialization.JsonPropertyName("line_no")]
                public string LineNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置货品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_code")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_code")]
                public string CargoCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置库存类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inventory_type")]
                [System.Text.Json.Serialization.JsonPropertyName("inventory_type")]
                public int InventoryType { get; set; }

                /// <summary>
                /// 获取或设置库存状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inventory_status")]
                [System.Text.Json.Serialization.JsonPropertyName("inventory_status")]
                public int InventoryStatus { get; set; }

                /// <summary>
                /// 获取或设置 ERP SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("erp_sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("erp_sku_id")]
                public string ERPSKUId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置 SKU 名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_name")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_name")]
                public string? SKUName { get; set; }

                /// <summary>
                /// 获取或设置条形码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("barcode")]
                [System.Text.Json.Serialization.JsonPropertyName("barcode")]
                public string? BarCode { get; set; }

                /// <summary>
                /// 获取或设置类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_name")]
                [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                public string? CategoryName { get; set; }

                /// <summary>
                /// 获取或设置订单数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expected_qty")]
                [System.Text.Json.Serialization.JsonPropertyName("expected_qty")]
                public int ExpectedQuantity { get; set; }

                /// <summary>
                /// 获取或设置批次号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("batch_code")]
                [System.Text.Json.Serialization.JsonPropertyName("batch_code")]
                public string? BatchNumber { get; set; }

                /// <summary>
                /// 获取或设置生产时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_date")]
                [System.Text.Json.Serialization.JsonPropertyName("product_date")]
                public long? ProduceTimestamp { get; set; }

                /// <summary>
                /// 获取或设置过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_date")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_date")]
                public long? ExpireTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 获取或设置店铺名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_name")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_name")]
        public string? ShopName { get; set; }

        /// <summary>
        /// 获取或设置单据类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public int OrderType { get; set; }

        /// <summary>
        /// 获取或设置出库仓库编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_code")]
        [System.Text.Json.Serialization.JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置入库仓库编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("in_warehouse_code")]
        [System.Text.Json.Serialization.JsonPropertyName("in_warehouse_code")]
        public string? InWarehouseCode { get; set; }

        /// <summary>
        /// 获取或设置运输方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_mode")]
        public int DeliveryMode { get; set; }

        /// <summary>
        /// 获取或设置 ERP 出库单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("erp_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("erp_order_no")]
        public string ERPOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置应发数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expected_qty")]
        [System.Text.Json.Serialization.JsonPropertyName("expected_qty")]
        public int ExpectedQuantity { get; set; }

        /// <summary>
        /// 获取或设置订单来源平台编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_platform_code")]
        [System.Text.Json.Serialization.JsonPropertyName("source_platform_code")]
        public string? SourcePlatformCode { get; set; }

        /// <summary>
        /// 获取或设置订单来源平台名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_platform_name")]
        [System.Text.Json.Serialization.JsonPropertyName("source_platform_name")]
        public string? SourcePlatformName { get; set; }

        /// <summary>
        /// 获取或设置前台订单下单时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_time")]
        [System.Text.Json.Serialization.JsonPropertyName("order_time")]
        public long OrderTimestamp { get; set; }

        /// <summary>
        /// 获取或设置商家审单时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("review_time")]
        [System.Text.Json.Serialization.JsonPropertyName("review_time")]
        public long ReviewTimestamp { get; set; }

        /// <summary>
        /// 获取或设置快递公司编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("express_code")]
        [System.Text.Json.Serialization.JsonPropertyName("express_code")]
        public string? LogisticsCompanyCode { get; set; }

        /// <summary>
        /// 获取或设置快递公司名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("express_name")]
        [System.Text.Json.Serialization.JsonPropertyName("express_name")]
        public string? LogisticsCompanyName { get; set; }

        /// <summary>
        /// 获取或设置是否保价。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_insure")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_insure")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsInsured { get; set; }

        /// <summary>
        /// 获取或设置保价金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insure_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("insure_amount")]
        public int? InsureAmount { get; set; }

        /// <summary>
        /// 获取或设置快递产品类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("express_product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("express_product_id")]
        public string? LogisticsProductId { get; set; }

        /// <summary>
        /// 获取或设置快递产品名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("express_product_name")]
        [System.Text.Json.Serialization.JsonPropertyName("express_product_name")]
        public string? LogisticsProductName { get; set; }

        /// <summary>
        /// 获取或设置是否允许合单。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_merge")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("allow_merge")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? AllowMerge { get; set; }

        /// <summary>
        /// 获取或设置发货人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender_info")]
        [System.Text.Json.Serialization.JsonPropertyName("sender_info")]
        public Types.Sender? Sender { get; set; }

        /// <summary>
        /// 获取或设置收货人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver_info")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver_info")]
        public Types.Receiver? Receiver { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置买家备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_message")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_message")]
        public string? BuyerMessage { get; set; }

        /// <summary>
        /// 获取或设置卖家备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_message")]
        [System.Text.Json.Serialization.JsonPropertyName("seller_message")]
        public string? SellerMessage { get; set; }

        /// <summary>
        /// 获取或设置扩展字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extend")]
        [System.Text.Json.Serialization.JsonPropertyName("extend")]
        public string? Extra { get; set; }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_details")]
        [System.Text.Json.Serialization.JsonPropertyName("order_details")]
        public IList<Types.OrderLine>? OrderLineList { get; set; }
    }
}
