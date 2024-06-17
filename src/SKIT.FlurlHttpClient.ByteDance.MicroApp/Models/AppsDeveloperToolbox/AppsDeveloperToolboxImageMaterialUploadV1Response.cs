namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/developer_toolbox/image_material/upload/ 接口的响应。</para>
    /// </summary>
    public class AppsDeveloperToolboxImageMaterialUploadV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置图片素材 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_material_id")]
                [System.Text.Json.Serialization.JsonPropertyName("image_material_id")]
                public string ImageMaterialId { get; set; } = default!;
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
