using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/operation/add_shop_material 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppOperationAddShopMaterialV1Request : ByteDanceMicroAppOpenApiRequest
    {
        public static class Types
        {
            public class QualificationMaterial
            {
                /// <summary>
                /// 获取或设置文件路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string FilePath { get; set; } = string.Empty;
            }

            public class AdditionalMaterial
            {
                public static class Types
                {
                    public class Material
                    {
                        /// <summary>
                        /// 获取或设置文件路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string FilePath { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置上传资质类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("additional_qual_type")]
                [System.Text.Json.Serialization.JsonPropertyName("additional_qual_type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置材料列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paths")]
                [System.Text.Json.Serialization.JsonPropertyName("paths")]
                public IList<Types.Material> MaterialList { get; set; } = new List<Types.Material>();
            }
        }


        /// <summary>
        /// 获取或设置服务商 ClientKey。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_key")]
        [System.Text.Json.Serialization.JsonPropertyName("client_key")]
        public string ClientKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接入方店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
        public string SupplierExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商铺营业执照路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_licence_path")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_licence_path")]
        public string BusinessLicencePath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商家授权函路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_path")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_path")]
        public string ContractPath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置行业资质列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qual_material")]
        [System.Text.Json.Serialization.JsonPropertyName("qual_material")]
        public IList<Types.QualificationMaterial>? QualificationMaterialList { get; set; }

        /// <summary>
        /// 获取或设置额外材料列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("additional_qual")]
        [System.Text.Json.Serialization.JsonPropertyName("additional_qual")]
        public IList<Types.AdditionalMaterial>? AdditionalMaterialList { get; set; }

        /// <summary>
        /// 获取或设置过期日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        public string ExpireDateString { get; set; } = string.Empty;
    }
}
