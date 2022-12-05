using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/poi/poi/claim 接口的请求。</para>
    /// </summary>
    public class GoodLifePOIClaimV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class POI
            {
                public static class Types
                {
                    public class BusinessLicense : GoodLifePOISyncV1Request.Types.POI.Types.BusinessLicense
                    {
                    }

                    public class LegalPerson : GoodLifePOISyncV1Request.Types.POI.Types.LegalPerson
                    {
                    }

                    public class Industry : GoodLifePOISyncV1Request.Types.POI.Types.Industry
                    {
                        public static new class Types
                        {
                            public class Qualification : GoodLifePOISyncV1Request.Types.POI.Types.Industry.Types.Qualification
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置许可证列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualifications")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
                        public new IList<Types.Qualification>? QualificationList { get; set; }
                    }

                    public class Owner : GoodLifePOISyncV1Request.Types.POI.Types.Owner
                    {
                    }
                }

                /// <summary>
                /// 获取或设置三方 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_id")]
                [System.Text.Json.Serialization.JsonPropertyName("third_id")]
                public string ThirdId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商家 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_id")]
                [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                public string? AccountId { get; set; }

                /// <summary>
                /// 获取或设置门店 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi_id")]
                [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                public string POIId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置营业执照信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license")]
                [System.Text.Json.Serialization.JsonPropertyName("license")]
                public Types.BusinessLicense? BusinessLicense { get; set; }

                /// <summary>
                /// 获取或设置法人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_person")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
                public Types.LegalPerson? LegalPerson { get; set; }

                /// <summary>
                /// 获取或设置行业信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry")]
                [System.Text.Json.Serialization.JsonPropertyName("industry")]
                public Types.Industry? Industry { get; set; }

                /// <summary>
                /// 获取或设置所有人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("owner_info")]
                [System.Text.Json.Serialization.JsonPropertyName("owner_info")]
                public Types.Owner? Owner { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置目标类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target_type")]
        [System.Text.Json.Serialization.JsonPropertyName("target_type")]
        public int TargetType { get; set; }

        /// <summary>
        /// 获取或设置门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("datas")]
        [System.Text.Json.Serialization.JsonPropertyName("datas")]
        public IList<Types.POI> POIList { get; set; } = new List<Types.POI>();
    }
}
