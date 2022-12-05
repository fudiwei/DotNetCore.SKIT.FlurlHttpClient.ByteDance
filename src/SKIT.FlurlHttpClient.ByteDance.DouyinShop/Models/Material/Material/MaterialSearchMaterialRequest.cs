using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/searchMaterial 接口的请求。</para>
    /// </summary>
    public class MaterialSearchMaterialRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置素材 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("object_id")]
        [System.Text.Json.Serialization.JsonPropertyName("object_id")]
        public string? ObjectId { get; set; }

        /// <summary>
        /// 获取或设置素材名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("material_name")]
        [System.Text.Json.Serialization.JsonPropertyName("material_name")]
        public string? MaterialMame { get; set; }

        /// <summary>
        /// 获取或设置素材类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("material_type")]
        [System.Text.Json.Serialization.JsonPropertyName("material_type")]
        public IList<string>? MaterialTypeList { get; set; }

        /// <summary>
        /// 获取或设置审核状态列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_status")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
        public IList<int>? AuditStatusList { get; set; }

        /// <summary>
        /// 获取或设置素材状态列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operate_status")]
        [System.Text.Json.Serialization.JsonPropertyName("operate_status")]
        public IList<int>? OperateStatusList { get; set; }

        /// <summary>
        /// 获取或设置创建开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_start")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_start")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? CreateTimeStart { get; set; }

        /// <summary>
        /// 获取或设置创建结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_end")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_end")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? CreateTimeEnd { get; set; }

        /// <summary>
        /// 获取或设置文件夹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentObjectId { get; set; }

        /// <summary>
        /// 获取或设置翻页页数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        [System.Text.Json.Serialization.JsonPropertyName("page_num")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 获取或设置翻页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// 获取或设置排序方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public int? OrderType { get; set; }
    }
}
