using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /crossBorder/warehouseInOutboundEvent 接口的请求。</para>
    /// </summary>
    public class CrossBorderWarehouseInOutboundEventRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class TallyReport
            {
                /// <summary>
                /// 获取或设置附件 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置附件名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;
            }

            public class InboundCargo
            {
                /// <summary>
                /// 获取或设置货品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cargo_code")]
                [System.Text.Json.Serialization.JsonPropertyName("cargo_code")]
                public string CargoCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置实际上架数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actual_stack_count")]
                [System.Text.Json.Serialization.JsonPropertyName("actual_stack_count")]
                public int ActualStackCount { get; set; }

                /// <summary>
                /// 获取或设置良品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("good_cargo_count")]
                [System.Text.Json.Serialization.JsonPropertyName("good_cargo_count")]
                public int GoodCargoCount { get; set; }

                /// <summary>
                /// 获取或设置次品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("defective_cargo_count")]
                [System.Text.Json.Serialization.JsonPropertyName("defective_cargo_count")]
                public int DefectiveCargoCount { get; set; }

                /// <summary>
                /// 获取或设置调整原因编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expiry_date")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("expiry_date")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset ExpiryTime { get; set; }
            }


            public class OutboundCargo
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
                /// 获取或设置货品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quantity")]
                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                public int Quantity { get; set; }

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
        /// 获取或设置出入库事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("in_outbound_event_type")]
        [System.Text.Json.Serialization.JsonPropertyName("in_outbound_event_type")]
        public int InOutboundEventType { get; set; }

        /// <summary>
        /// 获取或设置来源单据号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("source_order_no")]
        public string SourceOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务商单据编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_order_no")]
        public string? VendorOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置库存类型变动时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("occurrence_time")]
        [System.Text.Json.Serialization.JsonPropertyName("occurrence_time")]
        public long OccurrenceTimestamp { get; set; }

        /// <summary>
        /// 获取或设置异常原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("error_reason")]
        public string? ErrorReason { get; set; }

        /// <summary>
        /// 获取或设置理货报告列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tally_report_url")]
        [System.Text.Json.Serialization.JsonPropertyName("tally_report_url")]
        public IList<Types.TallyReport>? TallyReportList { get; set; }

        /// <summary>
        /// 获取或设置入库货品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inbound_cargo_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("inbound_cargo_infos")]
        public IList<Types.InboundCargo>? InboundCargoList { get; set; }

        /// <summary>
        /// 获取或设置出库货品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("outbound_cargo_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("outbound_cargo_infos")]
        public IList<Types.OutboundCargo>? OutboundCargoList { get; set; }
    }
}
