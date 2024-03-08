namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/microapp/operation/query_shop_material 接口的响应。</para>
    /// </summary>
    public class OpenApiMicroAppOperationQueryShopMaterialV1Response : OpenApiLegacyResponseBase
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class OnlineShopMaterialInfo
                    {
                        public static class Types
                        {
                            public class BusinessLicenseMaterial
                            {
                                /// <summary>
                                /// 获取或设置文件路径。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("path")]
                                [System.Text.Json.Serialization.JsonPropertyName("path")]
                                public string FilePath { get; set; } = default!;
                            }

                            public class ContractMaterial : BusinessLicenseMaterial
                            {
                            }

                            public class QualificationMaterial : BusinessLicenseMaterial
                            {
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
                                        public string FilePath { get; set; } = default!;
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
                                public Types.Material[] MaterialList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置商铺营业执照信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("biz_licence")]
                        [System.Text.Json.Serialization.JsonPropertyName("biz_licence")]
                        public Types.BusinessLicenseMaterial BusinessLicenseMaterial { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置合作协议信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contract")]
                        [System.Text.Json.Serialization.JsonPropertyName("contract")]
                        public Types.ContractMaterial ContractMaterial { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置行业资质列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qual_material")]
                        [System.Text.Json.Serialization.JsonPropertyName("qual_material")]
                        public Types.QualificationMaterial[]? QualificationMaterialList { get; set; }

                        /// <summary>
                        /// 获取或设置额外材料列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("additional_qual")]
                        [System.Text.Json.Serialization.JsonPropertyName("additional_qual")]
                        public Types.AdditionalMaterial[]? AdditionalMaterialList { get; set; }
                    }

                    public class AuditShopMaterialInfo
                    {
                        public static class Types
                        {
                            public class BusinessLicenseMaterial
                            {
                                /// <summary>
                                /// 获取或设置文件路径。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("path")]
                                [System.Text.Json.Serialization.JsonPropertyName("path")]
                                public string FilePath { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置审核状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int AuditStatus { get; set; }

                                /// <summary>
                                /// 获取或设置审核拒绝原因列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                                public string[]? RejectReasonList { get; set; }

                            }

                            public class ContractMaterial : BusinessLicenseMaterial
                            {
                            }

                            public class QualificationMaterial : BusinessLicenseMaterial
                            {
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
                                        public string FilePath { get; set; } = default!;
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
                                public Types.Material[] MaterialList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置审核状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int AuditStatus { get; set; }

                                /// <summary>
                                /// 获取或设置审核拒绝原因列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                                public string[]? RejectReasonList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商铺营业执照信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("biz_licence")]
                        [System.Text.Json.Serialization.JsonPropertyName("biz_licence")]
                        public Types.BusinessLicenseMaterial BusinessLicenseMaterial { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置合作协议信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contract")]
                        [System.Text.Json.Serialization.JsonPropertyName("contract")]
                        public Types.ContractMaterial ContractMaterial { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置行业资质列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qual_material")]
                        [System.Text.Json.Serialization.JsonPropertyName("qual_material")]
                        public Types.QualificationMaterial[]? QualificationMaterialList { get; set; }

                        /// <summary>
                        /// 获取或设置额外材料列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("additional_qual")]
                        [System.Text.Json.Serialization.JsonPropertyName("additional_qual")]
                        public Types.AdditionalMaterial[]? AdditionalMaterialList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置线上版资质信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("online_shop_material")]
                [System.Text.Json.Serialization.JsonPropertyName("online_shop_material")]
                public Types.OnlineShopMaterialInfo? OnlineShopMaterialInfo { get; set; }

                /// <summary>
                /// 获取或设置审核版资质信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_shop_material")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_shop_material")]
                public Types.AuditShopMaterialInfo? AuditShopMaterialInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
