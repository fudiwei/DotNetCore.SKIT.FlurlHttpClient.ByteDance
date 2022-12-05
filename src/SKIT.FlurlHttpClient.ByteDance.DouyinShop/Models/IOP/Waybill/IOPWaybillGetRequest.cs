using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/waybillGet 接口的请求。</para>
    /// </summary>
    public class IOPWaybillGetRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Sender
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
                        [Newtonsoft.Json.JsonProperty("countryCode")]
                        [System.Text.Json.Serialization.JsonPropertyName("countryCode")]
                        public string CountryCode { get; set; } = "CHN";

                        /// <summary>
                        /// 获取或设置省份 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("provinceCode")]
                        [System.Text.Json.Serialization.JsonPropertyName("provinceCode")]
                        public int? ProvinceId { get; set; }

                        /// <summary>
                        /// 获取或设置省份名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("provinceName")]
                        [System.Text.Json.Serialization.JsonPropertyName("provinceName")]
                        public string ProvinceName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置城市 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cityCode")]
                        [System.Text.Json.Serialization.JsonPropertyName("cityCode")]
                        public int? CityCode { get; set; }

                        /// <summary>
                        /// 获取或设置城市名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cityName")]
                        [System.Text.Json.Serialization.JsonPropertyName("cityName")]
                        public string CityName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置区县 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("districtCode")]
                        [System.Text.Json.Serialization.JsonPropertyName("districtCode")]
                        public int? DistrictId { get; set; }

                        /// <summary>
                        /// 获取或设置区县名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("districtName")]
                        [System.Text.Json.Serialization.JsonPropertyName("districtName")]
                        public string DistrictName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置街道 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("streetCode")]
                        [System.Text.Json.Serialization.JsonPropertyName("streetCode")]
                        public int? StreetId { get; set; }

                        /// <summary>
                        /// 获取或设置街道名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("streetName")]
                        [System.Text.Json.Serialization.JsonPropertyName("streetName")]
                        public string? StreetName { get; set; }

                        /// <summary>
                        /// 获取或设置详细地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detailAddress")]
                        [System.Text.Json.Serialization.JsonPropertyName("detailAddress")]
                        public string Detail { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置联系方式信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact")]
                [System.Text.Json.Serialization.JsonPropertyName("contact")]
                public Types.Contact Contact { get; set; } = new Types.Contact();

                /// <summary>
                /// 获取或设置地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public Types.Address Address { get; set; } = new Types.Address();
            }

            public class TradeOrder
            {
                public static class Types
                {
                    public class DistributeOrder
                    {
                        public static class Types
                        {
                            public class Service : LogisticsNewCreateOrderRequest.Types.Order.Types.Service
                            {
                            }

                            public class Item : LogisticsNewCreateOrderRequest.Types.Order.Types.Item
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置代打订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("distr_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("distr_order_id")]
                        public string DistributeOrderId { get; set; } = string.Empty;

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
                    }

                    public class DeliveryRequest : LogisticsNewCreateOrderRequest.Types.DeliveryRequest
                    {
                    }
                }

                /// <summary>
                /// 获取或设置代打店铺 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_id")]
                [System.Text.Json.Serialization.JsonPropertyName("user_id")]
                public long DistributeShopId { get; set; }

                /// <summary>
                /// 获取或设置代打订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("order_infos")]
                public IList<Types.DistributeOrder> DistributeOrderList { get; set; } = new List<Types.DistributeOrder>();

                /// <summary>
                /// 获取或设置派送要求信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_req")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_req")]
                public Types.DeliveryRequest? DeliveryRequest { get; set; }

                /// <summary>
                /// 获取或设置物流公司编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_code")]
                [System.Text.Json.Serialization.JsonPropertyName("company_code")]
                public string LogisticsCompanyCode { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置寄件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender")]
        [System.Text.Json.Serialization.JsonPropertyName("sender")]
        public Types.Sender Sender { get; set; } = new Types.Sender();

        /// <summary>
        /// 获取或设置取号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_order_list")]
        public IList<Types.TradeOrder> TradeOrderList { get; set; } = new List<Types.TradeOrder>();
    }
}
