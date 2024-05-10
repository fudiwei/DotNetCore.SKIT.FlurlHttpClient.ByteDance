using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/pre_combine_pkg/confirm 接口的请求。</para>
    /// </summary>
    public class FulfillmentConfirmPreCombinePackageRequest : TikTokShopLegacyRequest
    {
        public static class Types
        {
            public class PreCombinePackage
            {
                /// <summary>
                /// 获取或设置预合包 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pre_combine_pkg_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pre_combine_pkg_id")]
                public string PreCombinePackageId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置订单 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id_list")]
                public IList<string> OrderIdList { get; set; } = new List<string>();
            }
        }

        /// <summary>
        /// 获取或设置预合包列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_combine_pkg_list")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_combine_pkg_list")]
        public IList<Types.PreCombinePackage> PreCombinePackageList { get; set; } = new List<Types.PreCombinePackage>();
    }
}
