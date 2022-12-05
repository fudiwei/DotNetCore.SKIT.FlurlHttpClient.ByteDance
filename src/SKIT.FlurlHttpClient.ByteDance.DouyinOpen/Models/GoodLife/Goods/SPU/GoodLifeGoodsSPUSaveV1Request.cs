using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/goods/spu/save 接口的请求。</para>
    /// </summary>
    public class GoodLifeGoodsSPUSaveV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class SPU
            {
                public static class Types
                {
                    public class POI
                    {
                        /// <summary>
                        /// 获取或设置门店外部 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
                        public string? SupplierExternalId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_id")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_id")]
                public string? SPUId { get; set; }

                /// <summary>
                /// 获取或设置商品外部 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_spu_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_spu_id")]
                public string? OutSPUId { get; set; }

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_name")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_name")]
                public string SPUName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_type")]
                [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                public int ProductType { get; set; }

                /// <summary>
                /// 获取或设置业务线类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_line")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_line")]
                public int BusinessLineType { get; set; }

                /// <summary>
                /// 获取或设置商品描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string Description { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pois")]
                [System.Text.Json.Serialization.JsonPropertyName("pois")]
                public IList<Types.POI> POIList { get; set; } = new List<Types.POI>();

                /// <summary>
                /// 获取或设置属性键值对字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attr_key_value_map")]
                [System.Text.Json.Serialization.JsonPropertyName("attr_key_value_map")]
                public IDictionary<string, string>? AttributeKeyValueMap { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu")]
        [System.Text.Json.Serialization.JsonPropertyName("spu")]
        public Types.SPU SPU { get; set; } = new Types.SPU();
    }
}
