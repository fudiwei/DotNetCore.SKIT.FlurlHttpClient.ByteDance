namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/addresSwitchConfig 接口的响应。</para>
    /// </summary>
    public class OrderAddressSwitchConfigResponse : DouyinShopResponse<OrderAddressSwitchConfigResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置审核权限。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorized_status")]
                [System.Text.Json.Serialization.JsonPropertyName("authorized_status")]
                public int AuthorizedStatus { get; set; }
            }
        }
    }
}
