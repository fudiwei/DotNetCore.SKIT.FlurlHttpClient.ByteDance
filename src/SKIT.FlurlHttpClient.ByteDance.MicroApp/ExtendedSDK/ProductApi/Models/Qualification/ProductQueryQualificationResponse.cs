namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query_qualification 接口的响应。</para>
    /// </summary>
    public class ProductQueryQualificationResponse : DouyinMicroAppProductApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Qualification
                    {
                        public static class Types
                        {
                            public class QualificationInfo
                            {
                                /// <summary>
                                /// 获取或设置审核主体类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("object_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("object_type")]
                                public int ObjectType { get; set; }

                                /// <summary>
                                /// 获取或设置审核主体 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("object_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("object_id")]
                                public string ObjectId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置一级类目 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("first_class")]
                                [System.Text.Json.Serialization.JsonPropertyName("first_class")]
                                public int? FirstClassId { get; set; }

                                /// <summary>
                                /// 获取或设置二级类目 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("second_class")]
                                [System.Text.Json.Serialization.JsonPropertyName("second_class")]
                                public int? SecondClassId { get; set; }

                                /// <summary>
                                /// 获取或设置三级类目 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("third_class")]
                                [System.Text.Json.Serialization.JsonPropertyName("third_class")]
                                public int? ThirdClassId { get; set; }

                                /// <summary>
                                /// 获取或设置审核状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }

                                /// <summary>
                                /// 获取或设置审核主体名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("object_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("object_name")]
                                public string? ObjectName { get; set; }

                                /// <summary>
                                /// 获取或设置审核主体昵称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("nick_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
                                public string? Nickname { get; set; }

                                /// <summary>
                                /// 获取或设置审核失败原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fail_reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                                public string? FailReson { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置已上架的资质信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_on_shelf")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_on_shelf")]
                        public Types.QualificationInfo? QualificationOnShelf { get; set; }

                        /// <summary>
                        /// 获取或设置审核中的资质信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_reviewing")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_reviewing")]
                        public Types.QualificationInfo? QualificationReviewing { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置审核主体 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("object_id")]
                [System.Text.Json.Serialization.JsonPropertyName("object_id")]
                public string ObejctId { get; set; } = default!;

                /// <summary>
                /// 获取或设置资质信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualifications")]
                [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
                public Types.Qualification[] QualificationList { get; set; } = default!;
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
