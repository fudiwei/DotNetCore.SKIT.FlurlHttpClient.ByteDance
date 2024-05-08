using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /gift/top_gift 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-04-01 下线。")]
    public class WebcastGiftTopGiftResponse : DouyinMicroAppWebcastResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置成功置顶的礼物 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_top_gift_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("success_top_gift_id_list")]
                public string[] SuccessfulGiftIdList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
