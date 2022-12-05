namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/goods/calendar_stock_group/save 接口的响应。</para>
    /// </summary>
    public class GoodLifeGoodsCalendarStockGroupSaveV1Response : DouyinOpenResponse<GoodLifeGoodsCalendarStockGroupSaveV1Response.Types.Data>
    {
        public static class Types
        {
            public class BaseResponse : GoodLifeGoodsCalendarStaticAttributeGroupSaveV1Response.Types.BaseResponse
            {
            }

            public class Data : DouyinOpenResponseData
            {
            }
        }

        /// <summary>
        /// 获取或设置基础响应。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("BaseResp")]
        [System.Text.Json.Serialization.JsonPropertyName("BaseResp")]
        public Types.BaseResponse BaseResponse { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && BaseResponse?.StatusCode == 0;
        }
    }
}
