namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/icp_record/query_pre_approval_item_type_list/ 接口的响应。</para>
    /// </summary>
    public class OpenAppsICPRecordQueryPreApprovalItemTypeListV1Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class PreApprovalItemTypeInfo
                    {
                        /// <summary>
                        /// 获取或设置前置审批类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pre_approval_item_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pre_approval_item_id")]
                        public int PreApprovalItemTypeId { get; set; }

                        /// <summary>
                        /// 获取或设置前置审批类型名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pre_approval_item_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("pre_approval_item_name")]
                        public string PreApprovalItemTypeName { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置前置审批类型列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pre_approval_item_type_list")]
                [System.Text.Json.Serialization.JsonPropertyName("pre_approval_item_type_list")]
                public Types.PreApprovalItemTypeInfo[] PreApprovalItemTypeList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
