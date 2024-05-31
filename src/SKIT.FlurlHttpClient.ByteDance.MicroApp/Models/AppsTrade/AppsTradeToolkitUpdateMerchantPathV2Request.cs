using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/toolkit/update_merchant_path 接口的请求。</para>
    /// </summary>
    public class AppsTradeToolkitUpdateMerchantPathV2Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class PathData
            {
                /// <summary>
                /// 获取或设置跳转路径类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path_type")]
                [System.Text.Json.Serialization.JsonPropertyName("path_type")]
                public int PathType { get; set; }

                /// <summary>
                /// 获取或设置跳转路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string Path { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置绑定的小程序类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_biz_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_biz_type")]
        public int BindBusinessType { get; set; }

        /// <summary>
        /// 获取或设置商家团购账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_id")]
        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置跳转路径列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path_data_list")]
        [System.Text.Json.Serialization.JsonPropertyName("path_data_list")]
        public IList<Types.PathData> PathDataList { get; set; } = new List<Types.PathData>();
    }
}
