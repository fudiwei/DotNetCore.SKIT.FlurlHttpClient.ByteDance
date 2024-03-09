using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/get_self_mount_bind_qrcode 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-01 下线。")]
    public class AppsCapacityGetSelfMountBindQrcodeV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置二维码图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qrcode_url")]
                [System.Text.Json.Serialization.JsonPropertyName("qrcode_url")]
                public string QrcodeUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置二维码数据字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qrcode_parse_content")]
                [System.Text.Json.Serialization.JsonPropertyName("qrcode_parse_content")]
                public string QrcodeDataString { get; set; } = default!;
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
