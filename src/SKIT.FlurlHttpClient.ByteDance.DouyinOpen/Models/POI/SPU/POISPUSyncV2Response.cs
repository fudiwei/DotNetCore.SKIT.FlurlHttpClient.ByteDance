namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/spu/sync 接口的响应。</para>
    /// </summary>
    public class POISPUSyncV2Response : DouyinOpenResponse<POISPUSyncV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                /// <summary>
                /// 获取或设置 SPU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_id")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_id")]
                public string SPUId { get; set; } = default!;
            }
        }
    }
}
