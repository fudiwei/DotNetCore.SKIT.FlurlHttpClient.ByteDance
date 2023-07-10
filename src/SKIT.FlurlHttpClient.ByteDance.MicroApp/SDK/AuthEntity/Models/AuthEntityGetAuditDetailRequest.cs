using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityGetAuditDetailRequest : ByteDanceMicroAppAuthEntityRequest
    {
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
        public string AuthTaskId { get; set; } = string.Empty;
    }
}
