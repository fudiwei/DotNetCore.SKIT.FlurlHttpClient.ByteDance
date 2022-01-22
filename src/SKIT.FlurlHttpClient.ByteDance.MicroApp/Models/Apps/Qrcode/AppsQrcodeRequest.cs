namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/qrcode 接口的请求。</para>
    /// </summary>
    public class AppsQrcodeRequest : ByteDanceMicroAppRequest
    {
        public static class Types
        {
            public class Color
            {
                /// <summary>
                /// 获取或设置 RGB 红色色值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("r")]
                [System.Text.Json.Serialization.JsonPropertyName("r")]
                public byte Red { get; set; }

                /// <summary>
                /// 获取或设置 RGB 绿色色值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("g")]
                [System.Text.Json.Serialization.JsonPropertyName("g")]
                public byte Green { get; set; }

                /// <summary>
                /// 获取或设置 RGB 蓝色色值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("b")]
                [System.Text.Json.Serialization.JsonPropertyName("b")]
                public byte Blue { get; set; }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置打开二维码的字节系 App 名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appname")]
        [System.Text.Json.Serialization.JsonPropertyName("appname")]
        public string? AppName { get; set; }

        /// <summary>
        /// 获取或设置 URL 编码后的小程序启动路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? EncodedPath { get; set; }

        /// <summary>
        /// 获取或设置二维码宽度（单位：像素）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("width")]
        [System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// 获取或设置二维码线条颜色信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("line_color")]
        [System.Text.Json.Serialization.JsonPropertyName("line_color")]
        public Types.Color? LineColor { get; set; }

        /// <summary>
        /// 获取或设置二维码背景颜色信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("background")]
        [System.Text.Json.Serialization.JsonPropertyName("background")]
        public Types.Color? BackgroundColor { get; set; }

        /// <summary>
        /// 获取或设置是否展示小程序 Icon。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("set_icon")]
        [System.Text.Json.Serialization.JsonPropertyName("set_icon")]
        public bool? RequireSetIcon { get; set; }
    }
}
