using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /user/data/add/ 接口的请求。</para>
    /// </summary>
    public class UserDataAddRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置要读取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> FieldList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置数据格式。
        /// <para>默认值："text"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_format")]
        [System.Text.Json.Serialization.JsonPropertyName("data_format")]
        public string DataFormat { get; set; } = "text";

        /// <summary>
        /// 获取或设置数据分类列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_selection_list")]
        [System.Text.Json.Serialization.JsonPropertyName("category_selection_list")]
        public IList<string> CategorySelectionList { get; set; } = new List<string>();

        public UserDataAddRequest SetCompleteFields()
        {
            FieldList ??= new List<string>();
            FieldList.Clear();
            FieldList.Add("request_id");
            return this;
        }
    }
}
