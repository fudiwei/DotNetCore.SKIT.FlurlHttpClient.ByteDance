namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/supplier/sync 接口的响应。</para>
    /// </summary>
    public class POISupplierSyncResponse : TikTokResponse<POISupplierSyncResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                /// <summary>
                /// 获取或设置供应商 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_id")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_id")]
                public string SupplierId { get; set; } = default!;
            }
        }
    }
}
