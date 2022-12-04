namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/cospa/qing_man 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardCospaQingmanResponse : DouyinOpenResponse<DataExternalBillboardCospaQingmanResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
