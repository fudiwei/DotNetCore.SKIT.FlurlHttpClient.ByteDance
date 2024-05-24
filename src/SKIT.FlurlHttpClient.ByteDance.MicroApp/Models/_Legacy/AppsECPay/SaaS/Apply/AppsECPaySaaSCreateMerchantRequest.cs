using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/ecpay/saas/create_merchant 接口的请求。</para>
    /// </summary>
    public class AppsECPaySaaSCreateMerchantRequest : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class BusinessLicense
            {
                /// <summary>
                /// 获取或设置证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_license_type")]
                [System.Text.Json.Serialization.JsonPropertyName("business_license_type")]
                public int LicenseType { get; set; }

                /// <summary>
                /// 获取或设置证件号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_license_code")]
                [System.Text.Json.Serialization.JsonPropertyName("business_license_code")]
                public string LicenseCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string? LicenseAddress { get; set; }

                /// <summary>
                /// 获取或设置证件正面照片图片 ID 字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_license_picurl")]
                [System.Text.Json.Serialization.JsonPropertyName("business_license_picurl")]
                public IDictionary<string, string> FrontPictureImageIdMap { get; set; } = new Dictionary<string, string>();

                /// <summary>
                /// 获取或设置证件背面照片图片 ID 字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_license_back_picurl")]
                [System.Text.Json.Serialization.JsonPropertyName("business_license_back_picurl")]
                public IDictionary<string, string>? BackPictureImageIdMap { get; set; }

                /// <summary>
                /// 获取或设置证件有效期开始日期字符串（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_date")]
                [System.Text.Json.Serialization.JsonPropertyName("begin_date")]
                public string BeginDateString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件有效期结束日期字符串（格式：yyyyMMdd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_date")]
                [System.Text.Json.Serialization.JsonPropertyName("end_date")]
                public string EndDateString { get; set; } = string.Empty;
            }

            public class LegalPerson
            {
                /// <summary>
                /// 获取或设置证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_type")]
                [System.Text.Json.Serialization.JsonPropertyName("id_type")]
                public int IdType { get; set; }

                /// <summary>
                /// 获取或设置证件号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_no")]
                [System.Text.Json.Serialization.JsonPropertyName("id_no")]
                public string IdNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string IdName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string? IdAddress { get; set; }

                /// <summary>
                /// 获取或设置证件正面照片图片 ID 字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("front_pic_url")]
                [System.Text.Json.Serialization.JsonPropertyName("front_pic_url")]
                public IDictionary<string, string> FrontPictureImageIdMap { get; set; } = new Dictionary<string, string>();

                /// <summary>
                /// 获取或设置证件背面照片图片 ID 字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("back_pic_url")]
                [System.Text.Json.Serialization.JsonPropertyName("back_pic_url")]
                public IDictionary<string, string>? BackPictureImageIdMap { get; set; }

                /// <summary>
                /// 获取或设置证件有效期开始日期字符串（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_date")]
                [System.Text.Json.Serialization.JsonPropertyName("begin_date")]
                public string BeginDateString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件有效期结束日期字符串（格式：yyyyMMdd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exp_date")]
                [System.Text.Json.Serialization.JsonPropertyName("exp_date")]
                public string EndDateString { get; set; } = string.Empty;
            }

            public class MerchantCardInfo
            {
                /// <summary>
                /// 获取或设置银行户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                public string AccountName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置银行账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_no")]
                [System.Text.Json.Serialization.JsonPropertyName("account_no")]
                public string AccountNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开户支行名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_full_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_full_name")]
                public string BankFullName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置结算类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_type")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_type")]
                public int SettleType { get; set; }

                /// <summary>
                /// 获取或设置银行卡类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_type")]
                [System.Text.Json.Serialization.JsonPropertyName("card_type")]
                public string CardType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置支付宝结算类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("alipay_settle_type")]
                [System.Text.Json.Serialization.JsonPropertyName("alipay_settle_type")]
                public int AlipaySettleType { get; set; }

                /// <summary>
                /// 获取或设置支付宝结算账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("alipay_account_no")]
                [System.Text.Json.Serialization.JsonPropertyName("alipay_account_no")]
                public string? AlipayAccountNumber { get; set; }

                /// <summary>
                /// 获取或设置结算证明函图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settlement_cert_pic")]
                [System.Text.Json.Serialization.JsonPropertyName("settlement_cert_pic")]
                public string? SettlementCertificatePictureImageId { get; set; }

                /// <summary>
                /// 获取或设置关系证明函图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("relation_cert_pic")]
                [System.Text.Json.Serialization.JsonPropertyName("relation_cert_pic")]
                public string? RelationCertificatePictureImageId { get; set; }

                /// <summary>
                /// 获取或设置其他证明图片 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("other_cert_pics")]
                [System.Text.Json.Serialization.JsonPropertyName("other_cert_pics")]
                public IList<string>? OtherCertificatePictureImageIdList { get; set; }
            }

            public class MerchantOperationInfo
            {
                /// <summary>
                /// 获取或设置联系人名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("manage_name")]
                [System.Text.Json.Serialization.JsonPropertyName("manage_name")]
                public string ManagerName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系人手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("manage_mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("manage_mobile")]
                public string ManagerMobileNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系人邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("manage_email")]
                [System.Text.Json.Serialization.JsonPropertyName("manage_email")]
                public string ManagerEmail { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系人类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("manage_person_type")]
                [System.Text.Json.Serialization.JsonPropertyName("manage_person_type")]
                public int ManagerType { get; set; }

                /// <summary>
                /// 获取或设置联系人证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_type")]
                [System.Text.Json.Serialization.JsonPropertyName("id_type")]
                public int? ManagerIdType { get; set; }

                /// <summary>
                /// 获取或设置联系人证件号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("manage_id_no")]
                [System.Text.Json.Serialization.JsonPropertyName("manage_id_no")]
                public string ManagerIdNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系人证件有效期开始日期字符串（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_begin_date")]
                [System.Text.Json.Serialization.JsonPropertyName("id_begin_date")]
                public string? ManagerIdBeginDateString { get; set; }

                /// <summary>
                /// 获取或设置联系人证件有效期结束日期字符串（格式：yyyyMMdd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_exp_date")]
                [System.Text.Json.Serialization.JsonPropertyName("id_exp_date")]
                public string? ManagerIdEndDateString { get; set; }

                /// <summary>
                /// 获取或设置联系人证件正面照片图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_front_pic_url")]
                [System.Text.Json.Serialization.JsonPropertyName("id_front_pic_url")]
                public string? ManagerIdFrontPictureImageId { get; set; }

                /// <summary>
                /// 获取或设置联系人证件背面照片图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_back_pic_url")]
                [System.Text.Json.Serialization.JsonPropertyName("id_back_pic_url")]
                public string? ManagerIdBackPictureImageId { get; set; }

                /// <summary>
                /// 获取或设置支付宝账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("alipay_account_no")]
                [System.Text.Json.Serialization.JsonPropertyName("alipay_account_no")]
                public string? AlipayAccountNumber { get; set; }

                /// <summary>
                /// 获取或设置店铺名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_name")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_name")]
                public string? ShopName { get; set; }

                /// <summary>
                /// 获取或设置店铺链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_url")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_url")]
                public string? ShopUrl { get; set; }

                /// <summary>
                /// 获取或设置授权函图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_authorization_letter")]
                [System.Text.Json.Serialization.JsonPropertyName("business_authorization_letter")]
                public string? AuthorizationLetterImageId { get; set; }
            }

            public class Beneficiary
            {
                /// <summary>
                /// 获取或设置受益人证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_type")]
                [System.Text.Json.Serialization.JsonPropertyName("id_type")]
                public int IdType { get; set; }

                /// <summary>
                /// 获取或设置受益人证件号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_no")]
                [System.Text.Json.Serialization.JsonPropertyName("id_no")]
                public string IdNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置受益人证件姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string IdName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置受益人证件地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string? IdAddress { get; set; }

                /// <summary>
                /// 获取或设置受益人证件有效期开始日期字符串（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_date")]
                [System.Text.Json.Serialization.JsonPropertyName("begin_date")]
                public string BeginDateString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置受益人证件有效期结束日期字符串（格式：yyyyMMdd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exp_date")]
                [System.Text.Json.Serialization.JsonPropertyName("exp_date")]
                public string EndDateString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置受益人证件正面照片图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("front_pic_url")]
                [System.Text.Json.Serialization.JsonPropertyName("front_pic_url")]
                public string FrontPictureImageId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置受益人证件背面照片图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("back_pic_url")]
                [System.Text.Json.Serialization.JsonPropertyName("back_pic_url")]
                public string? BackPictureImageId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置小程序 AppId。与字段 <see cref="ComponentAppId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置小程序第三方平台应用 ID。与字段 <see cref="AppId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thirdparty_id")]
        [System.Text.Json.Serialization.JsonPropertyName("thirdparty_id")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// 与字段 <see cref="ComponentAccessToken"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置第三方平台 AccessToken。与字段 <see cref="AccessToken"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("component_access_token")]
        public string? ComponentAccessToken { get; set; }

        /// <summary>
        /// 获取或设置进件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_merchant_id")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置自定义进件单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
        public string OutOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback_url")]
        [System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string NotifyUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置进件渠道列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channels")]
        [System.Text.Json.Serialization.JsonPropertyName("channels")]
        public IList<string> ChannelList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置商户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_type")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_type")]
        public int MerchantType { get; set; }

        /// <summary>
        /// 获取或设置商户名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_name")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户简称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_short_name")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_short_name")]
        public string MerchantShortName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置省份编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province_code")]
        [System.Text.Json.Serialization.JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置城市编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_code")]
        [System.Text.Json.Serialization.JsonPropertyName("city_code")]
        public string CityCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置区县编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district_code")]
        [System.Text.Json.Serialization.JsonPropertyName("district_code")]
        public string DistrictCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置注册地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registered_addr")]
        [System.Text.Json.Serialization.JsonPropertyName("registered_addr")]
        public string RegisteredAddress { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置营业执照信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_license")]
        [System.Text.Json.Serialization.JsonPropertyName("business_license")]
        public Types.BusinessLicense BusinessLicense { get; set; } = new Types.BusinessLicense();

        /// <summary>
        /// 获取或设置法人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_person")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
        public Types.LegalPerson LegalPerson { get; set; } = new Types.LegalPerson();

        /// <summary>
        /// 获取或设置结算账户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_card_info")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_card_info")]
        public Types.MerchantCardInfo MerchantCardInfo { get; set; } = new Types.MerchantCardInfo();

        /// <summary>
        /// 获取或设置商户管理员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_operation_info")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_operation_info")]
        public Types.MerchantOperationInfo MerchantOperationInfo { get; set; } = new Types.MerchantOperationInfo();

        /// <summary>
        /// 获取或设置行业编码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_code")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
        public IList<string> IndustryCodeList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置补充材料图片 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_evidences")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_evidences")]
        public IList<string>? ExtraEvidenceImageIdList { get; set; }

        /// <summary>
        /// 获取或设置行业资质图片 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_info_pic_urls")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_info_pic_urls")]
        public IList<string>? IndustryInfoPictureImageIdList { get; set; }

        /// <summary>
        /// 获取或设置姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_name")]
        [System.Text.Json.Serialization.JsonPropertyName("create_name")]
        public string CreateName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置受益人类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beneficiary_type")]
        [System.Text.Json.Serialization.JsonPropertyName("beneficiary_type")]
        public string? BeneficiaryType { get; set; }

        /// <summary>
        /// 获取或设置受益人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beneficiary")]
        [System.Text.Json.Serialization.JsonPropertyName("beneficiary")]
        public Types.Beneficiary? Beneficiary { get; set; }

        /// <summary>
        /// 获取或设置签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public string? Signature { get; set; }
    }
}
