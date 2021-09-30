namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/updateOrder 接口的响应。</para>
    /// </summary>
    public class LogisticsUpdateOrderResponse : TikTokShopResponse<LogisticsUpdateOrderResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置快递单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("track_no")]
                [System.Text.Json.Serialization.JsonPropertyName("track_no")]
                public string LogisticsNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置分拣码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sort_code")]
                [System.Text.Json.Serialization.JsonPropertyName("sort_code")]
                public string? SortCode { get; set; }

                /// <summary>
                /// 获取或设置集包地代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_center_code")]
                [System.Text.Json.Serialization.JsonPropertyName("package_center_code")]
                public string? PackageCenterCode { get; set; }

                /// <summary>
                /// 获取或设置集包地名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_center_name")]
                [System.Text.Json.Serialization.JsonPropertyName("package_center_name")]
                public string? PackageCenterName { get; set; }

                /// <summary>
                /// 获取或设置大头笔编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("short_address_code")]
                [System.Text.Json.Serialization.JsonPropertyName("short_address_code")]
                public string? ShortAddressCode { get; set; }

                /// <summary>
                /// 获取或设置大头笔名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("short_address_name")]
                [System.Text.Json.Serialization.JsonPropertyName("short_address_name")]
                public string? ShortAddressName { get; set; }
            }
        }
    }
}
