namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/file/image/ad 接口的响应。</para>
    /// </summary>
    public class FileImageAdvertisingResponse : OceanEngineResponse<FileImageAdvertisingResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : FileImageAdvertiserResponse.Types.Data
            {
                /// <summary>
                /// 获取或设置素材 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_id")]
                [System.Text.Json.Serialization.JsonPropertyName("material_id")]
                public long MaterialId { get; set; }
            }
        }
    }
}
