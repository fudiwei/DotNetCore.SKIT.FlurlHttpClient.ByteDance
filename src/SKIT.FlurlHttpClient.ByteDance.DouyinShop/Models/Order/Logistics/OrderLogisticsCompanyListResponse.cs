namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/logisticsCompanyList 接口的响应。</para>
    /// </summary>
    public class OrderLogisticsCompanyListResponse : DouyinShopResponse<OrderLogisticsCompanyListResponse.Types.LogisticsCompany[]>
    {
        public static class Types
        {
            public class LogisticsCompany
            {

                /// <summary>
                /// 获取或设置物流公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int Id { get; set; }

                /// <summary>
                /// 获取或设置物流公司编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string Code { get; set; } = default!;

                /// <summary>
                /// 获取或设置物流公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;
            }
        }
    }
}
