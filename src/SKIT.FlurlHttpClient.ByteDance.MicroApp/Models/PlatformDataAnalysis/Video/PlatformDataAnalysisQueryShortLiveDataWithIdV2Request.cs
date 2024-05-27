using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_short_live_data_with_id/ 接口的请求。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryShortLiveDataWithIdV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置宿主名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("host_name")]
        [System.Text.Json.Serialization.JsonPropertyName("host_name")]
        public string? HostName { get; set; }

        /// <summary>
        /// 获取或设置查询数据的挂载类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_bind_type")]
        [System.Text.Json.Serialization.JsonPropertyName("query_bind_type")]
        public int QueryBindType { get; set; }

        /// <summary>
        /// 获取或设置查询数据的列表类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_data_type")]
        [System.Text.Json.Serialization.JsonPropertyName("query_data_type")]
        public int QueryDataType { get; set; }

        /// <summary>
        /// 获取或设置抖音号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_short_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_short_id_list")]
        public IList<string>? AwemeShortIdList { get; set; }

        /// <summary>
        /// 获取或设置视频 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("item_id_list")]
        public IList<string>? ItemIdList { get; set; }

        /// <summary>
        /// 获取或设置加密的视频 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_item_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("open_item_id_list")]
        public IList<string>? OpenItemIdList { get; set; }

        /// <summary>
        /// 获取或设置直播间 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("room_id_list")]
        public IList<string>? LiveRoomIdList { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_no")]
        [System.Text.Json.Serialization.JsonPropertyName("page_no")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;
    }
}
