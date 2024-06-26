namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/platform/v2/data_analysis/query_user_portrait_data/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryUserPortraitDataV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class UserPortraitData
                    {
                        /// <summary>
                        /// 获取或设置项目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public int UserCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置总用户数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_user")]
                [System.Text.Json.Serialization.JsonPropertyName("total_user")]
                public int TotalUserCount { get; set; }

                /// <summary>
                /// 获取或设置用户省份画像数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public Types.UserPortraitData[] ProvinceUserPortraitDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户城市画像数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public Types.UserPortraitData[] CityUserPortraitDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户性别画像数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gender")]
                [System.Text.Json.Serialization.JsonPropertyName("gender")]
                public Types.UserPortraitData[] GenderUserPortraitDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户年龄画像数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("age")]
                [System.Text.Json.Serialization.JsonPropertyName("age")]
                public Types.UserPortraitData[] AgeUserPortraitDataList { get; set; } = default!;
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
