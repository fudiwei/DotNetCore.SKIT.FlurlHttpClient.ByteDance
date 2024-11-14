namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/compliance/responsible_persons 接口的响应。</para>
    /// </summary>
    public class ProductCreateComplianceResponsiblePersonResponse : TikTokShopResponse<ProductCreateComplianceResponsiblePersonResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置责任人 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("responsible_person_id")]
                [System.Text.Json.Serialization.JsonPropertyName("responsible_person_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string ResponsiblePersonId { get; set; } = default!;
            }
        }
    }
}
