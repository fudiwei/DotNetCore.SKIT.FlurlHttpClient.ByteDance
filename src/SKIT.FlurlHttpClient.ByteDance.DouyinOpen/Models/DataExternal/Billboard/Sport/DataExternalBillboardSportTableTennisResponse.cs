namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/sport/table_tennis 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardSportTableTennisResponse : DouyinOpenResponse<DataExternalBillboardSportTableTennisResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
