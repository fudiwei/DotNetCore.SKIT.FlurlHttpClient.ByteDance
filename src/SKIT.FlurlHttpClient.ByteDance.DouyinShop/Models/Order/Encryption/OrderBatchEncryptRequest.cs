using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/batchEncrypt 接口的请求。</para>
    /// </summary>
    public class OrderBatchEncryptRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class PlainData
            {
                /// <summary>
                /// 获取或设置业务标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_id")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_id")]
                public string AuthId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置明文。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("plain_text")]
                [System.Text.Json.Serialization.JsonPropertyName("plain_text")]
                public string PlainText { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置是否支持密文索引。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_support_index")]
                [System.Text.Json.Serialization.JsonPropertyName("is_support_index")]
                public bool IsSupportIndex { get; set; }

                /// <summary>
                /// 获取或设置加密类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sensitive_type")]
                [System.Text.Json.Serialization.JsonPropertyName("sensitive_type")]
                public int SensitiveType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置待加密的明文列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_encrypt_list")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_encrypt_list")]
        public IList<Types.PlainData> PlainDataList { get; set; } = new List<Types.PlainData>();
    }
}
