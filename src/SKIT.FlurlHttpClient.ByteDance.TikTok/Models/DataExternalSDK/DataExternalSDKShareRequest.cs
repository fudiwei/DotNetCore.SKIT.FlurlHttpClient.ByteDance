using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/sdk_share 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2022-08-09 下线。")]
    public class DataExternalSDKShareRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置开始日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BeginDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置结束日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string EndDateString { get; set; } = string.Empty;
    }
}
