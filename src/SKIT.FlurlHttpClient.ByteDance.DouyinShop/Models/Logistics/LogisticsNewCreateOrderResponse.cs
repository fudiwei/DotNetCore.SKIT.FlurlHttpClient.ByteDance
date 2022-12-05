namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/newCreateOrder 接口的响应。</para>
    /// </summary>
    public class LogisticsNewCreateOrderResponse : DouyinShopResponse<LogisticsNewCreateOrderResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class EBill
                    {
                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置包裹 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pack_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pack_id")]
                        public string PackageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置快递单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("track_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("track_no")]
                        public string LogisticsNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分拣码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sort_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("sort_code")]
                        public string? SortCode { get; set; }

                        /// <summary>
                        /// 获取或设置集包地代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("package_center_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("package_center_code")]
                        public string? PackageCenterCode { get; set; }

                        /// <summary>
                        /// 获取或设置集包地名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("package_center_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("package_center_name")]
                        public string? PackageCenterName { get; set; }

                        /// <summary>
                        /// 获取或设置大头笔编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("short_address_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("short_address_code")]
                        public string? ShortAddressCode { get; set; }

                        /// <summary>
                        /// 获取或设置大头笔名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("short_address_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("short_address_name")]
                        public string? ShortAddressName { get; set; }

                        /// <summary>
                        /// 获取或设置额外打印信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("extra_resp")]
                        [System.Text.Json.Serialization.JsonPropertyName("extra_resp")]
                        public string? ExtraResponse { get; set; }

                        /// <summary>
                        /// 获取或设置子母件单号列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_waybill_codes")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_waybill_codes")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringArrayWithCommaSplitConverter))]
                        public string[]? SubWaybillCodes { get; set; }

                        /// <summary>
                        /// 获取或设置渠道来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_channel")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_channel")]
                        public string? OrderChannel { get; set; }

                        /// <summary>
                        /// 获取或设置寄件码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_code")]
                        public string? ShippingCode { get; set; }
                    }

                    public class Error
                    {
                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置包裹 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pack_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pack_id")]
                        public string PackageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("err_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("err_code")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int ErrorCode { get; set; }

                        /// <summary>
                        /// 获取或设置错误信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("err_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
                        public string ErrorMessage { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置渠道来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_channel")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_channel")]
                        public string? OrderChannel { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置电子面单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ebill_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("ebill_infos")]
                public Types.EBill[]? EBillList { get; set; }

                /// <summary>
                /// 获取或设置错误列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("err_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("err_infos")]
                public Types.Error[]? ErrorList { get; set; }
            }
        }
    }
}
