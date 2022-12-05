using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /btas/saveInspectionOnline 接口的请求。</para>
    /// </summary>
    public class BTASSaveInspectionOnlineRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Image
            {
                /// <summary>
                /// 获取或设置图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_id")]
                [System.Text.Json.Serialization.JsonPropertyName("image_id")]
                public int ImageId { get; set; }

                /// <summary>
                /// 获取或设置图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_url")]
                [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                public string ImageUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图片备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_comment")]
                [System.Text.Json.Serialization.JsonPropertyName("image_comment")]
                public string? ImageComment { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_order_id")]
        public string ProductOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_code")]
        [System.Text.Json.Serialization.JsonPropertyName("order_code")]
        public string OrderCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_status")]
        [System.Text.Json.Serialization.JsonPropertyName("service_status")]
        public int ServiceStatus { get; set; }

        /// <summary>
        /// 获取或设置鉴定品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public int BrandId { get; set; }

        /// <summary>
        /// 获取或设置质检扣。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certification_code")]
        [System.Text.Json.Serialization.JsonPropertyName("certification_code")]
        public string CertificationCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置原盒包装类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_original_info")]
        [System.Text.Json.Serialization.JsonPropertyName("is_original_info")]
        public int OriginalType { get; set; }

        /// <summary>
        /// 获取或设置优先类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_intercept_type")]
        [System.Text.Json.Serialization.JsonPropertyName("return_intercept_type")]
        public int ReturnInterceptType { get; set; }

        /// <summary>
        /// 获取或设置送检图片列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images")]
        [System.Text.Json.Serialization.JsonPropertyName("images")]
        public IList<Types.Image> ImageList { get; set; } = new List<Types.Image>();
    }
}
