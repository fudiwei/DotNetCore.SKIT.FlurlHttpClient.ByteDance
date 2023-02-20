using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /modify_no_audit 接口的请求。</para>
    /// </summary>
    public class ProductApiModifyNoAuditRequest : ByteDanceMicroAppProductApiRequest
    {
        public static class Types
        {
            public class ProductInfo
            {
                public static class Types
                {
                    public class MiniAppPageInfo
                    {
                        /// <summary>
                        /// 获取或设置小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path")]
                        [System.Text.Json.Serialization.JsonPropertyName("path")]
                        public string PagePath { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置小程序页面查询参数字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("query")]
                        [System.Text.Json.Serialization.JsonPropertyName("query")]
                        public IDictionary<string, string> QueryMap { get; set; } = new Dictionary<string, string>();
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序页面信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path_info_lst")]
                [System.Text.Json.Serialization.JsonPropertyName("path_info_lst")]
                public IList<Types.MiniAppPageInfo> MiniAppPageList { get; set; } = new List<Types.MiniAppPageInfo>();
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置商品类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_type")]
        [System.Text.Json.Serialization.JsonPropertyName("product_type")]
        public int ProductType { get; set; }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.ProductInfo ProductInfo { get; set; } = new Types.ProductInfo();
    }
}
