namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/censor/image 接口的响应。</para>
    /// </summary>
    public class AppsCensorImageResponse : DouyinMicroAppResponse
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

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("error")]
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public override int ErrorNumber { get; set; }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置置信度列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("predicts")]
        [System.Text.Json.Serialization.JsonPropertyName("predicts")]
        public Types.Predict[] PredictList { get; set; } = default!;
    }
}
