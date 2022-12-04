namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/ext/hotel/order/cancel 接口的响应。</para>
    /// </summary>
    public class POIExternalHotelOrderCancelResponse : TikTokResponse<POIExternalHotelOrderCancelResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
            }
        }

        /// <summary>
        /// 获取或设置订单确认状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
