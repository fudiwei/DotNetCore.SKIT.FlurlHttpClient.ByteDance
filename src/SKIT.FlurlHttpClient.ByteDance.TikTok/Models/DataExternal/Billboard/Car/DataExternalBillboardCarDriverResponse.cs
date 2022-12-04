namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/car/driver 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardCarDriverResponse : TikTokResponse<DataExternalBillboardCarDriverResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
