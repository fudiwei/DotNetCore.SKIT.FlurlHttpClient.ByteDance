namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/im/del_applet_template/ 接口的请求。</para>
    /// </summary>
    public class DouyinIMDeleteAppletTemplateV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CardTemplateId { get; set; } = string.Empty;
    }
}
