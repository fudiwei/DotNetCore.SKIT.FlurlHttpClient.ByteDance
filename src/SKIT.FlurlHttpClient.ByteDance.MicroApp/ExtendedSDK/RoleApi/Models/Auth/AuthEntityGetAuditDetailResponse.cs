using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /get_audit_detail 接口的响应。</para>
    /// </summary>
    public class AuthEntityGetAuditDetailResponse : DouyinMicroAppRoleApiResponse
    {
        public static class Types
        {
            public class Material : AuthEntityGetBasicAuthResponse.Types.Material
            {
            }

            public class Qualification : AuthEntityGetBasicAuthResponse.Types.Qualification
            {
            }
        }

        /// <summary>
        /// 获取或设置资质信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualifications")]
        [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
        public Types.Qualification[] QualificationList { get; set; } = default!;
    }
}
