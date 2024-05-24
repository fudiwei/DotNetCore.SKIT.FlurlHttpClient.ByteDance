using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v1/capacity/get_aweme_relation_bind_qrcode/ 接口的请求。</para>
    /// </summary>
    public class AppsCapacityGetAwemeRelationBindQrcodeV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置绑定类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置绑定能力标识列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> CapacityKeyList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置是否相同主体。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool? IsCoSubject { get; set; }
    }
}
