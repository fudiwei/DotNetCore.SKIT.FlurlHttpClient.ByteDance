using System;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/ad/get 接口的响应。</para>
    /// </summary>
    public class AdvertisingGetResponse : OceanEngineResponse<AdvertisingGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Advertising
                    {
                        public static class Types
                        {
                            public class DPAProductTarget
                            {
                                /// <summary>
                                /// 获取或设置筛选字段。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string? Title { get; set; }

                                /// <summary>
                                /// 获取或设置定向规则。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rule")]
                                [System.Text.Json.Serialization.JsonPropertyName("rule")]
                                public string? Rule { get; set; }

                                /// <summary>
                                /// 获取或设置字段类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string? Type { get; set; }

                                /// <summary>
                                /// 获取或设置规则值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public string? Value { get; set; }
                            }

                            public class Audience
                            {
                                public static class Types
                                {
                                    public class Location
                                    {
                                        /// <summary>
                                        /// 获取或设置地点名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string? Name { get; set; }

                                        /// <summary>
                                        /// 获取或设置经度。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("long")]
                                        [System.Text.Json.Serialization.JsonPropertyName("long")]
                                        public decimal? Longitude { get; set; }

                                        /// <summary>
                                        /// 获取或设置纬度。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("lat")]
                                        [System.Text.Json.Serialization.JsonPropertyName("lat")]
                                        public decimal? Latitude { get; set; }

                                        /// <summary>
                                        /// 获取或设置半径。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("radius")]
                                        [System.Text.Json.Serialization.JsonPropertyName("radius")]
                                        public int? Radius { get; set; }

                                        /// <summary>
                                        /// 获取或设置省份。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("province")]
                                        [System.Text.Json.Serialization.JsonPropertyName("province")]
                                        public string? Province { get; set; }

                                        /// <summary>
                                        /// 获取或设置城市。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("city")]
                                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                                        public string? City { get; set; }

                                        /// <summary>
                                        /// 获取或设置区县。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("district")]
                                        [System.Text.Json.Serialization.JsonPropertyName("district")]
                                        public string? District { get; set; }

                                        /// <summary>
                                        /// 获取或设置街道。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("street")]
                                        [System.Text.Json.Serialization.JsonPropertyName("street")]
                                        public string? Street { get; set; }

                                        /// <summary>
                                        /// 获取或设置街道号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("street_number")]
                                        [System.Text.Json.Serialization.JsonPropertyName("street_number")]
                                        public string? StreetNumber { get; set; }
                                    }

                                    public class Action
                                    {
                                        /// <summary>
                                        /// 获取或设置行为场景列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("action_scene")]
                                        [System.Text.Json.Serialization.JsonPropertyName("action_scene")]
                                        public string[]? ActionSceneList { get; set; }

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
                                        public long[]? ActionCategoryIdList { get; set; }

                                        /// <summary>
                                        /// 获取或设置行为关键词 ID 列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("action_words")]
                                        [System.Text.Json.Serialization.JsonPropertyName("action_words")]
                                        public long[]? ActionWordIdList { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置地域。
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
                                /// 获取或设置城市 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city")]
                                [System.Text.Json.Serialization.JsonPropertyName("city")]
                                public int[]? CityIdList { get; set; }

                                /// <summary>
                                /// 获取或设置商圈 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("business_ids")]
                                [System.Text.Json.Serialization.JsonPropertyName("business_ids")]
                                public int[]? BusinessIdList { get; set; }

                                /// <summary>
                                /// 获取或设置位置类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("location_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("location_type")]
                                public string? LocationType { get; set; }

                                /// <summary>
                                /// 获取或设置位置信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("geolocation")]
                                [System.Text.Json.Serialization.JsonPropertyName("geolocation")]
                                public Types.Location? Location { get; set; }

                                /// <summary>
                                /// 获取或设置性别类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("gender")]
                                [System.Text.Json.Serialization.JsonPropertyName("gender")]
                                public string? GenderType { get; set; }

                                /// <summary>
                                /// 获取或设置年龄类型列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("age")]
                                [System.Text.Json.Serialization.JsonPropertyName("age")]
                                public string[]? AgeTypeList { get; set; }

                                /// <summary>
                                /// 获取或设置职业类型列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("career")]
                                [System.Text.Json.Serialization.JsonPropertyName("career")]
                                public string[]? CareerTypeList { get; set; }

                                /// <summary>
                                /// 获取或设置定向人群包列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("retargeting_tags_include")]
                                [System.Text.Json.Serialization.JsonPropertyName("retargeting_tags_include")]
                                public long[]? RetargetingTagsIncludedList { get; set; }

                                /// <summary>
                                /// 获取或设置排除人群包列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("retargeting_tags_exclude")]
                                [System.Text.Json.Serialization.JsonPropertyName("retargeting_tags_exclude")]
                                public long[]? RetargetingTagsExcludedList { get; set; }

                                /// <summary>
                                /// 获取或设置行为兴趣。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("interest_action_mode")]
                                [System.Text.Json.Serialization.JsonPropertyName("interest_action_mode")]
                                public string? InterestActionMode { get; set; }

                                /// <summary>
                                /// 获取或设置行为内容信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("action")]
                                [System.Text.Json.Serialization.JsonPropertyName("action")]
                                public Types.Action? Action { get; set; }

                                /// <summary>
                                /// 获取或设置兴趣类目词 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("interest_categories")]
                                [System.Text.Json.Serialization.JsonPropertyName("interest_categories")]
                                public long[]? InterestCategoryIdList { get; set; }

                                /// <summary>
                                /// 获取或设置兴趣关键词 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("interest_words")]
                                [System.Text.Json.Serialization.JsonPropertyName("interest_words")]
                                public long[]? InterestWordIdList { get; set; }

                                /// <summary>
                                /// 获取或设置兴趣分类 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ad_tag")]
                                [System.Text.Json.Serialization.JsonPropertyName("ad_tag")]
                                public long[]? AdTagIdList { get; set; }

                                /// <summary>
                                /// 获取或设置兴趣关键词 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("interest_tags")]
                                [System.Text.Json.Serialization.JsonPropertyName("interest_tags")]
                                public long[]? InterestTagIdList { get; set; }

                                /// <summary>
                                /// 获取或设置 App 行为类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("app_behavior_target")]
                                [System.Text.Json.Serialization.JsonPropertyName("app_behavior_target")]
                                public string? AppBehaviorTarget { get; set; }

                                /// <summary>
                                /// 获取或设置 App 行为分类 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("app_category")]
                                [System.Text.Json.Serialization.JsonPropertyName("app_category")]
                                public long[]? AppCategoryIdList { get; set; }

                                /// <summary>
                                /// 获取或设置 App ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("app_ids")]
                                [System.Text.Json.Serialization.JsonPropertyName("app_ids")]
                                public long[]? AppIdList { get; set; }

                                /// <summary>
                                /// 获取或设置抖音达人互动用户行为类型列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("aweme_fan_behaviors")]
                                [System.Text.Json.Serialization.JsonPropertyName("aweme_fan_behaviors")]
                                public string[]? AwemeFanBehaviorList { get; set; }

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
                                public long[]? AwemeFanCategoryIdList { get; set; }

                                /// <summary>
                                /// 获取或设置抖音达人 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("aweme_fan_accounts")]
                                [System.Text.Json.Serialization.JsonPropertyName("aweme_fan_accounts")]
                                public long[]? AwemeFanAccountIdList { get; set; }

                                /// <summary>
                                /// 获取或设置账号粉丝相似人群列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("aweme_fans_numbers")]
                                [System.Text.Json.Serialization.JsonPropertyName("aweme_fans_numbers")]
                                public int[]? AwemeFanNumberList { get; set; }

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
                                public long[]? FlowPackageIdIncludedList { get; set; }

                                /// <summary>
                                /// 获取或设置排除定向流量包 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("exclude_flow_package")]
                                [System.Text.Json.Serialization.JsonPropertyName("exclude_flow_package")]
                                public long[]? FlowPackageIdExcluedList { get; set; }

                                /// <summary>
                                /// 获取或设置平台列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform")]
                                public string[]? PlatformList { get; set; }

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
                                public string[]? DeviceTypeList { get; set; }

                                /// <summary>
                                /// 获取或设置网络类型列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ac")]
                                [System.Text.Json.Serialization.JsonPropertyName("ac")]
                                public string[]? NetworkTypeList { get; set; }

                                /// <summary>
                                /// 获取或设置运营商列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("carrier")]
                                [System.Text.Json.Serialization.JsonPropertyName("carrier")]
                                public string[]? CarrierList { get; set; }

                                /// <summary>
                                /// 获取或设置新用户使用头条的时间类型列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("activate_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("activate_type")]
                                public string[]? ActivateTypeList { get; set; }

                                /// <summary>
                                /// 获取或设置文章分类列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("article_category")]
                                [System.Text.Json.Serialization.JsonPropertyName("article_category")]
                                public string[]? ArticleCategoryList { get; set; }

                                /// <summary>
                                /// 获取或设置手机品牌列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("device_brand")]
                                [System.Text.Json.Serialization.JsonPropertyName("device_brand")]
                                public string[]? DeviceBrandList { get; set; }

                                /// <summary>
                                /// 获取或设置手机价格区间（单位：元）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("launch_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("launch_price")]
                                public int[]? LaunchPriceRange { get; set; }

                                /// <summary>
                                /// 获取或设置是否启用智能放量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("auto_extend_enabled")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("auto_extend_enabled")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                                public bool? IsAutoExtendEnabled { get; set; }

                                /// <summary>
                                /// 获取或设置可放开定向列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("auto_extend_targets")]
                                [System.Text.Json.Serialization.JsonPropertyName("auto_extend_targets")]
                                public string[]? AutoExtendTargetList { get; set; }
                            }

                            public class CustomAction
                            {
                                /// <summary>
                                /// 获取或设置行为编号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("code")]
                                [System.Text.Json.Serialization.JsonPropertyName("code")]
                                public int Code { get; set; }

                                /// <summary>
                                /// 获取或设置行为天数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("days")]
                                [System.Text.Json.Serialization.JsonPropertyName("days")]
                                public int Days { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置广告计划 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public long? AdvertisingId { get; set; }

                        /// <summary>
                        /// 获取或设置广告计划名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置广告主 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advertiser_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
                        public long? AdvertiserId { get; set; }

                        /// <summary>
                        /// 获取或设置广告组 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("campaign_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
                        public long? CampaignId { get; set; }

                        /// <summary>
                        /// 获取或设置广告计划投放状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string? Status { get; set; }

                        /// <summary>
                        /// 获取或设置广告计划操作状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("opt_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("opt_status")]
                        public string? Operation { get; set; }

                        /// <summary>
                        /// 获取或设置修改时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("modify_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
                        public long? ModifyTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_create_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_create_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                        public DateTimeOffset? CreateTime { get; set; }

                        /// <summary>
                        /// 获取或设置修改时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_modify_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_modify_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                        public DateTimeOffset? UpdateTime { get; set; }

                        /// <summary>
                        /// 获取或设置投放范围。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_range")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_range")]
                        public string? DeliveryRange { get; set; }

                        /// <summary>
                        /// 获取或设置广告位大类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("inventory_catalog")]
                        [System.Text.Json.Serialization.JsonPropertyName("inventory_catalog")]
                        public string? InventoryCatalog { get; set; }

                        /// <summary>
                        /// 获取或设置广告投放位置列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("inventory_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("inventory_type")]
                        public string[]? InventoryType { get; set; }

                        /// <summary>
                        /// 获取或设置优选广告位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("smart_inventory")]
                        [System.Text.Json.Serialization.JsonPropertyName("smart_inventory")]
                        public string? SmartTnventory { get; set; }

                        /// <summary>
                        /// 获取或设置首选场景广告位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_inventory")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_inventory")]
                        public string? SceneInventory { get; set; }

                        /// <summary>
                        /// 获取或设置穿山甲视频创意类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("union_video_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("union_video_type")]
                        public string? UnionVideoType { get; set; }

                        /// <summary>
                        /// 获取或设置展示监测链接列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("track_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("track_url")]
                        public string[]? TrackUrl { get; set; }

                        /// <summary>
                        /// 获取或设置点击监测链接列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("action_track_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("action_track_url")]
                        public string[]? ActionTrackUrl { get; set; }

                        /// <summary>
                        /// 获取或设置视频有效播放监测链接列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_play_effective_track_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_play_effective_track_url")]
                        public string[]? VideoPlayEffectiveTrackUrl { get; set; }

                        /// <summary>
                        /// 获取或设置视频播完监测链接列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_play_done_track_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_play_done_track_url")]
                        public string[]? VideoPlayDoneTrackUrl { get; set; }

                        /// <summary>
                        /// 获取或设置视频播放监测链接列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_play_track_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_play_track_url")]
                        public string[]? VideoPlayTrackUrl { get; set; }

                        /// <summary>
                        /// 获取或设置数据发送方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("track_url_send_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("track_url_send_type")]
                        public string? TrackUrlSendType { get; set; }

                        /// <summary>
                        /// 获取或设置应用下载方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("download_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("download_type")]
                        public string? DownloadType { get; set; }

                        /// <summary>
                        /// 获取或设置数据下载链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("download_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("download_url")]
                        public string? DownloadUrl { get; set; }

                        /// <summary>
                        /// 获取或设置快应用链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quick_app_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("quick_app_url")]
                        public string? QuickAppUrl { get; set; }

                        /// <summary>
                        /// 获取或设置直达备用链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("external_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("external_url")]
                        public string? ExternalUrl { get; set; }

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
                        /// 获取或设置自定义转化目标。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("convert_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("convert_id")]
                        public long? ConvertId { get; set; }

                        /// <summary>
                        /// 获取或设置预定义转化目标。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("external_action")]
                        [System.Text.Json.Serialization.JsonPropertyName("external_action")]
                        public string? ExternalAction { get; set; }

                        /// <summary>
                        /// 获取或设置预定义转化目标列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("external_actions")]
                        [System.Text.Json.Serialization.JsonPropertyName("external_actions")]
                        public string[]? ExternalActionList { get; set; }

                        /// <summary>
                        /// 获取或设置深度转化目标。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deep_external_action")]
                        [System.Text.Json.Serialization.JsonPropertyName("deep_external_action")]
                        public string? DeepExternalAction { get; set; }

                        /// <summary>
                        /// 获取或设置搜索快投关键词状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("feed_delivery_search")]
                        [System.Text.Json.Serialization.JsonPropertyName("feed_delivery_search")]
                        public string? DeedDeliverySearchStatus { get; set; }

                        /// <summary>
                        /// 获取或设置直达链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_url")]
                        public string? OpenUrl { get; set; }

                        /// <summary>
                        /// 获取或设置附加创意类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advanced_creative_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("advanced_creative_type")]
                        public string? AdvancedCreativeType { get; set; }

                        /// <summary>
                        /// 获取或设置游戏应用描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("game_package_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("game_package_desc")]
                        public string? GamePackageDescription { get; set; }

                        /// <summary>
                        /// 获取或设置游戏礼包码 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("game_package_batch_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("game_package_batch_id")]
                        public long? GamePackageBatchId { get; set; }

                        /// <summary>
                        /// 获取或设置游戏图片集 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("game_package_thumbnail_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("game_package_thumbnail_ids")]
                        public string[]? GamePackageThumbnailIdList { get; set; }

                        /// <summary>
                        /// 获取或设置门店推广投放内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("storepro_unit")]
                        [System.Text.Json.Serialization.JsonPropertyName("storepro_unit")]
                        public string? StorePromotionUnit { get; set; }

                        /// <summary>
                        /// 获取或设置门店推广活动 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("storepro_pack_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("storepro_pack_id")]
                        public long? StorePromotionPackageId { get; set; }

                        /// <summary>
                        /// 获取或设置门店类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("store_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("store_type")]
                        public string? StoreType { get; set; }

                        /// <summary>
                        /// 获取或设置门店 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advertiser_store_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("advertiser_store_ids")]
                        public long[]? StoreIdList { get; set; }

                        /// <summary>
                        /// 获取或设置产品目录 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_platform_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_platform_id")]
                        public long? ProductPlatformId { get; set; }

                        /// <summary>
                        /// 获取或设置产品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public string? ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置物件 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("asset_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("asset_id")]
                        public long? AssetId { get; set; }

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
                        public long[]? DPACategoryIdList { get; set; }

                        /// <summary>
                        /// 获取或设置 DPA 商品 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dpa_products")]
                        [System.Text.Json.Serialization.JsonPropertyName("dpa_products")]
                        public long[]? DPAProductIdList { get; set; }

                        /// <summary>
                        /// 获取或设置 DPA 商品投放条件列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dpa_product_target")]
                        [System.Text.Json.Serialization.JsonPropertyName("dpa_product_target")]
                        public Types.DPAProductTarget[]? DPAProductTargetList { get; set; }

                        /// <summary>
                        /// 获取或设置 DPA 广告类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dpa_adtype")]
                        [System.Text.Json.Serialization.JsonPropertyName("dpa_adtype")]
                        public string? DPAAdType { get; set; }

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
                        public string[]? DPAExternalUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置链接类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("params_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("params_type")]
                        public string? ParametersType { get; set; }

                        /// <summary>
                        /// 获取或设置应用包名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("package")]
                        [System.Text.Json.Serialization.JsonPropertyName("package")]
                        public string? Package { get; set; }

                        /// <summary>
                        /// 获取或设置投放内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_type")]
                        public string? PromotionType { get; set; }

                        /// <summary>
                        /// 获取或设置抖音号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aweme_account")]
                        [System.Text.Json.Serialization.JsonPropertyName("aweme_account")]
                        public string? AwemeAccount { get; set; }

                        /// <summary>
                        /// 获取或设置预约链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subscribe_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("subscribe_url")]
                        public string? SubscribeTrl { get; set; }

                        /// <summary>
                        /// 获取或设置表单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("form_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("form_id")]
                        public string? FormId { get; set; }

                        /// <summary>
                        /// 获取或设置表单位置索引。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("form_index")]
                        [System.Text.Json.Serialization.JsonPropertyName("form_index")]
                        public int? FormIndex { get; set; }

                        /// <summary>
                        /// 获取或设置应用描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_desc")]
                        public string? AppDescription { get; set; }

                        /// <summary>
                        /// 获取或设置应用介绍。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_introduction")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_introduction")]
                        public string? AppIntroduction { get; set; }

                        /// <summary>
                        /// 获取或设置应用图片集 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_thumbnails")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_thumbnails")]
                        public string[]? AppThumbnailIdList { get; set; }

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
                        /// 获取或设置定向包 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audience_package_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("audience_package_id")]
                        public long? AudiencePackageId { get; set; }

                        /// <summary>
                        /// 获取或设置受众信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audience")]
                        [System.Text.Json.Serialization.JsonPropertyName("audience")]
                        public Types.Audience? Audience { get; set; }

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
                        /// 获取或设置是否启用 LBS 地域匹配。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dpa_lbs")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("dpa_lbs")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool? IsDPALBSEnabled { get; set; }

                        /// <summary>
                        /// 获取或设置是否启用城市地域匹配。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dpa_city")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("dpa_city")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool? IsDPACityEnabled { get; set; }

                        /// <summary>
                        /// 获取或设置是否启用省份地域匹配。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dpa_province")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("dpa_province")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool? IsDPAProvinceEnabled { get; set; }

                        /// <summary>
                        /// 获取或设置是否启用 DPA 行为重定向。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dpa_local_audience")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("dpa_local_audience")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool? IsDPALocalAudienceEnabled { get; set; }

                        /// <summary>
                        /// 获取或设置目标优化类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value_optimized_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("value_optimized_type")]
                        public int? ValueOptimizedType { get; set; }

                        /// <summary>
                        /// 获取或设置是否启用价值优选。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value_optimized_open")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("value_optimized_open")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool? IsValueOptimizedEnabled { get; set; }

                        /// <summary>
                        /// 获取或设置资产 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("asset_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("asset_ids")]
                        public long[]? AssetIdList { get; set; }

                        /// <summary>
                        /// 获取或设置包含人群包列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("include_custom_actions")]
                        [System.Text.Json.Serialization.JsonPropertyName("include_custom_actions")]
                        public Types.CustomAction[]? CustomActionIncludedList { get; set; }

                        /// <summary>
                        /// 获取或设置排除人群包列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exclude_custom_actions")]
                        [System.Text.Json.Serialization.JsonPropertyName("exclude_custom_actions")]
                        public Types.CustomAction[]? CustomActionExcludedList { get; set; }

                        /// <summary>
                        /// 获取或设置 DPA 商品重定向推荐类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dpa_recommend_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("dpa_recommend_type")]
                        public int? DPARecommendType { get; set; }

                        /// <summary>
                        /// 获取或设置投放场景出价方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("smart_bid_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("smart_bid_type")]
                        public string? SmartBidType { get; set; }

                        /// <summary>
                        /// 获取或设置是否调整自动出价。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adjust_cpa")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("adjust_cpa")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
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
                        public decimal? Budget { get; set; }

                        /// <summary>
                        /// 获取或设置预算类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("budget_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("budget_mode")]
                        public string? BudgetMode { get; set; }

                        /// <summary>
                        /// 获取或设置投放时间类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("schedule_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("schedule_type")]
                        public string? ScheduleType { get; set; }

                        /// <summary>
                        /// 获取或设置投放起始时间字符串（格式：yyyy-MM-dd HH:mm）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                        public string? StartTimeString { get; set; }

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
                        /// 获取或设置出价方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pricing")]
                        [System.Text.Json.Serialization.JsonPropertyName("pricing")]
                        public string? PricingType { get; set; }

                        /// <summary>
                        /// 获取或设置点击出价/展示出价（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bid")]
                        [System.Text.Json.Serialization.JsonPropertyName("bid")]
                        public decimal? Bid { get; set; }

                        /// <summary>
                        /// 获取或设置目标转化出价/预期成本（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cpa_bid")]
                        [System.Text.Json.Serialization.JsonPropertyName("cpa_bid")]
                        public decimal? CPABid { get; set; }

                        /// <summary>
                        /// 获取或设置深度优化方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deep_bid_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("deep_bid_type")]
                        public string? DeepBidType { get; set; }

                        /// <summary>
                        /// 获取或设置深度优化出价（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deep_cpabid")]
                        [System.Text.Json.Serialization.JsonPropertyName("deep_cpabid")]
                        public decimal? DeepCPABid { get; set; }

                        /// <summary>
                        /// 获取或设置鲁班目标 ROI 出价策略系数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("luban_roi_goal")]
                        [System.Text.Json.Serialization.JsonPropertyName("luban_roi_goal")]
                        public decimal? LubanROIGoal { get; set; }

                        /// <summary>
                        /// 获取或设置深度转化 ROI 系数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("roi_goal")]
                        [System.Text.Json.Serialization.JsonPropertyName("roi_goal")]
                        public decimal? DeepROIGoal { get; set; }
                    }

                    public class Pagination : AgentAdvertiserSelectResponse.Types.Data.Types.Pagination
                    {
                    }
                }

                /// <summary>
                /// 获取或设置广告计划列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public static Types.Advertising[] AdvertisingList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public static Types.Pagination Pagination { get; set; } = default!;
            }
        }
    }
}
