namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/sport/soccer 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardSportSoccerResponse : TikTokResponse<DataExternalBillboardSportSoccerResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
