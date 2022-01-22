using System.Collections.Generic;

/* @codestyle-disable no-jsonable-property-in-request-get */
namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/file/image/get 接口的请求。</para>
    /// </summary>
    public class FileImageGetRequest : OceanEngineRequest
    {
        public static class Types
        {
            public class Filter
            {
                /// <summary>
                /// 获取或设置图片 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("image_ids")]
                public IList<string>? ImageIdList { get; set; }

                /// <summary>
                /// 获取或设置素材 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("material_ids")]
                public IList<long>? MaterialIdList { get; set; }

                /// <summary>
                /// 获取或设置图片 MD5 哈希值列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("signatures")]
                [System.Text.Json.Serialization.JsonPropertyName("signatures")]
                public IList<string>? SignatureList { get; set; }

                /// <summary>
                /// 获取或设置图片宽度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("width")]
                [System.Text.Json.Serialization.JsonPropertyName("width")]
                public int? Width { get; set; }

                /// <summary>
                /// 获取或设置图片高度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("height")]
                [System.Text.Json.Serialization.JsonPropertyName("height")]
                public int? Height { get; set; }

                /// <summary>
                /// 获取或设置图片宽高比列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                public IList<double>? RatioList { get; set; }

                /// <summary>
                /// 获取或设置开始时间字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public string? StartDateString { get; set; }

                /// <summary>
                /// 获取或设置结束时间字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public string? EndDateString { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置过滤条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filtering")]
        [System.Text.Json.Serialization.JsonPropertyName("filtering")]
        public Types.Filter? Filter { get; set; }

        /// <summary>
        /// 获取或设置分页页码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }
    }
}
