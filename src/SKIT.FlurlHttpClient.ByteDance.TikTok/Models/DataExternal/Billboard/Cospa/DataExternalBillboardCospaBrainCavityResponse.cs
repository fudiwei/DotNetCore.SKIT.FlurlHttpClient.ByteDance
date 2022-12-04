namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/cospa/brain_cavity 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardCospaBrainCavityResponse : TikTokResponse<DataExternalBillboardCospaBrainCavityResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
