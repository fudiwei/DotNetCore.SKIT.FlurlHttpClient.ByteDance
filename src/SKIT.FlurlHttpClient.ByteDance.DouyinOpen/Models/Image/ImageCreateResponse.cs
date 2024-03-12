using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /image/create 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2023-07-06 下线。")]
    public class ImageCreateResponse : DouyinOpenResponse<ImageCreateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_id")]
                [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                public string ItemId { get; set; } = default!;
            }
        }
    }
}
