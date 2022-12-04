namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /data/external/poi/service_user 接口的响应。</para>
    /// </summary>
    public class DataExternalPOIServiceUserResponse : DouyinOpenResponse<DataExternalPOIServiceUserResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DataExternalPOIUserResponse.Types.Data
            {
            }
        }
    }
}
