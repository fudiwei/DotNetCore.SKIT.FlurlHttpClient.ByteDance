using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityGetAuditDetailRequest : ByteDanceMicroAppAuthEntityRequest
    {
        /// <summary>
        /// <inheritdoc />
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string AccessToken { get; set; }

        /// <summary>
        /// 获取或设置小程序的 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppAuthEntityClient"/> 时的 <see cref="ByteDanceMicroAppAuthEntityClient.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 1：基础认证 2：类目认证 3：授权函认证
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_type")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public int AuthType { get; set; }

        /// <summary>
        /// 审核任务ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_taskid")]
        public string AuthTaskid { get; set; }
    }

    public class AuthEntityGetAuditDetailResponse : ByteDanceMicroAppAuthEntityResponse
    {
        public static class Types
        {
            public class AllQualification
            {
                /// <summary>
                /// 资质审核任务ID
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_taskid")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_taskid")]
                public int AuditTaskid { get; set; }

                /// <summary>
                /// 资质审核状态 1：审核中 2：审核成功 3：审核失败
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                public string AuditStatus { get; set; }

                /// <summary>
                /// 资质材料
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualifications")]
                [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
                public List<CertificateMaterial> Qualifications { get; set; }

                /// <summary>
                /// 资质审核状态 1：审核中 2：审核成功 3：审核失败
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_reason")]
                public string AuditReason { get; set; }
                /// <summary>
                /// 资质审核状态 1：审核中 2：审核成功 3：审核失败
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public DateTime ExpireTime { get; set; }
            }

            public class CertificateMaterial
            {
                /// <summary>
                /// 资质材料类型，目前支持的类型见上传资料接口
                /// <see href="https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/upload-qualification-materials"/>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_type")]
                [System.Text.Json.Serialization.JsonPropertyName("material_type")]
                public int MaterialType { get; set; }
                /// <summary>
                /// 资料过期时间，示例：2029-09-10
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_expiretime")]
                [System.Text.Json.Serialization.JsonPropertyName("material_expiretime")]
                public string MaterialExpiretime { get; set; }

                /// <summary>
                /// 资质材料链接，字符串数组
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_paths")]
                [System.Text.Json.Serialization.JsonPropertyName("material_paths")]
                public List<string> MaterialPaths { get; set; }
            }
        }

        [Newtonsoft.Json.JsonProperty("qualifications")]
        [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
        public List<Types.AllQualification> Qualifications { get; set; }
        
    }
}
