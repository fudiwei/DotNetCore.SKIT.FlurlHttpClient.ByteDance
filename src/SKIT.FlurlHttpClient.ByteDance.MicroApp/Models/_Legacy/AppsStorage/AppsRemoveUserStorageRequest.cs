using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/remove_user_storage 接口的请求。</para>
    /// </summary>
    public class AppsRemoveUserStorageRequest : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class KeyValue : AppsSetUserStorageRequest.Types.KeyValue
            {
            }
        }

        /// <summary>
        /// 获取或设置键值对列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kv_list")]
        [System.Text.Json.Serialization.JsonPropertyName("kv_list")]
        public IList<Types.KeyValue> KeyValueList { get; set; } = new List<Types.KeyValue>();

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会话密钥。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SessionKey { get; set; } = string.Empty;

        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SignMethod { get; set; } = "hmac_sha256";

        /// <summary>
        /// 获取或设置请求签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Signature { get; set; }
    }
}
