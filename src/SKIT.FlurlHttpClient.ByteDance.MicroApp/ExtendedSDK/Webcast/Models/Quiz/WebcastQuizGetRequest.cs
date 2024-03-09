namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [GET] /quiz/get 接口的请求。</para>
    /// </summary>
    public class WebcastQuizGetRequest : DouyinMicroAppWebcastRequest
    {
        /// <summary>
        /// 获取或设置难度等级。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Level { get; set; }

        /// <summary>
        /// 获取或设置题目类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Type { get; set; }

        /// <summary>
        /// 获取或设置题目数量。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Number { get; set; }
    }
}
