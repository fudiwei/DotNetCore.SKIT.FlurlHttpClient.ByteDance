using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/qualityTask 接口的响应。</para>
    /// </summary>
    public class ProductQualityTaskResponse : TikTokShopResponse<ProductQualityTaskResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ProblemTypeDistribution
                    {
                        /// <summary>
                        /// 获取或设置优化项代号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("type_key")]
                        public int TypeKey { get; set; }

                        /// <summary>
                        /// 获取或设置优化项具体名字。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("type_name")]
                        public string TypeName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置具体问题数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("num")]
                        [System.Text.Json.Serialization.JsonPropertyName("num")]
                        public int Count { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public int TaskId { get; set; }

                /// <summary>
                /// 获取或设置任务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_status")]
                [System.Text.Json.Serialization.JsonPropertyName("task_status")]
                public int TaskStatus { get; set; }

                /// <summary>
                /// 获取或设置总共需要诊断的商品数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_num_total")]
                [System.Text.Json.Serialization.JsonPropertyName("product_num_total")]
                public int ProductTotalCount { get; set; }

                /// <summary>
                /// 获取或设置已经诊断过的商品数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_num_finished")]
                [System.Text.Json.Serialization.JsonPropertyName("product_num_finished")]
                public int ProductFinishedCount { get; set; }

                /// <summary>
                /// 获取或设置待优化商品数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_num_to_improve_total")]
                [System.Text.Json.Serialization.JsonPropertyName("product_num_to_improve_total")]
                public int? ProductToImproveTotalCount { get; set; }

                /// <summary>
                /// 获取或设置可优化项总数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("problem_num_total")]
                [System.Text.Json.Serialization.JsonPropertyName("problem_num_total")]
                public int? ProblemTotalNumber { get; set; }

                /// <summary>
                /// 获取或设置待优化项数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("problem_num_to_improve")]
                [System.Text.Json.Serialization.JsonPropertyName("problem_num_to_improve")]
                public int? ProblemToImproveTotalCount { get; set; }

                /// <summary>
                /// 获取或设置任务完成时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_finish_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("task_finish_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                public DateTimeOffset? TaskFinishTime { get; set; }

                /// <summary>
                /// 获取或设置问题类型分布。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("problem_type_distribution")]
                [System.Text.Json.Serialization.JsonPropertyName("problem_type_distribution")]
                public Types.ProblemTypeDistribution[]? ProblemTypeDistributionList { get; set; }

                /// <summary>
                /// 获取或设置达标率（范围：0～100）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("standard_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("standard_rate")]
                public double StandardRate { get; set; }

                /// <summary>
                /// 获取或设置是否达标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_standard")]
                [System.Text.Json.Serialization.JsonPropertyName("is_standard")]
                public bool IsStandard { get; set; }

                /// <summary>
                /// 获取或设置达标商品数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meet_standard_num")]
                [System.Text.Json.Serialization.JsonPropertyName("meet_standard_num")]
                public int MeetStandardNumber { get; set; }
            }
        }
    }
}
