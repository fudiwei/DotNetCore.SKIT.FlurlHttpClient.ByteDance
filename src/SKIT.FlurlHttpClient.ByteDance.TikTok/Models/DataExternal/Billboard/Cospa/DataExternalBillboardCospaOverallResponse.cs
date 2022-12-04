namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/cospa/overall 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardCospaOverallResponse : TikTokResponse<DataExternalBillboardCospaOverallResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
