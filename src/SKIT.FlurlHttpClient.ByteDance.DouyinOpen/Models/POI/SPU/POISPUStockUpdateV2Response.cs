namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/spu/stock_update 接口的响应。</para>
    /// </summary>
    public class POISPUStockUpdateV2Response : DouyinOpenResponse<POISPUStockUpdateV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置 SPU 外部 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_ext_id")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_ext_id")]
                public string SPUExternalId { get; set; } = default!;
            }
        }
    }
}
