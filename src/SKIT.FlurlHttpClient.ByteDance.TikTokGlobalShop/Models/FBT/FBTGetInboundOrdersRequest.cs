using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fbt/{version}/inbound_orders 接口的请求。</para>
    /// </summary>
    public class FBTGetInboundOrdersRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置 API 版本号。
        /// <para>默认值：202409</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int ApiVersion { get; set; } = 202409;

        /// <summary>
        /// 获取或设置入库单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> InboundOrderIdList { get; set; } = new List<string>();
    }
}
