using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/batchDecrypt 接口的请求。</para>
    /// </summary>
    public class OrderBatchDecryptRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class CipherData
            {
                /// <summary>
                /// 获取或设置业务标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_id")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_id")]
                public string AuthId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置密文。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cipher_text")]
                [System.Text.Json.Serialization.JsonPropertyName("cipher_text")]
                public string CipherText { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置待解密的密文列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cipher_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("cipher_infos")]
        public IList<Types.CipherData> CipherDataList { get; set; } = new List<Types.CipherData>();
    }
}
