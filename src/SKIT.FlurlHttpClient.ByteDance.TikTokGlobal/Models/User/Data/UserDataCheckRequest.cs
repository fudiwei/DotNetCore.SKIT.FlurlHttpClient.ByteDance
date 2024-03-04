using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /user/data/check/ 接口的请求。</para>
    /// </summary>
    public class UserDataCheckRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置要读取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> FieldList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置申请 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        [System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public long RequestId { get; set; }

        public UserDataCheckRequest SetCompleteFields()
        {
            FieldList ??= new List<string>();
            FieldList.Clear();
            FieldList.Add("request_id");
            FieldList.Add("apply_time");
            FieldList.Add("collect_time");
            FieldList.Add("status");
            FieldList.Add("data_format");
            FieldList.Add("category_selection_list");
            return this;
        }
    }
}
