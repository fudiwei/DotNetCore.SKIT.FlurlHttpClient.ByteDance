using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/media/upload 接口的响应。</para>
    /// </summary>
    public class EnterpriseMediaUploadResponse : TikTokResponse<EnterpriseMediaUploadResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Media
                    {
                        /// <summary>
                        /// 获取或设置素材 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string MediaId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置素材的 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("url_list")]
                        public string[] UrlList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("error_code")]
                [System.Text.Json.Serialization.JsonPropertyName("error_code")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? ErrorDescription { get; set; }

                /// <summary>
                /// 获取或设置素材信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media")]
                [System.Text.Json.Serialization.JsonPropertyName("media")]
                public Types.Media? Media { get; set; }
            }
        }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.ErrorCode == 0;
        }
    }
}
