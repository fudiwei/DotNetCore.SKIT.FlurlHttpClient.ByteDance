namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/uploadVideoAsync 接口的响应。</para>
    /// </summary>
    public class MaterialUploadVideoAsyncResponse : TikTokShopResponse<MaterialUploadVideoAsyncResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置素材 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("object_id")]
                [System.Text.Json.Serialization.JsonPropertyName("object_id")]
                public string ObjectId { get; set; } = default!;

                /// <summary>
                /// 获取或设置上级文件夹 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parent_id")]
                [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
                public string? ParentObjectId { get; set; }

                /// <summary>
                /// 获取或设置是否是新建。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_new")]
                [System.Text.Json.Serialization.JsonPropertyName("is_new")]
                public bool IsNew { get; set; }

                /// <summary>
                /// 获取或设置素材审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                public int AuditStatus { get; set; }
            }
        }
    }
}
