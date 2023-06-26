using System;
using System.Collections.Generic;
using System.Text;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/v1/query_platform_order 接口的响应。</para>
    /// </summary>
    public class AppsECPayQueryPlatformOrderV1Response : ByteDanceMicroAppResponse
    {

        public static class Types
        {
            public class PlatformOrder
            {
                /// <summary>
                /// 小程序APPID
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string? AppId { get; set; }

                /// <summary>
                /// 开发者侧支付订单号
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
                public string? OutOrderNo { get; set; }

                /// <summary>
                /// 对应的查询类型
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query_type")]
                [System.Text.Json.Serialization.JsonPropertyName("query_type")]
                public string? QueryType { get; set; }

                /// <summary>
                /// 自动结算明细List
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_info_list")]
                public List<SettleInfoList>? SettleInfoList { get; set; }
            }

            public class SettleInfoList
            {
                /// <summary>
                /// 结算单创建时间
                /// </summary>
                [Newtonsoft.Json.JsonProperty("created_at")]
                [System.Text.Json.Serialization.JsonPropertyName("created_at")]
                public string? CreatedAt { get; set; }

                /// <summary>
                /// 自动结算单号
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_settle_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_settle_no")]
                public string? OutSettleNo { get; set; }

                /// <summary>
                /// 小程序分账单号
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_no")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_no")]
                public string? SettleNo { get; set; }

                /// <summary>
                /// 分账状态枚举值：SUCCESS：成功 FAIL：失败
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_status")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_status")]
                public string? SettleStatus { get; set; }

                /// <summary>
                /// CPS佣金
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cps")]
                [System.Text.Json.Serialization.JsonPropertyName("cps")]
                public int CPS { get; set; }

                /// <summary>
                /// 技术服务费
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_charge")]
                [System.Text.Json.Serialization.JsonPropertyName("service_charge")]
                public int ServiceCharge { get; set; }

                /// <summary>
                /// 结算完成时间
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settled_at")]
                [System.Text.Json.Serialization.JsonPropertyName("settled_at")]
                public string? SettledAt { get; set; }

                /// <summary>
                /// 结算渠道枚举值：1：微信 2：支付宝
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_way")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_way")]
                public string? SettleWay { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_param_list")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_param_list")]
                public SettleParamList[]? SettleParamList { get; set; }
            }

            public class SettleParamList
            {
                /// <summary>
                /// 分账金额
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 分账方商户号
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_uid")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_uid")]
                public string? MerchantUid { get; set; }
            }
        }


        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_tips")]
        [System.Text.Json.Serialization.JsonPropertyName("err_tips")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 订单详情
        /// </summary>
        [Newtonsoft.Json.JsonProperty("platform_order")]
        [System.Text.Json.Serialization.JsonPropertyName("platform_order")]
        public Types.PlatformOrder PlatformOrder { get; set; } = default!;
    }
}
