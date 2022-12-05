namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/BatchSearchIndex 接口的响应。</para>
    /// </summary>
    public class OrderBatchSearchIndexResponse : DouyinShopResponse<OrderBatchSearchIndexResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CustomError : OrderBatchDecryptResponse.Types.Data.Types.CustomError
                    {
                    }

                    public class EncryptIndex
                    {
                        /// <summary>
                        /// 获取或设置明文。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("plain")]
                        [System.Text.Json.Serialization.JsonPropertyName("plain")]
                        public string PlainText { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置索引串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("search_index")]
                        [System.Text.Json.Serialization.JsonPropertyName("search_index")]
                        public string SearchIndex { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置业务错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_err")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_err")]
                public Types.CustomError CustomError { get; set; } = default!;

                /// <summary>
                /// 获取或设置加密索引串列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plain_to_encrypt_index_list")]
                [System.Text.Json.Serialization.JsonPropertyName("plain_to_encrypt_index_list")]
                public Types.EncryptIndex[] EncryptIndexList { get; set; } = default!;
            }
        }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.CustomError?.ErrorCode == 0;
        }
    }
}
