using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /crossBorder/stockTaking 接口的请求。</para>
    /// </summary>
    public class CrossBorderStockTakingRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Detail
            {
                /// <summary>
                /// 获取或设置货品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_code")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_code")]
                public string CargoCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置质量等级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quality_grade")]
                [System.Text.Json.Serialization.JsonPropertyName("quality_grade")]
                public int QualityGrade { get; set; }

                /// <summary>
                /// 获取或设置数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quantity")]
                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                public int Quantity { get; set; }

                /// <summary>
                /// 获取或设置盘点原因编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason_code")]
                [System.Text.Json.Serialization.JsonPropertyName("reason_code")]
                public int ReasonCode { get; set; }

                /// <summary>
                /// 获取或设置盘点具体原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("reason_msg")]
                public string? ReasonMessage { get; set; }

                /// <summary>
                /// 获取或设置扩展信息字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extend")]
                [System.Text.Json.Serialization.JsonPropertyName("extend")]
                public IDictionary<string, string>? Extra { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务商编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendor")]
        [System.Text.Json.Serialization.JsonPropertyName("vendor")]
        public string VendorCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置仓库编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_code")]
        [System.Text.Json.Serialization.JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
        public int? ShopId { get; set; }

        /// <summary>
        /// 获取或设置盘点类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taking_type")]
        [System.Text.Json.Serialization.JsonPropertyName("taking_type")]
        public int TakingType { get; set; }

        /// <summary>
        /// 获取或设置盘点完成时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("occurrence_time")]
        [System.Text.Json.Serialization.JsonPropertyName("occurrence_time")]
        public long OccurrenceTimestamp { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置盘点明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_taking_details")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_taking_details")]
        public IList<Types.Detail> DetailList { get; set; } = new List<Types.Detail>();
    }
}
