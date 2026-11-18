namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/remove_user_storage 接口的请求。</para>
    /// </summary>
    public class AppsRemoveUserStorageRequest : AppsStorageRequestBase
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
        public List<Types.KeyValue>? KeyValueList { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OpenId { get; set; }
    }
}
