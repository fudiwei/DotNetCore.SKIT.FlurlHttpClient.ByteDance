namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/food/tutorial 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardFoodTutorialResponse : DouyinOpenResponse<DataExternalBillboardFoodTutorialResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
