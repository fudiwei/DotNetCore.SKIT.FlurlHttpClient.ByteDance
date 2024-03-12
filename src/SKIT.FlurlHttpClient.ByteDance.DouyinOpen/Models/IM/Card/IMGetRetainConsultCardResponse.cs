namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /im/get/retain_consult_card/ 接口的响应。</para>
    /// </summary>
    public class IMGetRetainConsultCardResponse : DouyinOpenResponse<IMGetRetainConsultCardResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }

            public class Card
            {
                /// <summary>
                /// 获取或设置卡片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_id")]
                [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                public string CardId { get; set; } = default!;

                /// <summary>
                /// 获取或设置卡片标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置输入组件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("components")]
                [System.Text.Json.Serialization.JsonPropertyName("components")]
                public int[] ComponentIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string MediaId { get; set; } = default!;

                /// <summary>
                /// 获取或设置卡片状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置卡片列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cards")]
        [System.Text.Json.Serialization.JsonPropertyName("cards")]
        public Types.Card[] CardList { get; set; } = default!;
    }
}
