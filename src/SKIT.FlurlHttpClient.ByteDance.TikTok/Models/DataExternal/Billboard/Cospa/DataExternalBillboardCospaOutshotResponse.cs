namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/cospa/out_shot 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardCospaOutshotResponse : TikTokResponse<DataExternalBillboardCospaOutshotResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
