namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/goods/spu/save 接口的响应。</para>
    /// </summary>
    public class GoodLifeGoodsSPUSaveV1Response : DouyinOpenResponse<GoodLifeGoodsSPUSaveV1Response.Types.Data>
    {
        public static class Types
        {
            public class BaseResponse : GoodLifeGoodsCalendarStaticAttributeGroupSaveV1Response.Types.BaseResponse
            {
            }

            public class Data : DouyinOpenResposneData
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_id")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_id")]
                public string SPUId { get; set; } = default!;
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
