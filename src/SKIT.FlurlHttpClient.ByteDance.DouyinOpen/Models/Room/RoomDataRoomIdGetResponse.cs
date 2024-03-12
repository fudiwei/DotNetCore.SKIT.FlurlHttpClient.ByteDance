namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /room/data/room_id/get/ 接口的响应。</para>
    /// </summary>
    public class RoomDataRoomIdGetResponse : DouyinOpenResponse
    {
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int ErrorNumber { get; set; }

        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log_id")]
        [System.Text.Json.Serialization.JsonPropertyName("log_id")]
        public string? LogId { get; set; }

        /// <summary>
        /// 获取或设置直播间 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("room_ids")]
        public string[] RoomIdList { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorNumber == 0;
        }
    }
}
