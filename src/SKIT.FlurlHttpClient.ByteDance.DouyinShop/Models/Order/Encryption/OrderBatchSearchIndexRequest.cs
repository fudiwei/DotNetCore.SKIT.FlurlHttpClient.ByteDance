using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/BatchSearchIndex 接口的请求。</para>
    /// </summary>
    public class OrderBatchSearchIndexRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class PlainData
            {
                /// <summary>
                /// 获取或设置明文。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plain_text")]
                [System.Text.Json.Serialization.JsonPropertyName("plain_text")]
                public string PlainText { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置加密类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypt_type")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypt_type")]
                public int SensitiveType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置待加密的明文列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plain_text_list")]
        [System.Text.Json.Serialization.JsonPropertyName("plain_text_list")]
        public IList<Types.PlainData> PlainDataList { get; set; } = new List<Types.PlainData>();
    }
}
