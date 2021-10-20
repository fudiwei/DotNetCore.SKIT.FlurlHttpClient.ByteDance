namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/car/use 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardCarUseResponse : TikTokResponse<DataExternalBillboardCarUseResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
