namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [GET] /quiz/get 接口的响应。</para>
    /// </summary>
    public class WebcastQuizGetResponse : DouyinMicroAppWebcastResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Quiz
                    {
                        /// <summary>
                        /// 获取或设置题目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string Id { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置题目标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置题目选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("options")]
                        [System.Text.Json.Serialization.JsonPropertyName("options")]
                        public string[] OptionList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置题目答案下标。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("answer")]
                        [System.Text.Json.Serialization.JsonPropertyName("answer")]
                        public int AnswerIndex { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置题目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Quiz[] QuizList { get; set; } = default!;
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
