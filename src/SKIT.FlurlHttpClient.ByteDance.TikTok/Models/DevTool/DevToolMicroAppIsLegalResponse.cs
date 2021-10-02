using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /devtool/micapp/is_legal 接口的响应。</para>
    /// </summary>
    public class DevToolMicroAppIsLegalResponse : TikTokResponse<DevToolMicroAppIsLegalResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
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
                /// 获取或设置是否是合法信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_legal")]
                [System.Text.Json.Serialization.JsonPropertyName("is_legal")]
                public bool IsLegal { get; set; }
            }
        }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.ErrorCode == 0;
        }
    }
}
