using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/applyLogisticsIntercept 接口的请求。</para>
    /// </summary>
    public class AftersaleApplyLogisticsInterceptRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class TnterceptTarget
            {
                /// <summary>
                /// 获取或设置物流公司编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_code")]
                [System.Text.Json.Serialization.JsonPropertyName("company_code")]
                public string CompanyCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置物流单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tracking_no")]
                [System.Text.Json.Serialization.JsonPropertyName("tracking_no")]
                public string LogisticsNumber { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_id")]
        public string AftersaleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("op_from")]
        [System.Text.Json.Serialization.JsonPropertyName("op_from")]
        public int OperateFrom { get; set; }

        /// <summary>
        /// 获取或设置要拦截的包裹列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intercept_targets")]
        [System.Text.Json.Serialization.JsonPropertyName("intercept_targets")]
        public IList<Types.TnterceptTarget> TnterceptTargetList { get; set; } = new List<Types.TnterceptTarget>();
    }
}
