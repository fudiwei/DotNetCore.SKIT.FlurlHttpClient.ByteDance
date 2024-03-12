namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /im/authorize/status/ 接口的响应。</para>
    /// </summary>
    public class IMAuthorizeStatusResponse : DouyinOpenResponse
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Attribution : IMAuthorizeUserListResponse.Types.Data.Types.AuthUser.Types.Attribution
                    {
                    }
                }

                /// <summary>
                /// 获取或设置授权来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enter_from")]
                [System.Text.Json.Serialization.JsonPropertyName("enter_from")]
                public string EnterFrom { get; set; } = default!;

                /// <summary>
                /// 获取或设置归因信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attribution")]
                [System.Text.Json.Serialization.JsonPropertyName("attribution")]
                public Types.Attribution? Attribution { get; set; }

                /// <summary>
                /// 获取或设置授权状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置自定义参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_im_extra")]
                [System.Text.Json.Serialization.JsonPropertyName("data_im_extra")]
                public string? DataIMExtra { get; set; }

                /// <summary>
                /// 获取或设置页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string? PagePath { get; set; }

                /// <summary>
                /// 获取或设置页面参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query")]
                [System.Text.Json.Serialization.JsonPropertyName("query")]
                public string? PageQuery { get; set; }
            }
        }

        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int ErrorNumber { get; set; }

        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log_id")]
        [System.Text.Json.Serialization.JsonPropertyName("log_id")]
        public string? LogId { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorNumber == 0;
        }
    }
}
