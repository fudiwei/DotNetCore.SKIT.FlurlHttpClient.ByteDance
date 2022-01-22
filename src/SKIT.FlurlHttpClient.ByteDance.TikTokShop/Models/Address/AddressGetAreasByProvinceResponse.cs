namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /address/getAreasByProvince 接口的响应。</para>
    /// </summary>
    public class AddressGetAreasByProvinceResponse : TikTokShopResponse<AddressGetAreasByProvinceResponse.Types.Area[]>
    {
        public static class Types
        {
            public class Area
            {
                /// <summary>
                /// 获取或设置编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public int Code { get; set; }

                /// <summary>
                /// 获取或设置上级编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("father_code")]
                [System.Text.Json.Serialization.JsonPropertyName("father_code")]
                public int? FatherCode { get; set; }

                /// <summary>
                /// 获取或设置名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置层级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level")]
                [System.Text.Json.Serialization.JsonPropertyName("level")]
                public string Level { get; set; } = default!;

                /// <summary>
                /// 获取或设置下级地区列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_districts")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_districts")]
                public Area[]? SubAreaList { get; set; }
            }
        }
    }
}
