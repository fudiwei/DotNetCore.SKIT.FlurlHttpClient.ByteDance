namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/spu/status_sync 接口的响应。</para>
    /// </summary>
    public class POISPUStatusSyncV2Response : TikTokResponse<POISPUStatusSyncV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置 SPU 外部 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_ext_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_ext_id_list")]
                public string[] SPUExternalIdList { get; set; } = default!;
            }
        }
    }
}
