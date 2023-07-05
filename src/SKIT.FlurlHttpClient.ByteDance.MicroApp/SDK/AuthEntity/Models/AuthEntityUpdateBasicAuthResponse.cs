using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityUpdateBasicAuthResponse: ByteDanceMicroAppAuthEntityResponse
    {
        /// <summary>
        /// 任务ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basic_auth_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("basic_auth_taskid")]
        public string BasicAuthTaskid { get; set; }
    }
}
