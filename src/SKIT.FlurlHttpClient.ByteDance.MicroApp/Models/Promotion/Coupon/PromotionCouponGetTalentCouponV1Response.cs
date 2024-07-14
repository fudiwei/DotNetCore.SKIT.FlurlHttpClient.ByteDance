namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v1/coupon/get_talent_coupon/ 接口的响应。</para>
    /// </summary>
    public class PromotionCouponGetTalentCouponV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置账号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                public int AccountType { get; set; }

                /// <summary>
                /// 获取或设置主播的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string? TalentOpenId { get; set; }

                /// <summary>
                /// 获取或设置主播抖音号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("talent_account")]
                [System.Text.Json.Serialization.JsonPropertyName("talent_account")]
                public string? TalentAccount { get; set; }

                /// <summary>
                /// 获取或设置券模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_meta_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_meta_id")]
                public string CouponMetaId { get; set; } = default!;

                /// <summary>
                /// 获取或设置发券状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置库存发放上限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_limit")]
                public long StockLimit { get; set; }

                /// <summary>
                /// 获取或设置奖励券的数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("award_assigned_num")]
                [System.Text.Json.Serialization.JsonPropertyName("award_assigned_num")]
                public long? AwardAssignedNumber { get; set; }

                /// <summary>
                /// 获取或设置发放场景。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_scene")]
                [System.Text.Json.Serialization.JsonPropertyName("send_scene")]
                public int? SendScene { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
