namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/searchList 接口的响应。</para>
    /// </summary>
    public class OrderSearchListResponse : TikTokShopResponse<OrderSearchListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public abstract class OrderBase
                    {
                        public static class Types
                        {
                            public class PostAddress
                            {
                                public static class Types
                                {
                                    public class Area
                                    {
                                        /// <summary>
                                        /// 获取或设置地区 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                                        public int Id { get; set; }

                                        /// <summary>
                                        /// 获取或设置地区名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string Name { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置省份信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("province")]
                                [System.Text.Json.Serialization.JsonPropertyName("province")]
                                public Types.Area Province { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置城市信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city")]
                                [System.Text.Json.Serialization.JsonPropertyName("city")]
                                public Types.Area City { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置区县信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("town")]
                                [System.Text.Json.Serialization.JsonPropertyName("town")]
                                public Types.Area District { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置街道信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("street")]
                                [System.Text.Json.Serialization.JsonPropertyName("street")]
                                public Types.Area? Street { get; set; }

                                /// <summary>
                                /// 获取或设置经过加密的详细地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("encrypt_detail")]
                                [System.Text.Json.Serialization.JsonPropertyName("encrypt_detail")]
                                public string EncryptedDetail { get; set; } = default!;
                            }

                            public class PromotionDetail
                            {
                                public static class Types
                                {
                                    public class DiscountDetail
                                    {
                                        public static class Types
                                        {
                                            public class Coupon
                                            {
                                                public static class Types
                                                {
                                                    public class ShareDiscountCost
                                                    {
                                                        /// <summary>
                                                        /// 获取或设置平台承担金额（单位：分）。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("platform_cost")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("platform_cost")]
                                                        public int PlatformCost { get; set; }

                                                        /// <summary>
                                                        /// 获取或设置商家承担金额（单位：分）。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("shop_cost")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("shop_cost")]
                                                        public int ShopCost { get; set; }
                                                    }
                                                }

                                                /// <summary>
                                                /// 获取或设置优惠券 ID。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("coupon_id")]
                                                [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                                                public long CouponId { get; set; }

                                                /// <summary>
                                                /// 获取或设置优惠券类型。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("coupon_type")]
                                                [System.Text.Json.Serialization.JsonPropertyName("coupon_type")]
                                                public int CouponType { get; set; }

                                                /// <summary>
                                                /// 获取或设置券批次 ID。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("coupon_meta_id")]
                                                [System.Text.Json.Serialization.JsonPropertyName("coupon_meta_id")]
                                                public string CouponMetaId { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置优惠金额（单位：分）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("coupon_amount")]
                                                [System.Text.Json.Serialization.JsonPropertyName("coupon_amount")]
                                                public int CouponAmount { get; set; }

                                                /// <summary>
                                                /// 获取或设置券名称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("coupon_name")]
                                                [System.Text.Json.Serialization.JsonPropertyName("coupon_name")]
                                                public string CouponName { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置成本分摊信息。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("share_discount_cost")]
                                                [System.Text.Json.Serialization.JsonPropertyName("share_discount_cost")]
                                                public Types.ShareDiscountCost? ShareDiscountCost { get; set; }
                                            }

                                            public class FullDiscount
                                            {
                                                public static class Types
                                                {
                                                    public class ShareDiscountCost : Coupon.Types.ShareDiscountCost
                                                    {
                                                    }
                                                }

                                                /// <summary>
                                                /// 获取或设置活动 ID。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("campaign_id")]
                                                [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
                                                public long CampaignId { get; set; }

                                                /// <summary>
                                                /// 获取或设置活动类型。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("campaign_type")]
                                                [System.Text.Json.Serialization.JsonPropertyName("campaign_type")]
                                                public int CampaignType { get; set; }

                                                /// <summary>
                                                /// 获取或设置活动子类型。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("campaign_sub_type")]
                                                [System.Text.Json.Serialization.JsonPropertyName("campaign_sub_type")]
                                                public int CampaignSubType { get; set; }

                                                /// <summary>
                                                /// 获取或设置活动金额（单位：分）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("campaign_amount")]
                                                [System.Text.Json.Serialization.JsonPropertyName("campaign_amount")]
                                                public int CampaignAmount { get; set; }

                                                /// <summary>
                                                /// 获取或设置活动名称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("campaign_name")]
                                                [System.Text.Json.Serialization.JsonPropertyName("campaign_name")]
                                                public string CampaignName { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置成本分摊信息。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("share_discount_cost")]
                                                [System.Text.Json.Serialization.JsonPropertyName("share_discount_cost")]
                                                public Types.ShareDiscountCost? ShareDiscountCost { get; set; }
                                            }

                                            public class Redpack
                                            {
                                                /// <summary>
                                                /// 获取或设置红包汇总 ID。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("redpack_trans_id")]
                                                [System.Text.Json.Serialization.JsonPropertyName("redpack_trans_id")]
                                                public string RedpackTransferId { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置红包金额（单位：分）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("redpack_amount")]
                                                [System.Text.Json.Serialization.JsonPropertyName("redpack_amount")]
                                                public int RedpackAmount { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置优惠总金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("total_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                                        public int TotalAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置券优惠金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("coupon_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("coupon_amount")]
                                        public int CouponAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置活动优惠金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("full_discount_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("full_discount_amount")]
                                        public int FullDiscountAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置红包金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("redpack_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("redpack_amount")]
                                        public int RedpackAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置优惠券列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("coupon_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("coupon_info")]
                                        public Types.Coupon[]? CouponList { get; set; }

                                        /// <summary>
                                        /// 获取或设置优惠活动列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("full_discount_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("full_discount_info")]
                                        public Types.FullDiscount[]? FullDiscountList { get; set; }

                                        /// <summary>
                                        /// 获取或设置红包列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("redpack_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("redpack_info")]
                                        public Types.Redpack[]? RedpackList { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置店铺优惠信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shop_discount_detail")]
                                [System.Text.Json.Serialization.JsonPropertyName("shop_discount_detail")]
                                public Types.DiscountDetail? ShopDiscountDetail { get; set; }

                                /// <summary>
                                /// 获取或设置平台优惠信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_discount_detail")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_discount_detail")]
                                public Types.DiscountDetail? PlatformDiscountDetail { get; set; }

                                /// <summary>
                                /// 获取或设置达人优惠信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("kol_discount_detail")]
                                [System.Text.Json.Serialization.JsonPropertyName("kol_discount_detail")]
                                public Types.DiscountDetail? KOLDiscountDetail { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置字节小程序的 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单层级。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_level")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_level")]
                        public int OrderLevel { get; set; }

                        /// <summary>
                        /// 获取或设置业务来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("biz")]
                        [System.Text.Json.Serialization.JsonPropertyName("biz")]
                        public int BusinessType { get; set; }

                        /// <summary>
                        /// 获取或设置业务来源描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("biz_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("biz_desc")]
                        public string BusinessTypeDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
                        public int OrderType { get; set; }

                        /// <summary>
                        /// 获取或设置订单类型描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_type_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_type_desc")]
                        public string OrderTypeDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置交易类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trade_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
                        public int TradeType { get; set; }

                        /// <summary>
                        /// 获取或设置交易类型描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trade_type_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("trade_type_desc")]
                        public string TradeTypeDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                        public int OrderStatus { get; set; }

                        /// <summary>
                        /// 获取或设置订单状态描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_status_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_status_desc")]
                        public string OrderStatusDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置主流程状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("main_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("main_status")]
                        public int MainStatus { get; set; }

                        /// <summary>
                        /// 获取或设置主流程状态描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("main_status_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("main_status_desc")]
                        public string MainStatusDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置下单端类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("b_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("b_type")]
                        public int BillType { get; set; }

                        /// <summary>
                        /// 获取或设置下单端描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("b_type_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("b_type_desc")]
                        public string BillTypeDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置下单场景。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_b_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_b_type")]
                        public int? SubBillType { get; set; }

                        /// <summary>
                        /// 获取或设置下单场景描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_b_type_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_b_type_desc")]
                        public string? SubBillTypeDescription { get; set; }

                        /// <summary>
                        /// 获取或设置订单过期时间（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_expire_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_expire_time")]
                        public int OrderExpireTime { get; set; }

                        /// <summary>
                        /// 获取或设置支付时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                        public long? PayTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置完成时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finish_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("finish_time")]
                        public long? FinishTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置下单时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置取消原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason")]
                        public string? CancelReason { get; set; }

                        /// <summary>
                        /// 获取或设置支付类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
                        public int PayType { get; set; }

                        /// <summary>
                        /// 获取或设置渠道支付订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("channel_payment_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("channel_payment_no")]
                        public string? ChannelPaymentNumber { get; set; }

                        /// <summary>
                        /// 获取或设置订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_amount")]
                        public int OrderAmount { get; set; }

                        /// <summary>
                        /// 获取或设置支付金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                        public int PayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置快递费金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("post_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("post_amount")]
                        public int PostAmount { get; set; }

                        /// <summary>
                        /// 获取或设置快递费原价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("post_origin_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("post_origin_amount")]
                        public int PostOriginAmount { get; set; }

                        /// <summary>
                        /// 获取或设置快递费优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("post_promotion_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("post_promotion_amount")]
                        public int PostPromotionAmount { get; set; }

                        /// <summary>
                        /// 获取或设置运费险金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("post_insurance_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("post_insurance_amount")]
                        public int PostInsuranceAmount { get; set; }

                        /// <summary>
                        /// 获取或设置改价金额变化量（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("modify_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("modify_amount")]
                        public int ModifyAmount { get; set; }

                        /// <summary>
                        /// 获取或设置改价运费金额变化量（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("modify_post_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("modify_post_amount")]
                        public int ModifyPostAmount { get; set; }

                        /// <summary>
                        /// 获取或设置订单优惠总金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_amount")]
                        public int PromotionAmount { get; set; }

                        /// <summary>
                        /// 获取或设置订单优惠详细信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_detail")]
                        public Types.PromotionDetail? PromotionDetail { get; set; }

                        /// <summary>
                        /// 获取或设置店铺优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_shop_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_shop_amount")]
                        public int PromotionShopAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_platform_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_platform_amount")]
                        public int PromotionPlatformAmount { get; set; }

                        /// <summary>
                        /// 获取或设置订单优惠商家承担部分金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_cost_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_cost_amount")]
                        public int ShopCostAmount { get; set; }

                        /// <summary>
                        /// 获取或设置订单优惠平台承担部分金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_cost_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_cost_amount")]
                        public int PlatformCostAmount { get; set; }

                        /// <summary>
                        /// 获取或设置达人优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_talent_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_talent_amount")]
                        public int PromotionTalentAmount { get; set; }

                        /// <summary>
                        /// 获取或设置支付优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_pay_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_pay_amount")]
                        public int PromotionPayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置经过加密的收件人电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("encrypt_post_tel")]
                        [System.Text.Json.Serialization.JsonPropertyName("encrypt_post_tel")]
                        public string? EncryptedPostPhoneNumber { get; set; }

                        /// <summary>
                        /// 获取或设置经过加密的收件人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("encrypt_post_receiver")]
                        [System.Text.Json.Serialization.JsonPropertyName("encrypt_post_receiver")]
                        public string? EncryptedPostReceiver { get; set; }

                        /// <summary>
                        /// 获取或设置收件人地址信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("post_addr")]
                        [System.Text.Json.Serialization.JsonPropertyName("post_addr")]
                        public Types.PostAddress? PostAddress { get; set; }

                        /// <summary>
                        /// 获取或设置预计发货时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exp_ship_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("exp_ship_time")]
                        public long? ExpectedShipTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置发货时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ship_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("ship_time")]
                        public long? ShipTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置红包优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_redpack_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_redpack_amount")]
                        public int PromotionRedpackAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台红包优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_redpack_platform_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_redpack_platform_amount")]
                        public int PromotionRedpackPlatformAmount { get; set; }

                        /// <summary>
                        /// 获取或设置达人红包优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_redpack_talent_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_redpack_talent_amount")]
                        public int PromotionRedpackTalentAmount { get; set; }
                    }

                    public class ShopOrder : OrderBase
                    {
                        public static new class Types
                        {
                            public class Logistics
                            {
                                public static class Types
                                {
                                    public class Product
                                    {
                                        public static class Types
                                        {
                                            public class Specification
                                            {
                                                /// <summary>
                                                /// 获取或设置规格名称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("name")]
                                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                                public string Name { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置规格值。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("value")]
                                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                                public string Value { get; set; } = default!;
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置商品 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("product_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                        public long ProductId { get; set; }

                                        /// <summary>
                                        /// 获取或设置商品 ID 字符串。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("product_id_str")]
                                        [System.Text.Json.Serialization.JsonPropertyName("product_id_str")]
                                        public string ProductIdString { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置商品名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("product_name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                        public string ProductName { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置商品数量。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("product_count")]
                                        [System.Text.Json.Serialization.JsonPropertyName("product_count")]
                                        public int ProductCount { get; set; }

                                        /// <summary>
                                        /// 获取或设置商家 SKU 编码。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("outer_sku_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("outer_sku_id")]
                                        public string OuterSKUId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置 SKU ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sku_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                        public long SKUId { get; set; }

                                        /// <summary>
                                        /// 获取或设置商品价格（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("price")]
                                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                                        public int Price { get; set; }

                                        /// <summary>
                                        /// 获取或设置规格列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sku_specs")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sku_specs")]
                                        public Types.Specification[] SpecificationList { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置商品单 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sku_order_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sku_order_id")]
                                        public string SKUOrderId { get; set; } = default!;
                                    }

                                    public class AddedService
                                    {
                                        /// <summary>
                                        /// 获取或设置标签 Key。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("key")]
                                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                                        public string Key { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置物流服务名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("text")]
                                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                                        public string Text { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置抖音大学介绍 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("help_doc")]
                                        [System.Text.Json.Serialization.JsonPropertyName("help_doc")]
                                        public string HelpDocumentationUrl { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置业务跳转 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("url")]
                                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                                        public string Url { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置物流单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tracking_no")]
                                [System.Text.Json.Serialization.JsonPropertyName("tracking_no")]
                                public string LogisticsNumber { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置物流公司。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("company")]
                                [System.Text.Json.Serialization.JsonPropertyName("company")]
                                public string Company { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置物流公司名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("company_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                                public string CompanyName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置发货时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ship_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("ship_time")]
                                public long? ShipTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置包裹单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                                public string? DeliveryId { get; set; }

                                /// <summary>
                                /// 获取或设置商品列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_info")]
                                public Types.Product[] ProductList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置增值服务列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("added_services")]
                                [System.Text.Json.Serialization.JsonPropertyName("added_services")]
                                public Types.AddedService[]? AddedServiceList { get; set; }
                            }

                            public class OrderPhase
                            {
                                /// <summary>
                                /// 获取或设置阶段单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phase_order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("phase_order_id")]
                                public string PhaseOpenId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置总阶段数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_phase")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_phase")]
                                public int TotalPhase { get; set; }

                                /// <summary>
                                /// 获取或设置当前阶段。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("current_phase")]
                                [System.Text.Json.Serialization.JsonPropertyName("current_phase")]
                                public int CurrentPhase { get; set; }

                                /// <summary>
                                /// 获取或设置阶段状态描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("current_phase_status_desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("current_phase_status_desc")]
                                public string CurrentPhaseStatusDescription { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置是否支付成功。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_success")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_success")]
                                public bool IsPaySucceessful { get; set; }

                                /// <summary>
                                /// 获取或设置商品单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_order_id")]
                                public string SKUOrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置活动 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("campaign_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
                                public long CampaignId { get; set; }

                                /// <summary>
                                /// 获取或设置阶段价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phase_payable_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("phase_payable_price")]
                                public int PhasePayablePrice { get; set; }

                                /// <summary>
                                /// 获取或设置阶段支付类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phase_pay_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("phase_pay_type")]
                                public int PhasePayType { get; set; }

                                /// <summary>
                                /// 获取或设置阶段开启支付时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phase_open_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("phase_open_time")]
                                public long PhaseOpenTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置阶段支付成功时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phase_pay_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("phase_pay_time")]
                                public long? PhasePayTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置阶段关闭时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phase_close_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("phase_close_time")]
                                public long? PhaseCloseTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置渠道支付订单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("channel_payment_no")]
                                [System.Text.Json.Serialization.JsonPropertyName("channel_payment_no")]
                                public string? ChannelPaymentNumber { get; set; }

                                /// <summary>
                                /// 获取或设置阶段单总金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phase_order_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("phase_order_amount")]
                                public int PhaseOrderAmount { get; set; }

                                /// <summary>
                                /// 获取或设置阶段单订单金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phase_sum_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("phase_sum_amount")]
                                public int PhaseSumAmount { get; set; }

                                /// <summary>
                                /// 获取或设置阶段单运费金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phase_post_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("phase_post_amount")]
                                public int PhasePostAmount { get; set; }

                                /// <summary>
                                /// 获取或设置阶段单实际支付金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phase_pay_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("phase_pay_amount")]
                                public int PhasePayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置阶段单总优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phase_promotion_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("phase_promotion_amount")]
                                public int PhasePromotionAmount { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 单价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_price")]
                                public int SKUPrice { get; set; }
                            }

                            public class UserIdentification
                            {
                                /// <summary>
                                /// 获取或设置经过加密的用户证件号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("encrypt_id_card_no")]
                                [System.Text.Json.Serialization.JsonPropertyName("encrypt_id_card_no")]
                                public string? EncryptedIdCardNumber { get; set; }

                                /// <summary>
                                /// 获取或设置经过加密的用户证件姓名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("encrypt_id_card_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("encrypt_id_card_name")]
                                public string? EncryptedIdCardName { get; set; }
                            }

                            public class ShopOrderTag
                            {
                                /// <summary>
                                /// 获取或设置标签 Key。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("key")]
                                [System.Text.Json.Serialization.JsonPropertyName("key")]
                                public string Key { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置标签说明。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text")]
                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                public string Text { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置帮助文档 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("help_doc")]
                                [System.Text.Json.Serialization.JsonPropertyName("help_doc")]
                                public string HelpDocumentationUrl { get; set; } = default!;
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
                        public string ShopName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                        public string OpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置买家留言。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_words")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_words")]
                        public string? BuyerWords { get; set; }

                        /// <summary>
                        /// 获取或设置卖家备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_words")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_words")]
                        public string? SellerWords { get; set; }

                        /// <summary>
                        /// 获取或设置预约发货时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appointment_ship_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("appointment_ship_time")]
                        public long? AppointmentShipTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置物流信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logistics_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("logistics_info")]
                        public Types.Logistics[] LogisticsList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_order_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_order_list")]
                        public SKUOrder[] SKUOrderList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置卖家订单标记。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_remark_stars")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_remark_stars")]
                        public int SellerRemarkStars { get; set; }

                        /// <summary>
                        /// 获取或设置用户加密串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("doudian_open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("doudian_open_id")]
                        public string DoudianOpenid { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品序列号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("serial_number_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("serial_number_list")]
                        public string[] SerialNumberList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置定金预售阶段单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_phase_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_phase_list")]
                        public Types.OrderPhase[]? OrderPhaseList { get; set; }

                        /// <summary>
                        /// 获取或设置用户证件信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_id_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_id_info")]
                        public Types.UserIdentification? UserIdentification { get; set; }

                        /// <summary>
                        /// 获取或设置店铺单标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_order_tag_ui")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_order_tag_ui")]
                        public Types.ShopOrderTag[]? ShopOrderTagList { get; set; }
                    }

                    public class SKUOrder : OrderBase
                    {
                        public static new class Types
                        {
                            public class SKUSpecification : ShopOrder.Types.Logistics.Types.Product.Types.Specification
                            {
                            }

                            public class Inventory
                            {
                                /// <summary>
                                /// 获取或设置仓库 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("warehouse_id")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableLongConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("warehouse_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                                public long WarehouseId { get; set; }

                                /// <summary>
                                /// 获取或设置外部仓库 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
                                public string OutWarehouseId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置库存类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("inventory_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("inventory_type")]
                                public int InventoryType { get; set; }

                                /// <summary>
                                /// 获取或设置库存类型描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("inventory_type_desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("inventory_type_desc")]
                                public string InventoryTypeDescription { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置库存变更数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("count")]
                                [System.Text.Json.Serialization.JsonPropertyName("count")]
                                public int Count { get; set; }
                            }

                            public class Aftersale
                            {
                                /// <summary>
                                /// 获取或设置售后状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("after_sale_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("after_sale_status")]
                                public int AftersaleStatus { get; set; }

                                /// <summary>
                                /// 获取或设置售后类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("after_sale_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("after_sale_type")]
                                public int AftersaleType { get; set; }

                                /// <summary>
                                /// 获取或设置退款状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_status")]
                                public int RefundStatus { get; set; }
                            }

                            public class AccountList
                            {
                                /// <summary>
                                /// 获取或设置账号列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("account_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("account_info")]
                                public AccountItem[] Items { get; set; } = default!;
                            }

                            public class AccountItem
                            {
                                /// <summary>
                                /// 获取或设置经过加密的账号 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("encrypt_account_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("encrypt_account_id")]
                                public string EncryptedAccountId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置账号名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("account_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                                public string AccountName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置账号类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("account_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int AccountType { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置店铺订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("parent_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("parent_order_id")]
                        public string ParentOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置流量来源类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("send_pay")]
                        [System.Text.Json.Serialization.JsonPropertyName("send_pay")]
                        public int SendPayType { get; set; }

                        /// <summary>
                        /// 获取或设置流量来源描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("send_pay_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("send_pay_desc")]
                        public string SendPayTypeDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置下单来源类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("theme_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("theme_type")]
                        public int? ThemeType { get; set; }

                        /// <summary>
                        /// 获取或设置下单来源来源描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("theme_type_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("theme_type_desc")]
                        public string? ThemeTypeDescription { get; set; }

                        /// <summary>
                        /// 获取或设置直播主播 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("author_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("author_id")]
                        public long? AuthorId { get; set; }

                        /// <summary>
                        /// 获取或设置直播主播名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("author_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("author_name")]
                        public string? AuthorName { get; set; }

                        /// <summary>
                        /// 获取或设置直播间 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("room_id")]
                        public long? RoomId { get; set; }

                        /// <summary>
                        /// 获取或设置内容 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("content_id")]
                        public long? ContetnId { get; set; }

                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                        public long? VideoId { get; set; }

                        /// <summary>
                        /// 获取或设置流量来源 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("origin_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("origin_id")]
                        public long? OriginId { get; set; }

                        /// <summary>
                        /// 获取或设置创意 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("cid")]
                        public long? CreativeId { get; set; }

                        /// <summary>
                        /// 获取或设置鲁班广告落地页 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("page_id")]
                        public long? PageId { get; set; }

                        /// <summary>
                        /// 获取或设置 C 端流量来源来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("c_biz")]
                        [System.Text.Json.Serialization.JsonPropertyName("c_biz")]
                        public int ConsumerBusinessType { get; set; }

                        /// <summary>
                        /// 获取或设置 C 端流量来源来源描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("c_biz_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("c_biz_desc")]
                        public string ConsumerBusinessTypeDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU Code。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string SKUCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置物流收货时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logistics_receipt_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("logistics_receipt_time")]
                        public long? LogisticsReceiptTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置用户确认收货时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("confirm_receipt_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("confirm_receipt_time")]
                        public long? ConfirmReceiptTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置商品类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_type")]
                        public int GoodsType { get; set; }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置外部商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_product_id")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableLongConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                        public long? OutProductId { get; set; }

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
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public long SKUId { get; set; }

                        /// <summary>
                        /// 获取或设置外部 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_sku_id")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableLongConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                        public long? OutSKUId { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 规格列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spec")]
                        [System.Text.Json.Serialization.JsonPropertyName("spec")]
                        public Types.SKUSpecification[] SKUSpecificationList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置一级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_cid")]
                        public int FirstCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置二级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_cid")]
                        public int SecondCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置三级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_cid")]
                        public int ThirdCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置四级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fourth_cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("fourth_cid")]
                        public int FourthCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置赠品绑定类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("given_product_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("given_product_type")]
                        public string? GivenProductType { get; set; }

                        /// <summary>
                        /// 获取或设置绑定的主品 SKU 单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("master_sku_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("master_sku_order_id")]
                        public string? MasterSKUOrderId { get; set; }

                        /// <summary>
                        /// 获取或设置供应商 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_id")]
                        public string? SupplierId { get; set; }

                        /// <summary>
                        /// 获取或设置库存扣减方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reduce_stock_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("reduce_stock_type")]
                        public int ReductStockType { get; set; }

                        /// <summary>
                        /// 获取或设置库存扣减方式描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reduce_stock_type_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("reduce_stock_type_desc")]
                        public string ReductStockTypeDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品现价。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("origin_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("origin_amount")]
                        public int OriginAmount { get; set; }

                        /// <summary>
                        /// 获取或设置是否包税。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("has_tax")]
                        [System.Text.Json.Serialization.JsonPropertyName("has_tax")]
                        public bool HasTax { get; set; }

                        /// <summary>
                        /// 获取或设置订单商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_num")]
                        public int ItemNumber { get; set; }

                        /// <summary>
                        /// 获取或设置商品现总价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sum_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("sum_amount")]
                        public int SumAmount { get; set; }

                        /// <summary>
                        /// 获取或设置商品来源平台。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("source_platform")]
                        [System.Text.Json.Serialization.JsonPropertyName("source_platform")]
                        public string? SourcePlatform { get; set; }

                        /// <summary>
                        /// 获取或设置评价类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_comment")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_comment")]
                        public int CommentType { get; set; }

                        /// <summary>
                        /// 获取或设置预售类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pre_sale_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("pre_sale_type")]
                        public int? PresellType { get; set; }

                        /// <summary>
                        /// 获取或设置邮寄类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receive_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("receive_type")]
                        public int? ReceiveType { get; set; }

                        /// <summary>
                        /// 获取或设置仓库列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("inventory_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("inventory_list")]
                        public Types.Inventory[]? InventoryList { get; set; }

                        /// <summary>
                        /// 获取或设置售后信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("after_sale_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("after_sale_info")]
                        public Types.Aftersale? Aftersale { get; set; }

                        /// <summary>
                        /// 获取或设置账号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_list")]
                        public Types.AccountList? AccountList { get; set; }

                        /// <summary>
                        /// 获取或设置广告来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_env_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_env_type")]
                        public string? AdEnvironmentType { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_order_list")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_order_list")]
                public Types.ShopOrder[] ShopOrderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置翻页页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page")]
                [System.Text.Json.Serialization.JsonPropertyName("page")]
                public int PageNumber { get; set; }

                /// <summary>
                /// 获取或设置翻页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size")]
                [System.Text.Json.Serialization.JsonPropertyName("size")]
                public int PageSize { get; set; }
            }
        }
    }
}
