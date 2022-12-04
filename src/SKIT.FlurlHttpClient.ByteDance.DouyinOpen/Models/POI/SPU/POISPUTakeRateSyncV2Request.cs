namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/spu/take_rate/sync 接口的请求。</para>
    /// </summary>
    public class POISPUTakeRateSyncV2Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置 SPU 外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("spu_ext_id")]
        public string SPUExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分佣率（单位：万分数）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("take_rate")]
        [System.Text.Json.Serialization.JsonPropertyName("take_rate")]
        public double TakeRate { get; set; }

        /// <summary>
        /// 获取或设置抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("douyin_id")]
        [System.Text.Json.Serialization.JsonPropertyName("douyin_id")]
        public string DouyinId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置在线状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
