namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/game/console 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardGameConsoleResponse : DouyinOpenResponse<DataExternalBillboardGameConsoleResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
