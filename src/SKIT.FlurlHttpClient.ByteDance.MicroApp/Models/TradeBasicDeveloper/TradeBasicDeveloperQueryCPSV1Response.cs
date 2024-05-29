namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_basic/v1/developer/query_cps/ 接口的响应。</para>
    /// </summary>
    public class TradeBasicDeveloperQueryCPSV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CPSItem
                    {
                        /// <summary>
                        /// 获取或设置商品单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                        public string ItemOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置售价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sell_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("sell_amount")]
                        public int SellAmount { get; set; }

                        /// <summary>
                        /// 获取或设置分佣类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("source_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("source_type")]
                        public int SourceType { get; set; }

                        /// <summary>
                        /// 获取或设置订单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置佣金（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_amount")]
                        public int CommissionAmount { get; set; }

                        /// <summary>
                        /// 获取或设置分佣比例（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_rate")]
                        public int CommissionRate { get; set; }

                        /// <summary>
                        /// 获取或设置达人抖音号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_user_douyinid")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_user_douyinid")]
                        public string CommissionUserDouyinId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置达人昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_user_nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_user_nickname")]
                        public string CommissionUserNickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置任务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                        public string TaskId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置短视频或直播间 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_id")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalStringReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ItemId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置开发者订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
                public string OutOrderNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单总佣金（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_commission_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("total_commission_amount")]
                public int TotalCommissionAmount { get; set; }

                /// <summary>
                /// 获取或设置订单 CPS 信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cps_item_list")]
                [System.Text.Json.Serialization.JsonPropertyName("cps_item_list")]
                public Types.CPSItem[] CPSItemList { get; set; } = default!;
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
