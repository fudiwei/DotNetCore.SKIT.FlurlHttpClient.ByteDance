using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_created_subscribe_notification_tpl_list 接口的请求。</para>
    /// </summary>
    public class AppsCapacityQueryCreatedSubscribeNotificationTemplateListV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：50</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; } = 50;
    }
}
