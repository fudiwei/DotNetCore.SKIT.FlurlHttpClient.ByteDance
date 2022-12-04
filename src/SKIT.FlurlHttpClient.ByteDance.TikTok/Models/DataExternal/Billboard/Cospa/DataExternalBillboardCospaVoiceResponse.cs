namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/cospa/voice_control 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardCospaVoiceResponse : TikTokResponse<DataExternalBillboardCospaVoiceResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardSportOverallResponse.Types.Data
            {
            }
        }
    }
}
