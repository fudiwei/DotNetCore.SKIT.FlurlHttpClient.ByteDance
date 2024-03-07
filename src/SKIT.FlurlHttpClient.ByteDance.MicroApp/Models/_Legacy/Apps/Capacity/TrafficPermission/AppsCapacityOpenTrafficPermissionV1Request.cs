using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/open_traffic_permission 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-02-29 下线。")]
    public class AppsCapacityOpenTrafficPermissionV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置纳税人性质类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tax_nature")]
        [System.Text.Json.Serialization.JsonPropertyName("tax_nature")]
        public int TaxNatureType { get; set; }

        /// <summary>
        /// 获取或设置手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置省份名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province")]
        [System.Text.Json.Serialization.JsonPropertyName("province")]
        public string ProvinceName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置城市名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        [System.Text.Json.Serialization.JsonPropertyName("city")]
        public string CityName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置银行账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_account_number")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_account_number")]
        public string BankAccountNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开户银行名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
        public string BankName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开户支行名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_branch")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_branch")]
        public string? BankBranchName { get; set; }
    }
}
