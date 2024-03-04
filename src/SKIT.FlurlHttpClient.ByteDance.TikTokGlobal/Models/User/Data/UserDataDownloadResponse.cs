using System.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /user/data/download/ 接口的响应。</para>
    /// </summary>
    public class UserDataDownloadResponse : TikTokV2Response<UserDataDownloadResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
            }
        }

        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && string.IsNullOrEmpty(Error?.Code) && GetRawBytes().Any();
        }
    }
}
