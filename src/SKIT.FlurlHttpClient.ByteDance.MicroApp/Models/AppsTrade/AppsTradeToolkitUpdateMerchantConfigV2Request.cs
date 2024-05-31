namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/toolkit/update_merchant_conf 接口的请求。</para>
    /// </summary>
    public class AppsTradeToolkitUpdateMerchantConfigV2Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class DeliveryAppInfo
            {
                /// <summary>
                /// 获取或设置引导文案 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guidance_text_id")]
                [System.Text.Json.Serialization.JsonPropertyName("guidance_text_id")]
                public string? GuidanceTextId { get; set; }

                /// <summary>
                /// 获取或设置核销预约按钮文案 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("button_text_id")]
                [System.Text.Json.Serialization.JsonPropertyName("button_text_id")]
                public string? ButtonTextId { get; set; }

                /// <summary>
                /// 获取或设置详情页按钮文案 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_page_text_id")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_page_text_id")]
                public string? DetailPageTextId { get; set; }

                /// <summary>
                /// 获取或设置二维码展示方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("display_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("display_mode")]
                public int? DisplayMode { get; set; }
            }

            public class ProductDoubleOpenInfo
            {
                /// <summary>
                /// 获取或设置引导文案 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guidance_text_id")]
                [System.Text.Json.Serialization.JsonPropertyName("guidance_text_id")]
                public string? GuidanceTextId { get; set; }

                /// <summary>
                /// 获取或设置到店按钮文案 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("arrival_store_button_text_id")]
                [System.Text.Json.Serialization.JsonPropertyName("arrival_store_button_text_id")]
                public string? ArrivalStoreButtonTextId { get; set; }

                /// <summary>
                /// 获取或设置到家按钮文案 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("arrival_home_button_text_id")]
                [System.Text.Json.Serialization.JsonPropertyName("arrival_home_button_text_id")]
                public string? ArrivalHomeButtonTextId { get; set; }

                /// <summary>
                /// 获取或设置二维码展示方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("display_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("display_mode")]
                public int? DisplayMode { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置绑定的小程序类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_biz_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_biz_type")]
        public int BindBusinessType { get; set; }

        /// <summary>
        /// 获取或设置商家团购账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_id")]
        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置核销工具相关信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_app_info")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_app_info")]
        public Types.DeliveryAppInfo? DeliveryAppInfo { get; set; }

        /// <summary>
        /// 获取或设置混合双开相关信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_double_open_info")]
        [System.Text.Json.Serialization.JsonPropertyName("product_double_open_info")]
        public Types.ProductDoubleOpenInfo? ProductDoubleOpenInfo { get; set; }
    }
}
