using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /file/card_image/get 接口的请求。</para>
    /// </summary>
    public class WebcastFileCardImageGetRequest : DouyinMicroAppWebcastRequest
    {
        /// <summary>
        /// 获取或设置图片 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_ids")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("image_ids")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public IList<string> ImageIdList { get; set; } = new List<string>();
    }
}
