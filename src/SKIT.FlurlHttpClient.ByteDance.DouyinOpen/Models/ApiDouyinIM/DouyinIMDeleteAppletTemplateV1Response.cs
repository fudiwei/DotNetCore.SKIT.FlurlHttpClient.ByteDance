namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/im/del_applet_template/ 接口的响应。</para>
    /// </summary>
    public class DouyinIMDeleteAppletTemplateV1Response : DouyinOpenResponse<DouyinIMDeleteAppletTemplateV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }
        }
    }
}
