namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    using SKIT.FlurlHttpClient.Internal.CodeAnalysis;

    /// <summary>
    /// <para>表示 [POST] /research/user/reposted_videos/ 接口的响应。</para>
    /// </summary>
    public class ResearchUserRepostedVideosResponse : TikTokV2Response<ResearchUserRepostedVideosResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    [DisallowAnalyzerRule("type-declaration/no-external-contract-nested-types", Addition = "SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models." + nameof(ResearchVideoQueryResponse) + "." + nameof(ResearchVideoQueryResponse.Types) + "." + nameof(ResearchVideoQueryResponse.Types.Data) + "." + nameof(ResearchVideoQueryResponse.Types.Data.Types) + "." + nameof(ResearchVideoQueryResponse.Types.Data.Types.Video))]
                    public class Video : ResearchVideoQueryResponse.Types.Data.Types.Video
                    {
                    }
                }

                /// <summary>
                /// 获取或设置视频列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reposted_videos")]
                [System.Text.Json.Serialization.JsonPropertyName("reposted_videos")]
                public List<Types.Video>? VideoList { get; set; }

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? PageCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
