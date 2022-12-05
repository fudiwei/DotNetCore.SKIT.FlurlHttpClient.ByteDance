namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /recycle/logisticsBack 接口的响应。</para>
    /// </summary>
    public class RecycleLogisticsBackResponse : DouyinShopResponse<RecycleLogisticsBackResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置是否成功。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("success")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualBooleanConverter))]
                public bool IsSuccessful { get; set; }

                /// <summary>
                /// 获取或设置错误代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("err_no")]
                [System.Text.Json.Serialization.JsonPropertyName("err_no")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? ErrorNumber { get; set; }
            }
        }
    }
}
