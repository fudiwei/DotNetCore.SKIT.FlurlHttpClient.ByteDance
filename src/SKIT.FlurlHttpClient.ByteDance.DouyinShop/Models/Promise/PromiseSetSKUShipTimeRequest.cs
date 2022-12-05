using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /promise/setSkuShipTime 接口的请求。</para>
    /// </summary>
    public class PromiseSetSKUShipTimeRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Rule
            {
                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置外部仓库 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
                public string OutWarehouseId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置预售类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pre_sell_type")]
                [System.Text.Json.Serialization.JsonPropertyName("pre_sell_type")]
                public int PreSellType { get; set; }

                /// <summary>
                /// 获取或设置延迟发货天数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delay_day")]
                [System.Text.Json.Serialization.JsonPropertyName("delay_day")]
                public int DelayDay { get; set; }

                /// <summary>
                /// 获取或设置预售截止时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pre_sell_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pre_sell_end_time")]
                public long PreSellEndTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置发货时效规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rules")]
        [System.Text.Json.Serialization.JsonPropertyName("rules")]
        public IList<Types.Rule> RuleList { get; set; } = new List<Types.Rule>();
    }
}
