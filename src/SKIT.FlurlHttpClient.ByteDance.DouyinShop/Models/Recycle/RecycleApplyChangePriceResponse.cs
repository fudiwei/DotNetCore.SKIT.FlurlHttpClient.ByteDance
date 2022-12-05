namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /recycle/applyChangePrice 接口的响应。</para>
    /// </summary>
    public class RecycleApplyChangePriceResponse : DouyinShopResponse<RecycleApplyChangePriceResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置错误代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("err_no")]
                [System.Text.Json.Serialization.JsonPropertyName("err_no")]
                public int ErrorNumber { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("message")]
                [System.Text.Json.Serialization.JsonPropertyName("message")]
                public string ErrorMessage { get; set; } = default!;
            }
        }
    }
}
