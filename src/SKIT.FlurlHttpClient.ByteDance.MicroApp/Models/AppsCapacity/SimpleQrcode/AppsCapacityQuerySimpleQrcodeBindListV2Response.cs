namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v2/capacity/query_simple_qr_bind_list/ 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQuerySimpleQrcodeBindListV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Qrcode
                    {
                        /// <summary>
                        /// 获取或设置绑定的链接地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qr_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("qr_url")]
                        public string Url { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置绑定的小程序页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("load_path")]
                        [System.Text.Json.Serialization.JsonPropertyName("load_path")]
                        public string PagePath { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置测试范围。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stage")]
                        [System.Text.Json.Serialization.JsonPropertyName("stage")]
                        public string Stage { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置是否独占该链接作为前缀。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exclusive_qr_url_prefix")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("exclusive_qr_url_prefix")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool IsPrefixExclusive { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置绑定的二维码列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qr_list")]
                [System.Text.Json.Serialization.JsonPropertyName("qr_list")]
                public Types.Qrcode[] QrcodeList { get; set; } = default!;

                /// <summary>
                /// 获取或设置目前绑定的链接数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; } = default!;

                /// <summary>
                /// 获取或设置总共可以绑定的链接数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bind_upper_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("bind_upper_limit")]
                public int BindLimit { get; set; }

                /// <summary>
                /// 获取或设置剩余可以绑定的链接数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bind_rest_count")]
                [System.Text.Json.Serialization.JsonPropertyName("bind_rest_count")]
                public int BindRestCount { get; set; }

                /// <summary>
                /// 获取或设置当月总共可以发布的次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("release_upper_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("release_upper_limit")]
                public int ReleaseLimit { get; set; }

                /// <summary>
                /// 获取或设置当月剩余可以的发布次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("release_rest_count")]
                [System.Text.Json.Serialization.JsonPropertyName("release_rest_count")]
                public int ReleaseRestCount { get; set; }
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
