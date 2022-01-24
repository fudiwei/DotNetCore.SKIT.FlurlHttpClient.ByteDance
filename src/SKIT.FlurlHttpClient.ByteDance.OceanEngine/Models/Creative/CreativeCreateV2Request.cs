using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/creative/create_v2 接口的请求。</para>
    /// </summary>
    public class CreativeCreateV2Request : OceanEngineRequest
    {
        public static class Types
        {
            public class Material
            {
                public static class Types
                {
                    public class TemplateData
                    {
                        /// <summary>
                        /// 获取或设置自定义背景图片 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("background_image_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("background_image_id")]
                        public string? ImageMode { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置素材类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("image_mode")]
                public string ImageMode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图片 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("image_ids")]
                public IList<string>? ImageIdList { get; set; }

                /// <summary>
                /// 获取或设置封面图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_id")]
                [System.Text.Json.Serialization.JsonPropertyName("image_id")]
                public string? ImageId { get; set; }

                /// <summary>
                /// 获取或设置视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_id")]
                [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                public string? VideoId { get; set; }

                /// <summary>
                /// 获取或设置 DPA 模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public string? TemplateId { get; set; }

                /// <summary>
                /// 获取或设置 DPA 模板参数列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("template_data_list")]
                public IList<Types.TemplateData>? TemplateDataList { get; set; }
            }

            public class Title
            {
                /// <summary>
                /// 获取或设置创意标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? CreativeTitle { get; set; }

                /// <summary>
                /// 获取或设置创意动态词包 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creative_word_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("creative_word_ids")]
                public IList<long>? CreativeWordIdList { get; set; }

                /// <summary>
                /// 获取或设置 DPA 词包 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dpa_dict_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("dpa_dict_ids")]
                public IList<long>? DPADictionaryIdList { get; set; }
            }

            public class Component
            {
                /// <summary>
                /// 获取或设置组件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("component_id")]
                [System.Text.Json.Serialization.JsonPropertyName("component_id")]
                public string ComponentId { get; set; } = string.Empty;
            }

            public class Creative
            {
                public static class Types
                {
                    public class TemplateData : Material.Types.TemplateData
                    {
                    }

                    public class PlayableInfo
                    {
                        /// <summary>
                        /// 获取或设置基础试玩素材 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("playable_url_basic")]
                        [System.Text.Json.Serialization.JsonPropertyName("playable_url_basic")]
                        public string? BasicPlayableUrl { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置素材类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("image_mode")]
                public string ImageMode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置创意标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置创意动态词包 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creative_word_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("creative_word_ids")]
                public IList<long>? CreativeWordIdList { get; set; }

                /// <summary>
                /// 获取或设置 DPA 词包 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dpa_dict_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("dpa_dict_ids")]
                public IList<long>? DPADictionaryIdList { get; set; }

                /// <summary>
                /// 获取或设置图片 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("image_ids")]
                public IList<string>? ImageIdList { get; set; }

                /// <summary>
                /// 获取或设置封面图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_id")]
                [System.Text.Json.Serialization.JsonPropertyName("image_id")]
                public string? ImageId { get; set; }

                /// <summary>
                /// 获取或设置视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_id")]
                [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                public string? VideoId { get; set; }

                /// <summary>
                /// 获取或设置 DPA 模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public string? TemplateId { get; set; }

                /// <summary>
                /// 获取或设置 DPA 模板参数列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("template_data_list")]
                public IList<Types.TemplateData>? TemplateDataList { get; set; }

                /// <summary>
                /// 获取或设置基础试玩素材信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("playable_info")]
                [System.Text.Json.Serialization.JsonPropertyName("playable_info")]
                public Types.PlayableInfo? PlayableInfo { get; set; }

                /// <summary>
                /// 获取或设置是否将视频的封面和标题同步到图片创意。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("derive_poster_cid")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("derive_poster_cid")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsDerivePosterCreativeId { get; set; }

                /// <summary>
                /// 获取或设置商品库视频模版。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dpa_template")]
                [System.Text.Json.Serialization.JsonPropertyName("dpa_template")]
                public int? DPATemplate { get; set; }

                /// <summary>
                /// 获取或设置商品库视频生成类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dpa_video_template_type")]
                [System.Text.Json.Serialization.JsonPropertyName("dpa_video_template_type")]
                public string? DPAVideoTemplateType { get; set; }

                /// <summary>
                /// 获取或设置自定义商品库视频模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dpa_video_task_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("dpa_video_task_ids")]
                public IList<string>? DPAVideoTaskIdList { get; set; }

                /// <summary>
                /// 获取或设置第三方 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_party_id")]
                [System.Text.Json.Serialization.JsonPropertyName("third_party_id")]
                public string? ThirdPartyId { get; set; }

                /// <summary>
                /// 获取或设置组件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("component_info")]
                [System.Text.Json.Serialization.JsonPropertyName("component_info")]
                public IList<Component>? ComponentList { get; set; }
            }

            public class PromotionCard
            {
                /// <summary>
                /// 获取或设置是否使用门店包。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_store_pack")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_store_pack")]
                public bool IsStorePackEnabled { get; set; }

                /// <summary>
                /// 获取或设置商品卖点列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_selling_points")]
                [System.Text.Json.Serialization.JsonPropertyName("product_selling_points")]
                public IList<string> ProductSellingPointList { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置商品描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_description")]
                [System.Text.Json.Serialization.JsonPropertyName("product_description")]
                public string ProductDescription { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置推广卡片的行动号召。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("call_to_action")]
                [System.Text.Json.Serialization.JsonPropertyName("call_to_action")]
                public string CallToAction { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置是否使用智能优选。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_personal_action")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_personal_action")]
                public bool IsPersonalActionEnabled { get; set; }

                /// <summary>
                /// 获取或设置商品图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_image_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_image_id")]
                public string ProductImageId { get; set; } = string.Empty;
            }

            public class CommerceCard
            {
                /// <summary>
                /// 获取或设置直播卡片图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("call_to_action")]
                [System.Text.Json.Serialization.JsonPropertyName("call_to_action")]
                public string ImageId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置产品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public string Source { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置产品卖点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = string.Empty;
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
        /// 获取或设置广告投放位置列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inventory_type")]
        [System.Text.Json.Serialization.JsonPropertyName("inventory_type")]
        public IList<string>? InventoryType { get; set; }

        /// <summary>
        /// 获取或设置优选广告位。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smart_inventory")]
        [System.Text.Json.Serialization.JsonPropertyName("smart_inventory")]
        public int? SmartTnventory { get; set; }

        /// <summary>
        /// 获取或设置首选场景广告位。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_inventory")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_inventory")]
        public string? SceneInventory { get; set; }

        /// <summary>
        /// 获取或设置创意方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creative_material_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("creative_material_mode")]
        public string? CreativeMaterialMode { get; set; }

        /// <summary>
        /// 获取或设置程序化创意包 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("procedural_package_id")]
        [System.Text.Json.Serialization.JsonPropertyName("procedural_package_id")]
        public long? ProceduralPackageId { get; set; }

        /// <summary>
        /// 获取或设置是否自动生成视频素材。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_presented_video")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_presented_video")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsPresentedVideo { get; set; }

        /// <summary>
        /// 获取或设置是否开启衍生计划。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("generate_derived_ad")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("generate_derived_ad")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsGenerateDerivedAd { get; set; }

        /// <summary>
        /// 获取或设置素材列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_list")]
        [System.Text.Json.Serialization.JsonPropertyName("image_list")]
        public IList<Types.Material>? MaterialList { get; set; }

        /// <summary>
        /// 获取或设置标题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title_list")]
        [System.Text.Json.Serialization.JsonPropertyName("title_list")]
        public IList<Types.Title>? TitleList { get; set; }

        /// <summary>
        /// 获取或设置组件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_info")]
        [System.Text.Json.Serialization.JsonPropertyName("component_info")]
        public IList<Types.Component>? ComponentList { get; set; }

        /// <summary>
        /// 获取或设置自定义素材列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creatives")]
        [System.Text.Json.Serialization.JsonPropertyName("creatives")]
        public IList<Types.Creative>? CreativeList { get; set; }

        /// <summary>
        /// 获取或设置广告来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source")]
        [System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 获取或设置推广抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ies_core_user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ies_core_user_id")]
        public string? IESCoreUserId { get; set; }

        /// <summary>
        /// 获取或设置是否主页作品列表显示广告内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_feed_and_fav_see")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_feed_and_fav_see")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsFeedAndFavoritesVisible { get; set; }

        /// <summary>
        /// 获取或设置是否开启自动生成素材。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creative_auto_generate_switch")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("creative_auto_generate_switch")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsCreativeAutoGenerate { get; set; }

        /// <summary>
        /// 获取或设置应用名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_name")]
        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
        public string? AppName { get; set; }

        /// <summary>
        /// 获取或设置副标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_title")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_title")]
        public string? SubTitle { get; set; }

        /// <summary>
        /// 获取或设置应用下载详情页 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("web_url")]
        [System.Text.Json.Serialization.JsonPropertyName("web_url")]
        public string? WebUrl { get; set; }

        /// <summary>
        /// 获取或设置行动号召。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_text")]
        [System.Text.Json.Serialization.JsonPropertyName("action_text")]
        public string? ActionText { get; set; }

        /// <summary>
        /// 获取或设置搭配试玩素材 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("playable_url")]
        [System.Text.Json.Serialization.JsonPropertyName("playable_url")]
        public string? PlayableUrl { get; set; }

        /// <summary>
        /// 获取或设置是否关闭评论。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_comment_disable")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_comment_disable")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsDisableComment { get; set; }

        /// <summary>
        /// 获取或设置商品推广卡片信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_card")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_card")]
        public Types.PromotionCard? PromotionCard { get; set; }

        /// <summary>
        /// 获取或设置创意展现方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creative_display_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("creative_display_mode")]
        public string? CreativeDisplayMode { get; set; }

        /// <summary>
        /// 获取或设置允许客户端下载视频时需满足下列条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_download_status")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_download_status")]
        public int? AdDownloadStatus { get; set; }

        /// <summary>
        /// 获取或设置附加创意类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advanced_creative_type")]
        [System.Text.Json.Serialization.JsonPropertyName("advanced_creative_type")]
        public string? AdvancedCreativeType { get; set; }

        /// <summary>
        /// 获取或设置产品/商业卡列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commerce_cards")]
        [System.Text.Json.Serialization.JsonPropertyName("commerce_cards")]
        public IList<Types.CommerceCard>? CommerceCardList { get; set; }

        /// <summary>
        /// 获取或设置副标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advanced_creative_title")]
        [System.Text.Json.Serialization.JsonPropertyName("advanced_creative_title")]
        public string? AdvancedCreativeTitle { get; set; }

        /// <summary>
        /// 获取或设置电话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置按钮文本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("button_text")]
        [System.Text.Json.Serialization.JsonPropertyName("button_text")]
        public string? ButtonText { get; set; }

        /// <summary>
        /// 获取或设置表单提交链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("form_url")]
        [System.Text.Json.Serialization.JsonPropertyName("form_url")]
        public string? FormUrl { get; set; }

        /// <summary>
        /// 获取或设置三级行业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("third_industry_id")]
        [System.Text.Json.Serialization.JsonPropertyName("third_industry_id")]
        public int? ThirdIndustryId { get; set; }

        /// <summary>
        /// 获取或设置创意标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_keywords")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_keywords")]
        public IList<string>? AdKeywordList { get; set; }

        /// <summary>
        /// 获取或设置展示监测链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("track_url")]
        [System.Text.Json.Serialization.JsonPropertyName("track_url")]
        public string? TrackUrl { get; set; }

        /// <summary>
        /// 获取或设置点击监测链接列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_track_url")]
        [System.Text.Json.Serialization.JsonPropertyName("action_track_url")]
        public string? ActionTrackUrl { get; set; }

        /// <summary>
        /// 获取或设置视频有效播放监测链接列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_play_effective_track_url")]
        [System.Text.Json.Serialization.JsonPropertyName("video_play_effective_track_url")]
        public string? VideoPlayEffectiveTrackUrl { get; set; }

        /// <summary>
        /// 获取或设置视频播完监测链接列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_play_done_track_url")]
        [System.Text.Json.Serialization.JsonPropertyName("video_play_done_track_url")]
        public string? VideoPlayDoneTrackUrl { get; set; }

        /// <summary>
        /// 获取或设置视频播放监测链接列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_play_track_url")]
        [System.Text.Json.Serialization.JsonPropertyName("video_play_track_url")]
        public string? VideoPlayTrackUrl { get; set; }

        /// <summary>
        /// 获取或设置数据发送方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("track_url_send_type")]
        [System.Text.Json.Serialization.JsonPropertyName("track_url_send_type")]
        public string? TrackUrlSendType { get; set; }
    }
}
