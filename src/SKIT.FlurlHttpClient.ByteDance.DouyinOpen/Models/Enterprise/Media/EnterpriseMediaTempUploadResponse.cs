namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/media/temp/upload 接口的响应。</para>
    /// </summary>
    public class EnterpriseMediaTempUploadResponse : DouyinOpenResponse<EnterpriseMediaTempUploadResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Media : EnterpriseMediaUploadResponse.Types.Data.Types.Media
                    {
                    }
                }

                /// <summary>
                /// 获取或设置素材信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media")]
                [System.Text.Json.Serialization.JsonPropertyName("media")]
                public Types.Media? Media { get; set; }
            }
        }
    }
}
