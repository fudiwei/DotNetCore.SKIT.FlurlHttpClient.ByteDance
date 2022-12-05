using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/newCreateOrder 接口的请求。</para>
    /// </summary>
    public class LogisticsNewCreateOrderRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Contact
            {
                /// <summary>
                /// 获取或设置姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置固定电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                public string? TeleNumber { get; set; }

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                public string? MobileNumber { get; set; }
            }

            public class Address
            {
                /// <summary>
                /// 获取或设置国家编码。
                /// <para>默认值：CHN</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("country_code")]
                [System.Text.Json.Serialization.JsonPropertyName("country_code")]
                public string CountryCode { get; set; } = "CHN";

                /// <summary>
                /// 获取或设置省份名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_name")]
                [System.Text.Json.Serialization.JsonPropertyName("province_name")]
                public string ProvinceName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置城市名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city_name")]
                [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                public string CityName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置区县名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("district_name")]
                [System.Text.Json.Serialization.JsonPropertyName("district_name")]
                public string DistrictName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置街道名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("street_name")]
                [System.Text.Json.Serialization.JsonPropertyName("street_name")]
                public string? StreetName { get; set; }

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_address")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_address")]
                public string Detail { get; set; } = string.Empty;
            }

            public class Sender
            {
                /// <summary>
                /// 获取或设置联系方式信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact")]
                [System.Text.Json.Serialization.JsonPropertyName("contact")]
                public Contact Contact { get; set; } = new Contact();

                /// <summary>
                /// 获取或设置收货地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public Address Address { get; set; } = new Address();
            }

            public class Receiver : Sender
            {
            }

            public class Order
            {
                public static class Types
                {
                    public class Service
                    {
                        /// <summary>
                        /// 获取或设置增值服务编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_code")]
                        public string ServiceCode { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置增值服务值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_value")]
                        public string ServiceValue { get; set; } = string.Empty;
                    }

                    public class Item
                    {
                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品规格。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_specs")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_specs")]
                        public string? Specification { get; set; }

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_count")]
                        public int Count { get; set; }

                        /// <summary>
                        /// 获取或设置单件体积（单位：立方厘米）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_volume")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_volume")]
                        public int? Volume { get; set; }

                        /// <summary>
                        /// 获取或设置单件重量（单位：克）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_weight")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_weight")]
                        public int? Weight { get; set; }

                        /// <summary>
                        /// 获取或设置单件净重（单位：克）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_net_weight")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_net_weight")]
                        public int? NetWeight { get; set; }
                    }

                    public class Warehouse
                    {
                        /// <summary>
                        /// 获取或设置仓库编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wh_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("wh_code")]
                        public string? WarehouseCode { get; set; }

                        /// <summary>
                        /// 获取或设置仓库订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wh_order_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("wh_order_no")]
                        public string? WarehouseOrderNumber { get; set; }

                        /// <summary>
                        /// 获取或设置是否总对总门店发货。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_sum_up")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_sum_up")]
                        public bool? IsSumUp { get; set; }

                        /// <summary>
                        /// 获取或设置发货。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_type")]
                        public int? DeliveryType { get; set; }
                    }

                    public class NetSite
                    {
                        /// <summary>
                        /// 获取或设置物流服务商类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category")]
                        [System.Text.Json.Serialization.JsonPropertyName("category")]
                        public string? Category { get; set; }

                        /// <summary>
                        /// 获取或设置网点编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("net_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("net_code")]
                        public string? NetSiteCode { get; set; }

                        /// <summary>
                        /// 获取或设置总对总账号或月结账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("monthly_account")]
                        [System.Text.Json.Serialization.JsonPropertyName("monthly_account")]
                        public string? MonthlyStatementAccount { get; set; }

                        /// <summary>
                        /// 获取或设置总对总密码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("secret_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("secret_key")]
                        public string? SecretKey { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置包裹 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pack_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pack_id")]
                public string? PackageId { get; set; }

                /// <summary>
                /// 获取或设置快递产品类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_type")]
                [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                public int? ProductType { get; set; }

                /// <summary>
                /// 获取或设置增值服务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_list")]
                [System.Text.Json.Serialization.JsonPropertyName("service_list")]
                public IList<Types.Service>? ServiceList { get; set; }

                /// <summary>
                /// 获取或设置支付方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_method")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_method")]
                public int? PayMethod { get; set; }

                /// <summary>
                /// 获取或设置运费金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                public int? PayAmount { get; set; }

                /// <summary>
                /// 获取或设置回单寄回地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pod_model_address")]
                [System.Text.Json.Serialization.JsonPropertyName("pod_model_address")]
                public Address? PodModelAddress { get; set; }

                /// <summary>
                /// 获取或设置收件人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_info")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_info")]
                public Receiver Receiver { get; set; } = new Receiver();

                /// <summary>
                /// 获取或设置商品明细列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public IList<Types.Item>? ItemList { get; set; }

                /// <summary>
                /// 获取或设置要求上门取件时间段。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sender_fetch_time")]
                [System.Text.Json.Serialization.JsonPropertyName("sender_fetch_time")]
                public string? SenderFetchTimeRange { get; set; }

                /// <summary>
                /// 获取或设置是否返回签回单。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_sign_back")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_sign_back")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsSignBack { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置备用扩展字段。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extra")]
                [System.Text.Json.Serialization.JsonPropertyName("extra")]
                public string? Extra { get; set; }

                /// <summary>
                /// 获取或设置子母件数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_pack_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_pack_count")]
                public int? TotalPackageCount { get; set; }

                /// <summary>
                /// 获取或设置总长度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_length")]
                [System.Text.Json.Serialization.JsonPropertyName("total_length")]
                public int? TotalLength { get; set; }

                /// <summary>
                /// 获取或设置总宽度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_width")]
                [System.Text.Json.Serialization.JsonPropertyName("total_width")]
                public int? TotalWidth { get; set; }

                /// <summary>
                /// 获取或设置总高度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_height")]
                [System.Text.Json.Serialization.JsonPropertyName("total_height")]
                public int? TotalHeight { get; set; }

                /// <summary>
                /// 获取或设置总体积（单位：立方厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("volume")]
                [System.Text.Json.Serialization.JsonPropertyName("volume")]
                public int? TotalVolume { get; set; }

                /// <summary>
                /// 获取或设置总重量（单位：克）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_weight")]
                [System.Text.Json.Serialization.JsonPropertyName("total_weight")]
                public int? TotalWeight { get; set; }

                /// <summary>
                /// 获取或设置仓库信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warehouse")]
                [System.Text.Json.Serialization.JsonPropertyName("warehouse")]
                public Types.Warehouse? Warehouse { get; set; }

                /// <summary>
                /// 获取或设置网点信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("net_info")]
                [System.Text.Json.Serialization.JsonPropertyName("net_info")]
                public Types.NetSite? NetSite { get; set; }

                /// <summary>
                /// 获取或设置物料码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_code")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_code")]
                public string? ShippingCode { get; set; }
            }

            public class DeliveryRequest
            {
                /// <summary>
                /// 获取或设置是否接受仅镇中心派送。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_center_delivery")]
                [System.Text.Json.Serialization.JsonPropertyName("is_center_delivery")]
                public bool? IsCenterDelivery { get; set; }

                /// <summary>
                /// 获取或设置是否合伙人自提。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_pickup_self")]
                [System.Text.Json.Serialization.JsonPropertyName("is_pickup_self")]
                public bool? IsPickupSelf { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置快递公司编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_code")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
        public string LogisticsCompanyCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置寄件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender_info")]
        [System.Text.Json.Serialization.JsonPropertyName("sender_info")]
        public Types.Sender Sender { get; set; } = new Types.Sender();

        /// <summary>
        /// 获取或设置代打订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("order_infos")]
        public IList<Types.Order> OrderList { get; set; } = new List<Types.Order>();

        /// <summary>
        /// 获取或设置派送要求信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_req")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_req")]
        public Types.DeliveryRequest? DeliveryRequest { get; set; }

        /// <summary>
        /// 获取或设置渠道来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_channel")]
        [System.Text.Json.Serialization.JsonPropertyName("order_channel")]
        public string? OrderChannel { get; set; }

        /// <summary>
        /// 获取或设置用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public long? UserId { get; set; }
    }
}
