namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/car/comment 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardCarCommentResponse : TikTokResponse<DataExternalBillboardCarCommentResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
