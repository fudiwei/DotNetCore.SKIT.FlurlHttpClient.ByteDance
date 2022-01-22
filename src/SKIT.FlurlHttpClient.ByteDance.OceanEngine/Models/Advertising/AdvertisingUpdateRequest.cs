using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/ad/update 接口的请求。</para>
    /// </summary>
    public class AdvertisingUpdateRequest : OceanEngineRequest
    {
        public static class Types
        {
            public class DPAProductTarget : AdvertisingCreateRequest.Types.DPAProductTarget
            {
            }

            public class AudienceLocation : AdvertisingCreateRequest.Types.AudienceLocation
            {
            }

            public class CustomAction : AdvertisingCreateRequest.Types.CustomAction
            {
            }

        }

        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置广告计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
        public long AdvertisingId { get; set; }

        /// <summary>
        /// 获取或设置广告计划名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? AdvertisingName { get; set; }

        /// <summary>
        /// 获取或设置数据下载链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_url")]
        [System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// 获取或设置应用包名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package")]
        [System.Text.Json.Serialization.JsonPropertyName("package")]
        public string? Package { get; set; }

        /// <summary>
        /// 获取或设置下载类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_type")]
        [System.Text.Json.Serialization.JsonPropertyName("app_type")]
        public string? AppType { get; set; }

        /// <summary>
        /// 获取或设置下载方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("download_mode")]
        public string? DownloadMode { get; set; }

        /// <summary>
        /// 获取或设置直达链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_url")]
        [System.Text.Json.Serialization.JsonPropertyName("open_url")]
        public string? OpenUrl { get; set; }

        /// <summary>
        /// 获取或设置备用链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ulink")]
        [System.Text.Json.Serialization.JsonPropertyName("ulink")]
        public string? ULink { get; set; }

        /// <summary>
        /// 获取或设置直达链接类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dpa_open_url_type")]
        [System.Text.Json.Serialization.JsonPropertyName("dpa_open_url_type")]
        public string? DPAOpenUrlType { get; set; }

        /// <summary>
        /// 获取或设置直达链接字段选择。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dpa_open_url_field")]
        [System.Text.Json.Serialization.JsonPropertyName("dpa_open_url_field")]
        public string? DPAOpenUrlField { get; set; }

        /// <summary>
        /// 获取或设置直达链接列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dpa_open_urls")]
        [System.Text.Json.Serialization.JsonPropertyName("dpa_open_urls")]
        public string[]? DPAOpenUrlList { get; set; }

        /// <summary>
        /// 获取或设置落地页检测参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_url_params")]
        [System.Text.Json.Serialization.JsonPropertyName("external_url_params")]
        public string? ExternalUrlParameters { get; set; }

        /// <summary>
        /// 获取或设置直达链接检测参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_url_params")]
        [System.Text.Json.Serialization.JsonPropertyName("open_url_params")]
        public string? OpenUrlParameters { get; set; }

        /// <summary>
        /// 获取或设置 DPA 投放范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_type")]
        [System.Text.Json.Serialization.JsonPropertyName("category_type")]
        public string? DPACategoryType { get; set; }

        /// <summary>
        /// 获取或设置 DPA 分类 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dpa_categories")]
        [System.Text.Json.Serialization.JsonPropertyName("dpa_categories")]
        public IList<long>? DPACategoryIdList { get; set; }

        /// <summary>
        /// 获取或设置 DPA 商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dpa_products")]
        [System.Text.Json.Serialization.JsonPropertyName("dpa_products")]
        public IList<long>? DPAProductIdList { get; set; }

        /// <summary>
        /// 获取或设置 DPA 商品投放条件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dpa_product_target")]
        [System.Text.Json.Serialization.JsonPropertyName("dpa_product_target")]
        public IList<Types.DPAProductTarget>? DPAProductTargetList { get; set; }

        /// <summary>
        /// 获取或设置落地页链接字段选择。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dpa_external_url_field")]
        [System.Text.Json.Serialization.JsonPropertyName("dpa_external_url_field")]
        public string? DPAExternalUrlField { get; set; }

        /// <summary>
        /// 获取或设置落地页链接列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dpa_external_urls")]
        [System.Text.Json.Serialization.JsonPropertyName("dpa_external_urls")]
        public IList<string>? DPAExternalUrlList { get; set; }

        /// <summary>
        /// 获取或设置链接类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("params_type")]
        [System.Text.Json.Serialization.JsonPropertyName("params_type")]
        public string? ParametersType { get; set; }

        /// <summary>
        /// 获取或设置搜索快投关键词状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feed_delivery_search")]
        [System.Text.Json.Serialization.JsonPropertyName("feed_delivery_search")]
        public string? DeedDeliverySearchStatus { get; set; }

        /// <summary>
        /// 获取或设置定向包 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audience_package_id")]
        [System.Text.Json.Serialization.JsonPropertyName("audience_package_id")]
        public long? AudiencePackageId { get; set; }

        /// <summary>
        /// 获取或设置定向城市。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city")]
        [System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// 获取或设置定向区县。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district")]
        [System.Text.Json.Serialization.JsonPropertyName("district")]
        public string? District { get; set; }

        /// <summary>
        /// 获取或设置行政区域版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_version")]
        [System.Text.Json.Serialization.JsonPropertyName("region_version")]
        public string? RegionVersion { get; set; }

        /// <summary>
        /// 获取或设置定向商圈 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("business_ids")]
        public IList<int>? BusinessIdList { get; set; }

        /// <summary>
        /// 获取或设置定向位置类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location_type")]
        [System.Text.Json.Serialization.JsonPropertyName("location_type")]
        public string? LocationType { get; set; }

        /// <summary>
        /// 获取或设置定向位置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("geolocation")]
        [System.Text.Json.Serialization.JsonPropertyName("geolocation")]
        public Types.AudienceLocation? Location { get; set; }

        /// <summary>
        /// 获取或设置定向性别类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gender")]
        [System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? GenderType { get; set; }

        /// <summary>
        /// 获取或设置定向年龄类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("age")]
        [System.Text.Json.Serialization.JsonPropertyName("age")]
        public IList<string>? AgeTypeList { get; set; }

        /// <summary>
        /// 获取或设置定向职业类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("career")]
        [System.Text.Json.Serialization.JsonPropertyName("career")]
        public IList<string>? CareerTypeList { get; set; }

        /// <summary>
        /// 获取或设置定向定向人群包列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retargeting_tags_include")]
        [System.Text.Json.Serialization.JsonPropertyName("retargeting_tags_include")]
        public IList<long>? RetargetingTagsIncludedList { get; set; }

        /// <summary>
        /// 获取或设置定向排除人群包列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retargeting_tags_exclude")]
        [System.Text.Json.Serialization.JsonPropertyName("retargeting_tags_exclude")]
        public IList<long>? RetargetingTagsExcludedList { get; set; }

        /// <summary>
        /// 获取或设置定向行为兴趣。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("interest_action_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("interest_action_mode")]
        public string? InterestActionMode { get; set; }

        /// <summary>
        /// 获取或设置行为场景列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("action_scene")]
        public IList<string>? ActionSceneList { get; set; }

        /// <summary>
        /// 获取或设置用户发生行为天数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_days")]
        [System.Text.Json.Serialization.JsonPropertyName("action_days")]
        public int? ActionDays { get; set; }

        /// <summary>
        /// 获取或设置行为类目词 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_categories")]
        [System.Text.Json.Serialization.JsonPropertyName("action_categories")]
        public IList<long>? ActionCategoryIdList { get; set; }

        /// <summary>
        /// 获取或设置行为关键词 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_words")]
        [System.Text.Json.Serialization.JsonPropertyName("action_words")]
        public IList<long>? ActionWordIdList { get; set; }

        /// <summary>
        /// 获取或设置兴趣类目词 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("interest_categories")]
        [System.Text.Json.Serialization.JsonPropertyName("interest_categories")]
        public IList<long>? InterestCategoryIdList { get; set; }

        /// <summary>
        /// 获取或设置兴趣关键词 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("interest_words")]
        [System.Text.Json.Serialization.JsonPropertyName("interest_words")]
        public IList<long>? InterestWordIdList { get; set; }

        /// <summary>
        /// 获取或设置抖音达人互动用户行为类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_fan_behaviors")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_fan_behaviors")]
        public IList<string>? AwemeFanBehaviorList { get; set; }

        /// <summary>
        /// 获取或设置抖音达人互动行为时间范围类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_fan_time_scope")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_fan_time_scope")]
        public string? AwemeFanTimeScope { get; set; }

        /// <summary>
        /// 获取或设置抖音达人分类 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_fan_categories")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_fan_categories")]
        public IList<long>? AwemeFanCategoryIdList { get; set; }

        /// <summary>
        /// 获取或设置抖音达人 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_fan_accounts")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_fan_accounts")]
        public List<long>? AwemeFanAccountIdList { get; set; }

        /// <summary>
        /// 获取或设置过滤高活跃用户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filter_aweme_abnormal_active")]
        [System.Text.Json.Serialization.JsonPropertyName("filter_aweme_abnormal_active")]
        public int? FilterAwemeAbnormalActiveType { get; set; }

        /// <summary>
        /// 获取或设置过滤高关注数用户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filter_aweme_fans_count")]
        [System.Text.Json.Serialization.JsonPropertyName("filter_aweme_fans_count")]
        public int? FilterAwemeFanCount { get; set; }

        /// <summary>
        /// 获取或设置过滤高活跃用户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filter_own_aweme_fans")]
        [System.Text.Json.Serialization.JsonPropertyName("filter_own_aweme_fans")]
        public int? FilterOwnAwemeFansType { get; set; }

        /// <summary>
        /// 获取或设置媒体定向类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("superior_popularity_type")]
        [System.Text.Json.Serialization.JsonPropertyName("superior_popularity_type")]
        public string? SuperiorPopularityType { get; set; }

        /// <summary>
        /// 获取或设置定向流量包 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flow_package")]
        [System.Text.Json.Serialization.JsonPropertyName("flow_package")]
        public List<long>? FlowPackageIdIncludedList { get; set; }

        /// <summary>
        /// 获取或设置排除定向流量包 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exclude_flow_package")]
        [System.Text.Json.Serialization.JsonPropertyName("exclude_flow_package")]
        public List<long>? FlowPackageIdExcluedList { get; set; }

        /// <summary>
        /// 获取或设置平台列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("platform")]
        [System.Text.Json.Serialization.JsonPropertyName("platform")]
        public List<string>? PlatformList { get; set; }

        /// <summary>
        /// 获取或设置最低安卓版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("android_osv")]
        [System.Text.Json.Serialization.JsonPropertyName("android_osv")]
        public string? AndroidVersion { get; set; }

        /// <summary>
        /// 获取或设置最低 iOS 版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ios_osv")]
        [System.Text.Json.Serialization.JsonPropertyName("ios_osv")]
        public string? IosVersion { get; set; }

        /// <summary>
        /// 获取或设置设备类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_type")]
        [System.Text.Json.Serialization.JsonPropertyName("device_type")]
        public List<string>? DeviceTypeList { get; set; }

        /// <summary>
        /// 获取或设置网络类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ac")]
        [System.Text.Json.Serialization.JsonPropertyName("ac")]
        public List<string>? NetworkTypeList { get; set; }

        /// <summary>
        /// 获取或设置运营商列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("carrier")]
        [System.Text.Json.Serialization.JsonPropertyName("carrier")]
        public List<string>? CarrierList { get; set; }

        /// <summary>
        /// 获取或设置过滤已安装类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hide_if_exists")]
        [System.Text.Json.Serialization.JsonPropertyName("hide_if_exists")]
        public int? HideIfExistsType { get; set; }

        /// <summary>
        /// 获取或设置过滤已转换类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hide_if_converted")]
        [System.Text.Json.Serialization.JsonPropertyName("hide_if_converted")]
        public int? HideIfConvertedType { get; set; }

        /// <summary>
        /// 获取或设置过滤时间范围类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("converted_time_duration")]
        [System.Text.Json.Serialization.JsonPropertyName("converted_time_duration")]
        public string? ConvertedTimeDurationTypeList { get; set; }

        /// <summary>
        /// 获取或设置新用户使用头条的时间类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activate_type")]
        [System.Text.Json.Serialization.JsonPropertyName("activate_type")]
        public List<string>? ActivateTypeList { get; set; }

        /// <summary>
        /// 获取或设置文章分类列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("article_category")]
        [System.Text.Json.Serialization.JsonPropertyName("article_category")]
        public List<string>? ArticleCategoryList { get; set; }

        /// <summary>
        /// 获取或设置手机品牌列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_brand")]
        [System.Text.Json.Serialization.JsonPropertyName("device_brand")]
        public List<string>? DeviceBrandList { get; set; }

        /// <summary>
        /// 获取或设置手机价格区间（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("launch_price")]
        [System.Text.Json.Serialization.JsonPropertyName("launch_price")]
        public List<int>? LaunchPriceRange { get; set; }

        /// <summary>
        /// 获取或设置是否启用智能放量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auto_extend_enabled")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("auto_extend_enabled")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsAutoExtendEnabled { get; set; }

        /// <summary>
        /// 获取或设置可放开定向列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auto_extend_targets")]
        [System.Text.Json.Serialization.JsonPropertyName("auto_extend_targets")]
        public IList<string>? AutoExtendTargetList { get; set; }

        /// <summary>
        /// 获取或设置是否启用 LBS 地域匹配。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dpa_lbs")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("dpa_lbs")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsDPALBSEnabled { get; set; }

        /// <summary>
        /// 获取或设置是否启用城市地域匹配。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dpa_city")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("dpa_city")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsDPACityEnabled { get; set; }

        /// <summary>
        /// 获取或设置是否启用省份地域匹配。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dpa_province")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("dpa_province")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsDPAProvinceEnabled { get; set; }

        /// <summary>
        /// 获取或设置是否启用 DPA 行为重定向。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dpa_local_audience")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("dpa_local_audience")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsDPALocalAudienceEnabled { get; set; }

        /// <summary>
        /// 获取或设置包含人群包列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("include_custom_actions")]
        [System.Text.Json.Serialization.JsonPropertyName("include_custom_actions")]
        public IList<Types.CustomAction>? CustomActionIncludedList { get; set; }

        /// <summary>
        /// 获取或设置排除人群包列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exclude_custom_actions")]
        [System.Text.Json.Serialization.JsonPropertyName("exclude_custom_actions")]
        public IList<Types.CustomAction>? CustomActionExcludedList { get; set; }

        /// <summary>
        /// 获取或设置 DPA 商品重定向推荐类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dpa_recommend_type")]
        [System.Text.Json.Serialization.JsonPropertyName("dpa_recommend_type")]
        public int? DPARecommendType { get; set; }

        /// <summary>
        /// 获取或设置是否调整自动出价。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adjust_cpa")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("adjust_cpa")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsAutoAdjustCPA { get; set; }

        /// <summary>
        /// 获取或设置竞价策略投放方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flow_control_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("flow_control_mode")]
        public string? FlowControlMode { get; set; }

        /// <summary>
        /// 获取或设置预算（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("budget")]
        [System.Text.Json.Serialization.JsonPropertyName("budget")]
        public double? Budget { get; set; }

        /// <summary>
        /// 获取或设置投放时间类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_type")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_type")]
        public string? ScheduleType { get; set; }

        /// <summary>
        /// 获取或设置投放结束时间字符串（格式：yyyy-MM-dd HH:mm）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public string? EndTimeString { get; set; }

        /// <summary>
        /// 获取或设置投放时段字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schedule_time")]
        [System.Text.Json.Serialization.JsonPropertyName("schedule_time")]
        public string? ScheduleTimeString { get; set; }

        /// <summary>
        /// 获取或设置点击出价/展示出价（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bid")]
        [System.Text.Json.Serialization.JsonPropertyName("bid")]
        public double? Bid { get; set; }

        /// <summary>
        /// 获取或设置目标转化出价/预期成本（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cpa_bid")]
        [System.Text.Json.Serialization.JsonPropertyName("cpa_bid")]
        public double? CPABid { get; set; }

        /// <summary>
        /// 获取或设置深度优化出价（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deep_cpabid")]
        [System.Text.Json.Serialization.JsonPropertyName("deep_cpabid")]
        public double? DeepCPABid { get; set; }

        /// <summary>
        /// 获取或设置鲁班目标 ROI 出价策略系数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("luban_roi_goal")]
        [System.Text.Json.Serialization.JsonPropertyName("luban_roi_goal")]
        public double? LubanROIGoal { get; set; }

        /// <summary>
        /// 获取或设置深度转化 ROI 系数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roi_goal")]
        [System.Text.Json.Serialization.JsonPropertyName("roi_goal")]
        public double? DeepROIGoal { get; set; }

        /// <summary>
        /// 获取或设置展示监测链接列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("track_url")]
        [System.Text.Json.Serialization.JsonPropertyName("track_url")]
        public IList<string>? TrackUrl { get; set; }

        /// <summary>
        /// 获取或设置点击监测链接列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_track_url")]
        [System.Text.Json.Serialization.JsonPropertyName("action_track_url")]
        public IList<string>? ActionTrackUrl { get; set; }

        /// <summary>
        /// 获取或设置视频有效播放监测链接列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_play_effective_track_url")]
        [System.Text.Json.Serialization.JsonPropertyName("video_play_effective_track_url")]
        public IList<string>? VideoPlayEffectiveTrackUrl { get; set; }

        /// <summary>
        /// 获取或设置视频播完监测链接列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_play_done_track_url")]
        [System.Text.Json.Serialization.JsonPropertyName("video_play_done_track_url")]
        public IList<string>? VideoPlayDoneTrackUrl { get; set; }

        /// <summary>
        /// 获取或设置视频播放监测链接列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_play_track_url")]
        [System.Text.Json.Serialization.JsonPropertyName("video_play_track_url")]
        public IList<string>? VideoPlayTrackUrl { get; set; }
    }
}
