namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/extern/billboard/music/original 接口的响应。</para>
    /// </summary>
    public class DataExternalBillboardMusicOriginalResponse : DouyinOpenResponse<DataExternalBillboardMusicOriginalResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalBillboardMusicHotResponse.Types.Data
            {

            }
        }
    }
}
