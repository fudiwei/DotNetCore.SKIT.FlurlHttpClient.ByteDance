using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /spu/addShopSpu 接口的请求。</para>
    /// </summary>
    public class SPUAddShopSPURequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Property
            {
                /// <summary>
                /// 获取或设置属性 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("property_id")]
                [System.Text.Json.Serialization.JsonPropertyName("property_id")]
                public int PropertyId { get; set; }

                /// <summary>
                /// 获取或设置属性值 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value_id")]
                [System.Text.Json.Serialization.JsonPropertyName("value_id")]
                public int ValueId { get; set; }

                /// <summary>
                /// 获取或设置属性值名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value_name")]
                [System.Text.Json.Serialization.JsonPropertyName("value_name")]
                public string? ValueName { get; set; }

                /// <summary>
                /// 获取或设置父属性值 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parent_value_id")]
                [System.Text.Json.Serialization.JsonPropertyName("parent_value_id")]
                public int? ParentValueId { get; set; }

                /// <summary>
                /// 获取或设置属性层级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level")]
                [System.Text.Json.Serialization.JsonPropertyName("level")]
                public int? Level { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置 SPU 名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu_name")]
        [System.Text.Json.Serialization.JsonPropertyName("spu_name")]
        public string SPUName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置产品编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upc_code")]
        [System.Text.Json.Serialization.JsonPropertyName("upc_code")]
        public string? UPC { get; set; }

        /// <summary>
        /// 获取或设置类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public int CategoryId { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public int BrandId { get; set; }

        /// <summary>
        /// 获取或设置属性列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("property_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("property_infos")]
        public IList<Types.Property> PropertyList { get; set; } = new List<Types.Property>();
    }
}
