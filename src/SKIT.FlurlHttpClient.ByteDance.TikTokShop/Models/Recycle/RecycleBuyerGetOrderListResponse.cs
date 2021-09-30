namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /recycle/buyerGetOrderList 接口的响应。</para>
    /// </summary>
    public class RecycleBuyerGetOrderListResponse : TikTokShopResponse<RecycleBuyerGetOrderListResponse.Types.ClueOrder[]>
    {
        public static class Types
        {
            public class ClueOrder
            {
                /// <summary>
                /// 获取或设置线索单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("clue_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("clue_order_id")]
                public string ClueOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置线索 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("clue_id")]
                [System.Text.Json.Serialization.JsonPropertyName("clue_id")]
                public string ClueId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("clue_order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("clue_order_status")]
                public int ClueOrderStatus { get; set; }

                /// <summary>
                /// 获取或设置字节小程序的 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置下单来源类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("theme_type")]
                [System.Text.Json.Serialization.JsonPropertyName("theme_type")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? ThemeType { get; set; }

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_name")]
                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                public string ProductName { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_pic")]
                [System.Text.Json.Serialization.JsonPropertyName("product_pic")]
                public string? ProductPictureUrl { get; set; }

                /// <summary>
                /// 获取或设置 SKU 描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku")]
                [System.Text.Json.Serialization.JsonPropertyName("sku")]
                public string SKU { get; set; } = default!;

                /// <summary>
                /// 获取或设置购买渠道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("purchase_way")]
                [System.Text.Json.Serialization.JsonPropertyName("purchase_way")]
                public int PurchaseWay { get; set; }

                /// <summary>
                /// 获取或设置购买凭证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("proof")]
                [System.Text.Json.Serialization.JsonPropertyName("proof")]
                public string? Proof { get; set; }

                /// <summary>
                /// 获取或设置成色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("vintage")]
                [System.Text.Json.Serialization.JsonPropertyName("vintage")]
                public string Vintage { get; set; } = default!;

                /// <summary>
                /// 获取或设置品类名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_name")]
                [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                public string CategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置品牌名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_name")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_name")]
                public string BrandName { get; set; } = default!;

                /// <summary>
                /// 获取或设置系列名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("series_name")]
                [System.Text.Json.Serialization.JsonPropertyName("series_name")]
                public string SeriesName { get; set; } = default!;

                /// <summary>
                /// 获取或设置型号名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("model_name")]
                [System.Text.Json.Serialization.JsonPropertyName("model_name")]
                public string ModelName { get; set; } = default!;

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notes")]
                [System.Text.Json.Serialization.JsonPropertyName("notes")]
                public string? Notes { get; set; }

                /// <summary>
                /// 获取或设置物流单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logistics_code")]
                [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
                public string? LogisticsNumber { get; set; }

                /// <summary>
                /// 获取或设置寄出方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sent_way")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? SendWay { get; set; }

                /// <summary>
                /// 获取或设置寄出时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sent_time")]
                [System.Text.Json.Serialization.JsonPropertyName("sent_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? SendTimestamp { get; set; }

                /// <summary>
                /// 获取或设置经过加密的收件人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypt_shop_name")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypt_shop_name")]
                public string? EncryptedShopName { get; set; }

                /// <summary>
                /// 获取或设置经过加密的收件人地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypt_shop_address")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypt_shop_address")]
                public string? EncryptedShopAddress { get; set; }

                /// <summary>
                /// 获取或设置经过加密的收件人电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypt_shop_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypt_shop_phone")]
                public string? EncryptedShopPhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置经过加密的发件人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypt_user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypt_user_name")]
                public string? EncryptedUserName { get; set; }

                /// <summary>
                /// 获取或设置经过加密的发件人地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypt_user_address")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypt_user_address")]
                public string? EncryptedUserAddress { get; set; }

                /// <summary>
                /// 获取或设置经过加密的发件人电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypt_user_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypt_user_phone")]
                public string? EncryptedUserPhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置订单关闭时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("close_time")]
                [System.Text.Json.Serialization.JsonPropertyName("close_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? CloseTimestamp { get; set; }

                /// <summary>
                /// 获取或设置估价时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price_create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("price_create_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? PriceCreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置估价确认时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price_confirm_time")]
                [System.Text.Json.Serialization.JsonPropertyName("price_confirm_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? PriceConfirmTimestamp { get; set; }

                /// <summary>
                /// 获取或设置回收价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recycle_price")]
                [System.Text.Json.Serialization.JsonPropertyName("recycle_price")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? RecryclePrice { get; set; }

                /// <summary>
                /// 获取或设置平台服务费（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recycle_commission")]
                [System.Text.Json.Serialization.JsonPropertyName("recycle_commission")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? RecrycleCommission { get; set; }

                /// <summary>
                /// 获取或设置寄卖价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consignment_price")]
                [System.Text.Json.Serialization.JsonPropertyName("consignment_price")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? ConsignmentPrice { get; set; }

                /// <summary>
                /// 获取或设置商家服务费（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consignment_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("consignment_fee")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? ConsignmentFee { get; set; }

                /// <summary>
                /// 获取或设置平台服务费（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consignment_commission")]
                [System.Text.Json.Serialization.JsonPropertyName("consignment_commission")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? ConsignmentCommission { get; set; }

                /// <summary>
                /// 获取或设置寄售周期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consignment_period")]
                [System.Text.Json.Serialization.JsonPropertyName("consignment_period")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? ConsignmentPeriod { get; set; }

                /// <summary>
                /// 获取或设置寄售开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_consignment_time")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_consignment_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? ConsignmentTimstamp { get; set; }

                /// <summary>
                /// 获取或设置成交类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("knockdown_type")]
                [System.Text.Json.Serialization.JsonPropertyName("knockdown_type")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? KnockdownType { get; set; }

                /// <summary>
                /// 获取或设置成交时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("knockdown_time")]
                [System.Text.Json.Serialization.JsonPropertyName("knockdown_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? KnockdownTimestamp { get; set; }

                /// <summary>
                /// 获取或设置终止时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("termination_time")]
                [System.Text.Json.Serialization.JsonPropertyName("termination_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? TerminationTimestamp { get; set; }

                /// <summary>
                /// 获取或设置终止方。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("termination_side")]
                [System.Text.Json.Serialization.JsonPropertyName("termination_side")]
                public string? TerminationSide { get; set; }

                /// <summary>
                /// 获取或设置终止原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("termination_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("termination_reason")]
                public string? TerminationReason { get; set; }

                /// <summary>
                /// 获取或设置退件物流单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reverse_logistics_code")]
                [System.Text.Json.Serialization.JsonPropertyName("reverse_logistics_code")]
                public string? ReverseLogisticsNumber { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long UpdateTimestamp { get; set; }
            }
        }
    }
}
