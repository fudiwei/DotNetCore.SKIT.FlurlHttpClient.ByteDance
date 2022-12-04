namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/music/original 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardMusicOriginalResponse : TikTokResponse<DataExternalBillboardMusicOriginalResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardMusicHotResponse.Types.Data
            {

            }
        }
    }
}
