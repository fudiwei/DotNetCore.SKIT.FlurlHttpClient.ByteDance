namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/uploadImageSync 接口的响应。</para>
    /// </summary>
    public class MaterialUploadImageSyncResponse : DouyinShopResponse<MaterialUploadImageSyncResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : MaterialUploadVideoAsyncResponse.Types.Data
            {
            }
        }
    }
}
