namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/logisticsAddSinglePack 接口的响应。</para>
    /// </summary>
    public class OrderLogisticsAddSinglePackageResponse : DouyinShopResponse<OrderLogisticsAddSinglePackageResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置包裹 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pack_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pack_id")]
                public string PackageId { get; set; } = default!;
            }
        }
    }
}
