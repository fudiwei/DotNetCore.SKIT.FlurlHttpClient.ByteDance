using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /gift/top_gift 接口的请求。</para>
    /// </summary>
    public class WebcastGiftTopGiftRequest : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小玩法的 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_id")]
        [System.Text.Json.Serialization.JsonPropertyName("room_id")]
        public string RoomId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置置顶礼物的礼物 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sec_gift_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("sec_gift_id_list")]
        public IList<string> GiftIdList { get; set; } = new List<string>();
    }
}
