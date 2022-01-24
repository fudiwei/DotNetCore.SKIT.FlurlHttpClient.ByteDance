namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/batchSensitive 接口的响应。</para>
    /// </summary>
    public class OrderBatchSensitiveResponse : TikTokShopResponse<OrderBatchSensitiveResponse.Types.Data>
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

                    public class DecryptData : OrderBatchDecryptResponse.Types.Data.Types.DecryptData
                    {
                    }
                }

                /// <summary>
                /// 获取或设置业务错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_err")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_err")]
                public Types.CustomError CustomError { get; set; } = default!;

                /// <summary>
                /// 获取或设置脱敏数据列表。
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
