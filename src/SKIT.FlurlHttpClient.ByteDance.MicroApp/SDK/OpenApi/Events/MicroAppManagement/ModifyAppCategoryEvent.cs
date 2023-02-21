namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Events
{
    /// <summary>
    /// <para>表示 EVENT.MODIFY_APP_CATEGORY 事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/add-category </para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/API/smallprogram/auth-app-manage/base-info/supply-category </para>
    /// </summary>
    public class ModifyAppCategoryEvent : ByteDanceMicroAppOpenApiEvent, ByteDanceMicroAppOpenApiEvent.Serialization.IJsonSerializable, ByteDanceMicroAppOpenApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class ModifyResult
            {
                /// <summary>
                /// 获取或设置类目 ID 字符串（以逗号分隔）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                [System.Xml.Serialization.XmlElement("category")]
                public string CategoryIdString { get; set; } = default!;

                /// <summary>
                /// 获取或设置类目名称字符串（以短横线分隔）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("categoryName")]
                [System.Text.Json.Serialization.JsonPropertyName("categoryName")]
                [System.Xml.Serialization.XmlElement("categoryName")]
                public string CategoryNameString { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置审核拒绝原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                [System.Xml.Serialization.XmlElement("reason", IsNullable = true)]
                public string? RejectReason { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置修改结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ModifyAppCategoryResults")]
        [System.Text.Json.Serialization.JsonPropertyName("ModifyAppCategoryResults")]
        [System.Xml.Serialization.XmlElement("ModifyAppCategoryResults", Type = typeof(Types.ModifyResult))]
        public Types.ModifyResult[] ModifyResultList { get; set; } = default!;
    }
}
