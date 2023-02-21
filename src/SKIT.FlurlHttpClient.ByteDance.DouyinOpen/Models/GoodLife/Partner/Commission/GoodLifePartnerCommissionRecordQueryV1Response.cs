namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/partner/commission_record/query 接口的响应。</para>
    /// </summary>
    public class GoodLifePartnerCommissionRecordQueryV1Response : DouyinOpenResponse<GoodLifePartnerCommissionRecordQueryV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class CommissionRecord
                    {
                        /// <summary>
                        /// 获取或设置佣金配置记录 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("record_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("record_id")]
                        public string RecordId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置佣金配置记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commission_records")]
                [System.Text.Json.Serialization.JsonPropertyName("commission_records")]
                public Types.CommissionRecord[] CommissionRecordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
