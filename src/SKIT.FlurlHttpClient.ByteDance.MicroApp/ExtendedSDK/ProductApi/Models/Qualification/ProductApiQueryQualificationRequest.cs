using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query_qualification 接口的请求。</para>
    /// </summary>
    public class ProductApiQueryQualificationRequest : DouyinMicroAppProductApiRequest
    {
        public static class Types
        {
            public class ObjectClassification
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
                public string ObjectId { get; set; } = string.Empty;

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
            }
        }

        /// <summary>
        /// 获取或设置资质查询单元列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("object_id_with_classifications")]
        [System.Text.Json.Serialization.JsonPropertyName("object_id_with_classifications")]
        public IList<Types.ObjectClassification> ObjectClassificationList { get; set; } = new List<Types.ObjectClassification>();
    }
}
