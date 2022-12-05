namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/batchEncrypt 接口的响应。</para>
    /// </summary>
    public class OrderBatchEncryptResponse : DouyinShopResponse<OrderBatchEncryptResponse.Types.Data>
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

                    public class EncryptData
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
                /// 获取或设置加密数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypt_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypt_infos")]
                public Types.EncryptData[] EncryptDataList { get; set; } = default!;
            }
        }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.CustomError?.ErrorCode == 0;
        }
    }
}
