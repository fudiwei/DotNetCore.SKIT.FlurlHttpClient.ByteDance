namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /address/update 接口的请求。</para>
    /// </summary>
    public class AddressUpdateRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Address
            {
                /// <summary>
                /// 获取或设置地址 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int AddressId { get; set; }

                /// <summary>
                /// 获取或设置收件人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                public string Reciever { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系方式类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("link_type")]
                [System.Text.Json.Serialization.JsonPropertyName("link_type")]
                public int ContactType { get; set; }

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                public string? MobileNumber { get; set; }

                /// <summary>
                /// 获取或设置固话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fixed_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("fixed_phone")]
                public string? TeleNumber { get; set; }

                /// <summary>
                /// 获取或设置省份 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_id")]
                [System.Text.Json.Serialization.JsonPropertyName("province_id")]
                public int ProvinceId { get; set; }

                /// <summary>
                /// 获取或设置城市 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city_id")]
                [System.Text.Json.Serialization.JsonPropertyName("city_id")]
                public int CityId { get; set; }

                /// <summary>
                /// 获取或设置区县 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("town_id")]
                [System.Text.Json.Serialization.JsonPropertyName("town_id")]
                public int DistrictId { get; set; }

                /// <summary>
                /// 获取或设置街道 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("street_id")]
                [System.Text.Json.Serialization.JsonPropertyName("street_id")]
                public int? StreetId { get; set; }

                /// <summary>
                /// 获取或设置详情地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail")]
                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                public string Detail { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置售后地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public Types.Address Address { get; set; } = new Types.Address();
    }
}
