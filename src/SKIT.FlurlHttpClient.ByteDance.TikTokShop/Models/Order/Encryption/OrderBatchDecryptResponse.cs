namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/batchDecrypt 接口的响应。</para>
    /// </summary>
    public class OrderBatchDecryptResponse : TikTokShopResponse<OrderBatchDecryptResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CustomError
                    {
                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("err_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("err_code")]
                        public int ErrorCode { get; set; }

                        /// <summary>
                        /// 获取或设置错误描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("err_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
                        public string? ErrorMessage { get; set; }
                    }

                    public class DecryptData
                    {
                        /// <summary>
                        /// 获取或设置业务标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("auth_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("auth_id")]
                        public string AuthId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置密文。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cipher_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("cipher_text")]
                        public string CipherText { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置明文。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("decrypt_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("decrypt_text")]
                        public string PlainText { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("err_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
                        public int ErrorNumber { get; set; }

                        /// <summary>
                        /// 获取或设置错误描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("err_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
                        public string? ErrorMessage { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置业务错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_err")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_err")]
                public Types.CustomError CustomError { get; set; } = default!;

                /// <summary>
                /// 获取或设置解密数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("decrypt_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("decrypt_infos")]
                public Types.DecryptData[] DecryptDataList { get; set; } = default!;
            }
        }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.CustomError?.ErrorCode == 0;
        }
    }
}
