using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/media/temp/upload 接口的响应。</para>
    /// </summary>
    public class EnterpriseMediaTempUploadResponse : TikTokResponse<EnterpriseMediaTempUploadResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : EnterpriseMediaUploadResponse.Types.Data
            {
            }
        }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.ErrorCode == 0;
        }
    }
}
