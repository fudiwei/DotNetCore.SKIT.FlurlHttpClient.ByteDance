using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/order_split/confirm 接口的请求。</para>
    /// </summary>
    public class FulfillmentConfirmOrderSplitRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class PreSplitPackage
            {
                /// <summary>
                /// 获取或设置预拆包 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pre_split_pkg_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pre_split_pkg_id")]
                public string PreSplitPackageId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置订单项 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_line_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("order_line_id_list")]
                public IList<string> OrderLineIdList { get; set; } = new List<string>();
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置预拆包列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("split_group")]
        [System.Text.Json.Serialization.JsonPropertyName("split_group")]
        public IList<Types.PreSplitPackage> PreSplitPackageList { get; set; } = new List<Types.PreSplitPackage>();
    }
}
