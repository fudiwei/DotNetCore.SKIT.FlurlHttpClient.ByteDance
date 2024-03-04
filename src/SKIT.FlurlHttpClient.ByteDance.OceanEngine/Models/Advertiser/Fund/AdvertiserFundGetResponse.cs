namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/advertiser/fund/get 接口的响应。</para>
    /// </summary>
    public class AdvertiserFundGetResponse : OceanEngineResponse<AdvertiserFundGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置广告主 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("advertiser_id")]
                [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
                public long AdvertiserId { get; set; }

                /// <summary>
                /// 获取或设置广告主名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置联系邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("emal")]
                [System.Text.Json.Serialization.JsonPropertyName("emal")]
                public string Email { get; set; } = default!;

                /// <summary>
                /// 获取或设置账户余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance")]
                [System.Text.Json.Serialization.JsonPropertyName("balance")]
                public decimal TotalBalance { get; set; }

                /// <summary>
                /// 获取或设置账户可用余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_balance")]
                [System.Text.Json.Serialization.JsonPropertyName("valid_balance")]
                public decimal ValidBalance { get; set; }

                /// <summary>
                /// 获取或设置现金余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cash")]
                [System.Text.Json.Serialization.JsonPropertyName("cash")]
                public decimal TotalCash { get; set; }

                /// <summary>
                /// 获取或设置现金余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_cash")]
                [System.Text.Json.Serialization.JsonPropertyName("valid_cash")]
                public decimal ValidCash { get; set; }

                /// <summary>
                /// 获取或设置赠款余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grant")]
                [System.Text.Json.Serialization.JsonPropertyName("grant")]
                public decimal TotalGrant { get; set; }

                /// <summary>
                /// 获取或设置默认广告位可用赠款余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("default_grant")]
                [System.Text.Json.Serialization.JsonPropertyName("default_grant")]
                public decimal DefaultGrant { get; set; }

                /// <summary>
                /// 获取或设置通用广告位可用赠款余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("common_grant")]
                [System.Text.Json.Serialization.JsonPropertyName("common_grant")]
                public decimal CommonGrant { get; set; }

                /// <summary>
                /// 获取或设置搜索广告位可用赠款余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("search_grant")]
                [System.Text.Json.Serialization.JsonPropertyName("search_grant")]
                public decimal SearchGrant { get; set; }

                /// <summary>
                /// 获取或设置穿山甲广告位可用赠款余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("union_grant")]
                [System.Text.Json.Serialization.JsonPropertyName("union_grant")]
                public decimal UnionGrant { get; set; }

                /// <summary>
                /// 获取或设置赠款可用余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_grant")]
                [System.Text.Json.Serialization.JsonPropertyName("valid_grant")]
                public decimal ValidGrant { get; set; }

                /// <summary>
                /// 获取或设置返货余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_goods_abs")]
                [System.Text.Json.Serialization.JsonPropertyName("return_goods_abs")]
                public decimal? TotalReturnGoodsABS { get; set; }

                /// <summary>
                /// 获取或设置返货可用余额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_return_goods_abs")]
                [System.Text.Json.Serialization.JsonPropertyName("valid_return_goods_abs")]
                public decimal? ValidReturnGoodsABS { get; set; }

                /// <summary>
                /// 获取或设置返货支出（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_goods_cost")]
                [System.Text.Json.Serialization.JsonPropertyName("return_goods_cost")]
                public decimal? TotalReturnGoodsCost { get; set; }
            }
        }
    }
}
