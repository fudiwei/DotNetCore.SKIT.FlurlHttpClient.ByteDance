namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/music/soar 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardMusicSoarResponse : TikTokResponse<DataExternalBillboardMusicSoarResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardMusicHotResponse.Types.Data
            {

            }
        }
    }
}
