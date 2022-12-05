namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/getOutRange 接口的响应。</para>
    /// </summary>
    public class LogisticsGetOutRangeResponse : DouyinShopResponse<LogisticsGetOutRangeResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置是否超区。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_out_range")]
                [System.Text.Json.Serialization.JsonPropertyName("is_out_range")]
                public bool IsOutRange { get; set; }

                /// <summary>
                /// 获取或设置超区原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_range_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("out_range_reason")]
                public string? Reason { get; set; }
            }
        }
    }
}
