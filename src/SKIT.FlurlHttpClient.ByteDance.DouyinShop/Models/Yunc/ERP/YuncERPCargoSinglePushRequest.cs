using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /yunc/erpCargoSinglePush 接口的请求。</para>
    /// </summary>
    public class YuncERPCargoSinglePushRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class ExtendedProperty
            {
                /// <summary>
                /// 获取或设置属性 Key ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prop_key_id")]
                [System.Text.Json.Serialization.JsonPropertyName("prop_key_id")]
                public int? KeyId { get; set; }

                /// <summary>
                /// 获取或设置属性 Key。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prop_key")]
                [System.Text.Json.Serialization.JsonPropertyName("prop_key")]
                public string? Key { get; set; }

                /// <summary>
                /// 获取或设置属性值 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prop_val_id")]
                [System.Text.Json.Serialization.JsonPropertyName("prop_val_id")]
                public int? ValueId { get; set; }

                /// <summary>
                /// 获取或设置属性值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prop_val")]
                [System.Text.Json.Serialization.JsonPropertyName("prop_val")]
                public string? Valud { get; set; }
            }

            public class SKUProperty : ExtendedProperty
            {
            }

            public class Category
            {
                /// <summary>
                /// 获取或设置一级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_cid")]
                [System.Text.Json.Serialization.JsonPropertyName("first_cid")]
                public int? FirstCategoryId { get; set; }

                /// <summary>
                /// 获取或设置一级类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_cname")]
                [System.Text.Json.Serialization.JsonPropertyName("first_cname")]
                public string? FirstCategoryName { get; set; }

                /// <summary>
                /// 获取或设置二级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_cid")]
                [System.Text.Json.Serialization.JsonPropertyName("second_cid")]
                public int? SecondCategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_cname")]
                [System.Text.Json.Serialization.JsonPropertyName("second_cname")]
                public string? SecondCategoryName { get; set; }

                /// <summary>
                /// 获取或设置三级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_cid")]
                [System.Text.Json.Serialization.JsonPropertyName("third_cid")]
                public int? ThirdCategoryId { get; set; }

                /// <summary>
                /// 获取或设置三级类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_cname")]
                [System.Text.Json.Serialization.JsonPropertyName("third_cname")]
                public string? ThirdCategoryName { get; set; }

                /// <summary>
                /// 获取或设置四级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fourth_cid")]
                [System.Text.Json.Serialization.JsonPropertyName("fourth_cid")]
                public int? FourthCategoryId { get; set; }

                /// <summary>
                /// 获取或设置四级类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fourth_cname")]
                [System.Text.Json.Serialization.JsonPropertyName("fourth_cname")]
                public string? FourthCategoryName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 获取或设置 ERP SKU Id。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("erp_sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("erp_sku_id")]
        public string ERPSKUId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置货品名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cargo_name")]
        [System.Text.Json.Serialization.JsonPropertyName("cargo_name")]
        public string CargoName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置货品描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cargo_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("cargo_desc")]
        public string? CargoDescription { get; set; }

        /// <summary>
        /// 获取或设置货品英文名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("english_name")]
        [System.Text.Json.Serialization.JsonPropertyName("english_name")]
        public string? CargoEnglishName { get; set; }

        /// <summary>
        /// 获取或设置计量单位。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_unit")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_unit")]
        public string? StockUnit { get; set; }

        /// <summary>
        /// 获取或设置长度单位。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("length_unit")]
        [System.Text.Json.Serialization.JsonPropertyName("length_unit")]
        public string? LengthUnit { get; set; }

        /// <summary>
        /// 获取或设置长度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("length")]
        [System.Text.Json.Serialization.JsonPropertyName("length")]
        public double? Length { get; set; }

        /// <summary>
        /// 获取或设置宽度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("width")]
        [System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// 获取或设置高度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("height")]
        [System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        /// 获取或设置重量单位。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weight_unit")]
        [System.Text.Json.Serialization.JsonPropertyName("weight_unit")]
        public string? WeightUnit { get; set; }

        /// <summary>
        /// 获取或设置毛重。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gross_weight")]
        [System.Text.Json.Serialization.JsonPropertyName("gross_weight")]
        public double? GrossWeight { get; set; }

        /// <summary>
        /// 获取或设置净重。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("net_weight")]
        [System.Text.Json.Serialization.JsonPropertyName("net_weight")]
        public double? NetWeight { get; set; }

        /// <summary>
        /// 获取或设置货币单位。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency_unit")]
        [System.Text.Json.Serialization.JsonPropertyName("currency_unit")]
        public string? CurrencyUnit { get; set; }

        /// <summary>
        /// 获取或设置市场价。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("market_price")]
        [System.Text.Json.Serialization.JsonPropertyName("market_price")]
        public double? MarketPrice { get; set; }

        /// <summary>
        /// 获取或设置采购价。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supply_price")]
        [System.Text.Json.Serialization.JsonPropertyName("supply_price")]
        public double? SupplyPrice { get; set; }

        /// <summary>
        /// 获取或设置零售价。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retail_price")]
        [System.Text.Json.Serialization.JsonPropertyName("retail_price")]
        public double? RetailPrice { get; set; }

        /// <summary>
        /// 获取或设置是否航空禁运品。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_embargo")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_embargo")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsEmargo { get; set; }

        /// <summary>
        /// 获取或设置是否是否易碎品。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_fragile")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_fragile")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsFragile { get; set; }

        /// <summary>
        /// 获取或设置是否大件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_large")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_large")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsLarge { get; set; }

        /// <summary>
        /// 获取或设置是否贵重品。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_precious")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_precious")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsPrecious { get; set; }

        /// <summary>
        /// 获取或设置是否效期管理。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_need_valid")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_need_valid")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsNeedValid { get; set; }

        /// <summary>
        /// 获取或设置是否液体。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_liquid")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_liquid")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsLiquid { get; set; }

        /// <summary>
        /// 获取或设置是否危险品。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_hazardous")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_hazardous")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsHazardous { get; set; }

        /// <summary>
        /// 获取或设置有效期（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period_of_validity")]
        [System.Text.Json.Serialization.JsonPropertyName("period_of_validity")]
        public int? PeriodOfValidity { get; set; }

        /// <summary>
        /// 获取或设置禁售期（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period_of_forbid_sale")]
        [System.Text.Json.Serialization.JsonPropertyName("period_of_forbid_sale")]
        public int? PeriodOfForbidSale { get; set; }

        /// <summary>
        /// 获取或设置禁收期（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period_of_forbid_take")]
        [System.Text.Json.Serialization.JsonPropertyName("period_of_forbid_take")]
        public int? PeriodOfForbidTake { get; set; }

        /// <summary>
        /// 获取或设置临期预警天数（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period_of_warning")]
        [System.Text.Json.Serialization.JsonPropertyName("period_of_warning")]
        public int? PeriodOfWarning { get; set; }

        /// <summary>
        /// 获取或设置是否批次管理。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_need_batch")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_need_batch")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsNeedBatch { get; set; }

        /// <summary>
        /// 获取或设置批次类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_type")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_type")]
        public int? BatchType { get; set; }

        /// <summary>
        /// 获取或设置是否强批次管理。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_must_batch")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_must_batch")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsMatchBatch { get; set; }

        /// <summary>
        /// 获取或设置配件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accessory_info")]
        [System.Text.Json.Serialization.JsonPropertyName("accessory_info")]
        public string? AccessoryInformation { get; set; }

        /// <summary>
        /// 获取或设置产地。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("origin_address")]
        [System.Text.Json.Serialization.JsonPropertyName("origin_address")]
        public string? OriginAddress { get; set; }

        /// <summary>
        /// 获取或设置税率字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tax_rate")]
        [System.Text.Json.Serialization.JsonPropertyName("tax_rate")]
        public string? TaxRateString { get; set; }

        /// <summary>
        /// 获取或设置运输温度字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_temp")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_temp")]
        public string? DeliveryTemperatureString { get; set; }

        /// <summary>
        /// 获取或设置存储温度字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("storage_temp")]
        [System.Text.Json.Serialization.JsonPropertyName("storage_temp")]
        public string? StorageTemperatureString { get; set; }

        /// <summary>
        /// 获取或设置品牌编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_code")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_code")]
        public string? BrandCode { get; set; }

        /// <summary>
        /// 获取或设置品牌名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_name")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_name")]
        public string? BrandName { get; set; }

        /// <summary>
        /// 获取或设置货品图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("picture")]
        [System.Text.Json.Serialization.JsonPropertyName("picture")]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// 获取或设置类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public int? CategoryId { get; set; }

        /// <summary>
        /// 获取或设置类目名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_name")]
        [System.Text.Json.Serialization.JsonPropertyName("category_name")]
        public string? CategoryName { get; set; }

        /// <summary>
        /// 获取或设置类目详细信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("category_detail")]
        public Types.Category? Category { get; set; }

        /// <summary>
        /// 获取或设置条形码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("barcode")]
        [System.Text.Json.Serialization.JsonPropertyName("barcode")]
        public IList<string>? BarCodeList { get; set; }

        /// <summary>
        /// 获取或设置扩展描述属性列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("props_extends")]
        [System.Text.Json.Serialization.JsonPropertyName("props_extends")]
        public IList<Types.ExtendedProperty>? ExtendedPropertyList { get; set; }

        /// <summary>
        /// 获取或设置销售规格属性列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_props")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_props")]
        public IList<Types.SKUProperty>? SKUPropertyList { get; set; }

        /// <summary>
        /// 获取或设置状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置仓库编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_code")]
        [System.Text.Json.Serialization.JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; } = string.Empty;
    }
}
