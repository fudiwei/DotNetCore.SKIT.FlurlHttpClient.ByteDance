using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/{version}/packages/combine 接口的请求。</para>
    /// </summary>
    public class FulfillmentCombinePackageRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class CombinablePackage
            {
                /// <summary>
                /// 获取或设置可合并的包裹 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string CombinablePackageId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置订单 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("order_ids")]
                public IList<string>? OrderIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置可合并的包裹列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combinable_packages")]
        [System.Text.Json.Serialization.JsonPropertyName("combinable_packages")]
        public IList<Types.CombinablePackage> CombinablePackageList { get; set; } = new List<Types.CombinablePackage>();
    }
}
