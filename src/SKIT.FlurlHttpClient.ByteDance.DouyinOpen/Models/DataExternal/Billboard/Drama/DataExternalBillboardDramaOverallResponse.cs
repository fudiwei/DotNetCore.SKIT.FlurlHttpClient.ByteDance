namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/drama/overall 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardDramaOverallResponse : DouyinOpenResponse<DataExternalBillboardDramaOverallResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
