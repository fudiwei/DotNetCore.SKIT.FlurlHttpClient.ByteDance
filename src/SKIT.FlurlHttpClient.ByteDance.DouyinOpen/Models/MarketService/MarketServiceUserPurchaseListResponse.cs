namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /market/service/user/purchase/list 接口的响应。</para>
    /// </summary>
    public class MarketServiceUserPurchaseListResponse : DouyinOpenResponse<MarketServiceUserPurchaseListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Purchase
                    {
                        /// <summary>
                        /// 获取或设置服务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
                        public string ServiceId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_name")]
                        public string ServiceName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_status")]
                        public int ServiceStatus { get; set; }

                        /// <summary>
                        /// 获取或设置规格类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("specification_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("specification_type")]
                        public int SpecificationType { get; set; }

                        /// <summary>
                        /// 获取或设置规格名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("specification_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("specification_title")]
                        public string SpecificationTitle { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务规格 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_mode_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_mode_id")]
                        public string ServiceModeId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置剩余服务次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remain_service_times")]
                        [System.Text.Json.Serialization.JsonPropertyName("remain_service_times")]
                        public int? RemainServiceTimes { get; set; }

                        /// <summary>
                        /// 获取或设置服务生效时间毫秒级时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("effective_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("effective_time")]
                        public long? EffectiveTimeMilliseconds { get; set; }

                        /// <summary>
                        /// 获取或设置服务失效时间毫秒级时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("expire_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                        public long? ExpireTimeMilliseconds { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置购买信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("purchase_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("purchase_info_list")]
                public Types.Purchase[] PurchaseList { get; set; } = default!;
            }
        }
    }
}
