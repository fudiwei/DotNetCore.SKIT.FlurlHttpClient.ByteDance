namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/supplier/sync 接口的响应。</para>
    /// </summary>
    public class POISupplierSyncResponse : DouyinOpenResponse<POISupplierSyncResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                /// <summary>
                /// 获取或设置门店 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_id")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_id")]
                public string SupplierId { get; set; } = default!;
            }
        }
    }
}
