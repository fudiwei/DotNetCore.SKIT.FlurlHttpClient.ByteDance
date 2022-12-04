namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/poi/user 接口的响应。</para>
    /// </summary>
    public class DataExternalPOIUserResponse : DouyinOpenResponse<DataExternalPOIUserResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class KeyValue
                    {
                        /// <summary>
                        /// 获取或设置键。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("key")]
                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                        public string Key { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置城市数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city_list")]
                [System.Text.Json.Serialization.JsonPropertyName("city_list")]
                public Types.KeyValue[] CityList { get; set; } = default!;

                /// <summary>
                /// 获取或设置性别数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gender_list")]
                [System.Text.Json.Serialization.JsonPropertyName("gender_list")]
                public Types.KeyValue[] GenderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置年龄数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("age_list")]
                [System.Text.Json.Serialization.JsonPropertyName("age_list")]
                public Types.KeyValue[] AgeList { get; set; } = default!;
            }
        }
    }
}
