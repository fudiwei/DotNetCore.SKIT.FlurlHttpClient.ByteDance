namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/invoiceList 接口的响应。</para>
    /// </summary>
    public class OrderInvoiceListResponse : TikTokShopResponse<OrderInvoiceListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Invoice
                    {
                        /// <summary>
                        /// 获取或设置开票 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("registation_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("registation_id")]
                        public string RegistationId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                        public int ShopId { get; set; }

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                        public int OrderStatus { get; set; }

                        /// <summary>
                        /// 获取或设置发票种类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("invoice_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("invoice_type")]
                        public int InvoiceType { get; set; }

                        /// <summary>
                        /// 获取或设置申请创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("apply_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("apply_time")]
                        public long ApplyTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置抬头类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("title_type")]
                        public int TitleType { get; set; }

                        /// <summary>
                        /// 获取或设置抬头。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置税号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tax_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("tax_no")]
                        public string TaxNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置开户行名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bank_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                        public string BankName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置开户行编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bank_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("bank_no")]
                        public string BankNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置企业地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company_address")]
                        [System.Text.Json.Serialization.JsonPropertyName("company_address")]
                        public string CompanyAddress { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置企业电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company_mobile")]
                        [System.Text.Json.Serialization.JsonPropertyName("company_mobile")]
                        public string CompanyPhoneNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置可开票金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("invoice_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("invoice_amount")]
                        public int InvoiceAmount { get; set; }

                        /// <summary>
                        /// 获取或设置开票详情。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("invoice_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("invoice_detail")]
                        public string InvoiceDetail { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置开票状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("invoice_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("invoice_status")]
                        public int InvoiceStatus { get; set; }

                        /// <summary>
                        /// 获取或设置关闭原因枚举。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_reason")]
                        public int EndReasonType { get; set; }

                        /// <summary>
                        /// 获取或设置关闭时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long? EndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置发票 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tos_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("tos_url")]
                        public string? FileUrl { get; set; }

                        /// <summary>
                        /// 获取或设置发票名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("file_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("file_name")]
                        public string? FileName { get; set; }

                        /// <summary>
                        /// 获取或设置首次发票上传时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("upload_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("upload_time")]
                        public long? FirstUploadTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置最新发票上传时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("latest_upload_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("latest_upload_time")]
                        public long? LatestUploadTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置发票列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invoice_list")]
                [System.Text.Json.Serialization.JsonPropertyName("invoice_list")]
                public Types.Invoice[] InvoiceList { get; set; } = default!;

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
