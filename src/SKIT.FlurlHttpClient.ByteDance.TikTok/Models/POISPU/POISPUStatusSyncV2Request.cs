using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/spu/status_sync 接口的请求。</para>
    /// </summary>
    public class POISPUStatusSyncV2Request : TikTokRequest
    {
        /// <summary>
        /// 获取或设置 SPU 外部 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu_ext_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("spu_ext_id_list")]
        public IList<string> SPUExternalIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置在线状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
