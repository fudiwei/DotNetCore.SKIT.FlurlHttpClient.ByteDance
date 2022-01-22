namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/sdk_share 接口的响应。</para>
    /// </summary>
    public class DataExternalSDKShareResponse : TikTokResponse<DataExternalSDKShareResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                public static class Types
                {
                    public class Result
                    {
                        /// <summary>
                        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("date")]
                        [System.Text.Json.Serialization.JsonPropertyName("date")]
                        public string DateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置累计分享到抖音内且状态已被删除的视频总数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delete_item_total")]
                        [System.Text.Json.Serialization.JsonPropertyName("delete_item_total")]
                        public int DeleteItemTotalCount { get; set; }

                        /// <summary>
                        /// 获取或设置当日分享到抖音的视频数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_item_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_item_count")]
                        public int ShareItemCount { get; set; }

                        /// <summary>
                        /// 获取或设置累计分享到抖音的视频总数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_item_total")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_item_total")]
                        public int ShareItemTotalCount { get; set; }

                        /// <summary>
                        /// 获取或设置当日完成分享的用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_user_count")]
                        public int ShareUserCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result_list")]
                [System.Text.Json.Serialization.JsonPropertyName("result_list")]
                public Types.Result[] ResultList { get; set; } = default!;
            }
        }
    }
}
