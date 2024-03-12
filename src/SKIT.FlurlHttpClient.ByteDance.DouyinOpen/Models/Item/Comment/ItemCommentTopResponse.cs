namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /item/comment/top/ 接口的响应。</para>
    /// </summary>
    public class ItemCommentTopResponse : DouyinOpenResponse<ItemCommentTopResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }
        }
    }
}
