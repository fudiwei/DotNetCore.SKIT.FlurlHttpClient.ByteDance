namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/getOutRange 接口的请求。</para>
    /// </summary>
    public class LogisticsGetOutRangeRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class Address
            {
                /// <summary>
                /// 获取或设置国家编码。
                /// <para>默认值：CHN</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("country_code")]
                [System.Text.Json.Serialization.JsonPropertyName("country_code")]
                public string CountryCode { get; set; } = "CHN";

                /// <summary>
                /// 获取或设置省份名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_name")]
                [System.Text.Json.Serialization.JsonPropertyName("province_name")]
                public string ProvinceName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置城市名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city_name")]
                [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                public string CityName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置区县名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("district_name")]
                [System.Text.Json.Serialization.JsonPropertyName("district_name")]
                public string DistrictName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置街道名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("street_name")]
                [System.Text.Json.Serialization.JsonPropertyName("street_name")]
                public string? StreetName { get; set; }

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_address")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_address")]
                public string Detail { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置快递公司编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_code")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
        public string LogisticsCompanyCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发货地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender_address")]
        [System.Text.Json.Serialization.JsonPropertyName("sender_address")]
        public Types.Address SenderAddress { get; set; } = new Types.Address();

        /// <summary>
        /// 获取或设置收件地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver_address")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver_address")]
        public Types.Address ReceiverAddress { get; set; } = new Types.Address();
    }
}
