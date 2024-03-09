using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_subscribe_notification_tpl_list 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-30 下线。")]
    public class AppsCapacityQuerySubscribeNotificationTemplateListV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置订阅消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Classification { get; set; }

        /// <summary>
        /// 获取或设置模板类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int TemplateType { get; set; }

        /// <summary>
        /// 获取或设置服务类目 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<int>? CategoryIdList { get; set; }

        /// <summary>
        /// 获取或设置搜索关键词。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Keyword { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：50</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PageSize { get; set; } = 50;
    }
}
