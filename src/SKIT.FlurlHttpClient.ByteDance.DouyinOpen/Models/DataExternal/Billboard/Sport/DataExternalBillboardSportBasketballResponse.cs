namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/sport/basketball 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardSportBasketballResponse : DouyinOpenResponse<DataExternalBillboardSportBasketballResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
