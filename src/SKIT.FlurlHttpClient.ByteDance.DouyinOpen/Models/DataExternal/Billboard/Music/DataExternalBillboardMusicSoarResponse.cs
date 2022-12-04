namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/music/soar 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardMusicSoarResponse : DouyinOpenResponse<DataExternalBillboardMusicSoarResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardMusicHotResponse.Types.Data
            {

            }
        }
    }
}
