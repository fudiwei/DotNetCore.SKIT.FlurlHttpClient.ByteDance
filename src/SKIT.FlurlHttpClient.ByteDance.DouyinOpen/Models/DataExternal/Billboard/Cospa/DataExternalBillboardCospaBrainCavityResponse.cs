namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/cospa/brain_cavity 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardCospaBrainCavityResponse : DouyinOpenResponse<DataExternalBillboardCospaBrainCavityResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
