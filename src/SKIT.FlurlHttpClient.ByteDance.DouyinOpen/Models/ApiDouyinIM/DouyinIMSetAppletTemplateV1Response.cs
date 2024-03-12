namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/im/set_applet_template/ 接口的响应。</para>
    /// </summary>
    public class DouyinIMSetAppletTemplateV1Response : DouyinOpenResponse<DouyinIMSetAppletTemplateV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("card_template_id")]
                public string CardTemplateId { get; set; } = default!;
            }
        }
    }
}
