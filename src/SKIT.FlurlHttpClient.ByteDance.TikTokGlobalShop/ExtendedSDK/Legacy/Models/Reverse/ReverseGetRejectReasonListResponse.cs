namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [GET] /reverse/reverse_reason/list 接口的响应。</para>
    /// </summary>
    public class ReverseGetRejectReasonListResponse : TikTokShopLegacyResponse<ReverseGetRejectReasonListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Reason
                    {
                        /// <summary>
                        /// 获取或设置原因标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reverse_reason_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("reverse_reason_key")]
                        public string ReasonKey { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reverse_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reverse_reason")]
                        public string ReasonText { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置可用的订单状态列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_order_status_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("available_order_status_list")]
                        public int[] AvailableOrderStatusList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置原因列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reverse_reason_list")]
                [System.Text.Json.Serialization.JsonPropertyName("reverse_reason_list")]
                public Types.Reason[] ReasonList { get; set; } = default!;
            }
        }
    }
}
