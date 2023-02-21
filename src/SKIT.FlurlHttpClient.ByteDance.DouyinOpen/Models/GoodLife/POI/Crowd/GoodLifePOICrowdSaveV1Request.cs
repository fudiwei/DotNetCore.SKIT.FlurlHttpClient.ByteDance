using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/poi/crowd/save 接口的请求。</para>
    /// </summary>
    public class GoodLifePOICrowdSaveV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class Crowd
            {
                public static class Types
                {
                    public class Condition
                    {
                        /// <summary>
                        /// 获取或设置下界。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lower_bound")]
                        [System.Text.Json.Serialization.JsonPropertyName("lower_bound")]
                        public int? LowerBound { get; set; }

                        /// <summary>
                        /// 获取或设置下界包含类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lower_bound_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("lower_bound_type")]
                        public int? LowerBoundType { get; set; }

                        /// <summary>
                        /// 获取或设置上界。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("upper_bound")]
                        [System.Text.Json.Serialization.JsonPropertyName("upper_bound")]
                        public int? UpperBound { get; set; }

                        /// <summary>
                        /// 获取或设置上界包含类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("upper_bound_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("upper_bound_type")]
                        public int? UpperBoundType { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置人群类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("crowd_type")]
                [System.Text.Json.Serialization.JsonPropertyName("crowd_type")]
                public int CrowdType { get; set; }

                /// <summary>
                /// 获取或设置年龄条件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("age_condition")]
                [System.Text.Json.Serialization.JsonPropertyName("age_condition")]
                public Types.Condition? AgeCondition { get; set; }

                /// <summary>
                /// 获取或设置身高条件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("height_condition")]
                [System.Text.Json.Serialization.JsonPropertyName("height_condition")]
                public Types.Condition? HeightCondition { get; set; }

                /// <summary>
                /// 获取或设置操作类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("op_type")]
                [System.Text.Json.Serialization.JsonPropertyName("op_type")]
                public int? OperateType { get; set; }

                /// <summary>
                /// 获取或设置特殊说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("note")]
                [System.Text.Json.Serialization.JsonPropertyName("note")]
                public string? Notes { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_id")]
        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poi_id")]
        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
        public string POIId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置人群列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("crowds")]
        [System.Text.Json.Serialization.JsonPropertyName("crowds")]
        public IList<Types.Crowd> CrowdList { get; set; } = new List<Types.Crowd>();
    }
}
