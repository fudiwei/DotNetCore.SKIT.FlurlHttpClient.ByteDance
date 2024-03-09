namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/censor/image 接口的响应。</para>
    /// </summary>
    public class AppsCensorImageV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Predict
            {
                /// <summary>
                /// 获取或设置置信度模型或标签。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("model_name")]
                [System.Text.Json.Serialization.JsonPropertyName("model_name")]
                public string ModelName { get; set; } = default!;

                /// <summary>
                /// 获取或设置置信度结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hit")]
                [System.Text.Json.Serialization.JsonPropertyName("hit")]
                public bool IsHit { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置置信度列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("predicts")]
        [System.Text.Json.Serialization.JsonPropertyName("predicts")]
        public Types.Predict[] PredictList { get; set; } = default!;
    }
}
