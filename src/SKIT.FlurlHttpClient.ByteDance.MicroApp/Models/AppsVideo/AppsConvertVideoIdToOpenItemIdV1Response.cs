using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/convert_video_id/video_id_to_open_item_id/ 接口的响应。</para>
    /// </summary>
    public class AppsConvertVideoIdToOpenItemIdV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置转换结果字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("convert_result")]
                [System.Text.Json.Serialization.JsonPropertyName("convert_result")]
                public IDictionary<string, string> Result { get; set; } = default!;
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
