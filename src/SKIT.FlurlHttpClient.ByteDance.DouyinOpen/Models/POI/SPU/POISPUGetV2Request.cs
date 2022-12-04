using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/v2/spu/get 接口的请求。</para>
    /// </summary>
    public class POISPUGetV2Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置 SPU 外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SPUExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否需要商品草稿数据。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool RequireSPUDraft { get; set; }

        /// <summary>
        /// 获取或设置需要商品草稿数据的数目。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? SPUDraftCount { get; set; }

        /// <summary>
        /// 获取或设置供应商 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string>? SupplierIdForFilterReasonList { get; set; }
    }
}
