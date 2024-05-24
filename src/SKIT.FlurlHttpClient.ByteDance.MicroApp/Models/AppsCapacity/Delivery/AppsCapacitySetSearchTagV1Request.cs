using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/capacity/set_search_tag/ 接口的请求。</para>
    /// </summary>
    public class AppsCapacitySetSearchTagV1Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class ModifiedTag
            {
                /// <summary>
                /// 获取或设置修改前搜索标签。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("before_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("before_tag")]
                public string OldTag { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置修改后搜索标签。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("search_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("search_tag")]
                public string NewTag { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置新增的搜索标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_tag_list")]
        [System.Text.Json.Serialization.JsonPropertyName("add_tag_list")]
        public IList<string>? AddedTagList { get; set; }

        /// <summary>
        /// 获取或设置删除的搜索标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delete_tag_list")]
        [System.Text.Json.Serialization.JsonPropertyName("delete_tag_list")]
        public IList<string>? DeletedTagList { get; set; }

        /// <summary>
        /// 获取或设置修改的搜索标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modify_tag_list")]
        [System.Text.Json.Serialization.JsonPropertyName("modify_tag_list")]
        public IList<Types.ModifiedTag>? ModifiedTagList { get; set; }
    }
}
