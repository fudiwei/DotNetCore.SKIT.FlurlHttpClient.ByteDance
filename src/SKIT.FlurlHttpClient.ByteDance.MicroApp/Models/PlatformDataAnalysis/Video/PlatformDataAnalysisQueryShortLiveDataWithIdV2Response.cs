using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/platform/v2/data_analysis/query_short_live_data_with_id/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQueryShortLiveDataWithIdV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ShortLiveData
                    {
                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                        public string? ItemId { get; set; }

                        /// <summary>
                        /// 获取或设置加密的视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_item_id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_item_id_list")]
                        public string? OpenItemId { get; set; }

                        /// <summary>
                        /// 获取或设置视频标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_title")]
                        public string? ItemTitle { get; set; }

                        /// <summary>
                        /// 获取或设置视频封面 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_cover")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_cover")]
                        public string? ItemCoverUrl { get; set; }

                        /// <summary>
                        /// 获取或设置视频播放 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_addr")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_addr")]
                        public string? ItemPlayerUrl { get; set; }

                        /// <summary>
                        /// 获取或设置视频作者的抖音号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_aweme_shortid")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_aweme_shortid")]
                        public string? ItemAwemeShortId { get; set; }

                        /// <summary>
                        /// 获取或设置视频作者的类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_aweme_type")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("item_aweme_type")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? ItemAwemeType { get; set; }

                        /// <summary>
                        /// 获取或设置视频作者的昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_aweme_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_aweme_name")]
                        public string? ItemAwemeNickname { get; set; }

                        /// <summary>
                        /// 获取或设置视频作者的头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_aweme_avatar")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_aweme_avatar")]
                        public string? ItemAwemeAvatarUrl { get; set; }

                        /// <summary>
                        /// 获取或设置视频时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_duration")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("item_duration")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? ItemDuration { get; set; }

                        /// <summary>
                        /// 获取或设置视频创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_create_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("item_create_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public long? ItemCreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置视频完播次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_last_frame_watch_cnt")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("item_last_frame_watch_cnt")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? ItemLastFrameWatchCount { get; set; }

                        /// <summary>
                        /// 获取或设置视频完播率字符串（格式：d%）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_completion_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_completion_rate")]
                        public string? ItemCompletionRateString { get; set; }

                        /// <summary>
                        /// 获取或设置视频评论次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_comment_count")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("item_comment_count")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? ItemCommentCount { get; set; }

                        /// <summary>
                        /// 获取或设置视频点赞次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_like_count")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("item_like_count")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? ItemLikeCount { get; set; }

                        /// <summary>
                        /// 获取或设置视频分享次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_share_count")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("item_share_count")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? ItemShareCount { get; set; }

                        /// <summary>
                        /// 获取或设置视频播放次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_vv")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("item_vv")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? ItemVV { get; set; }

                        /// <summary>
                        /// 获取或设置视频播放人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_uv")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("item_uv")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? ItemUV { get; set; }

                        /// <summary>
                        /// 获取或设置直播间 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("room_id")]
                        public string? LiveRoomId { get; set; }

                        /// <summary>
                        /// 获取或设置直播间作者的抖音号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_aweme_shortid")]
                        [System.Text.Json.Serialization.JsonPropertyName("room_aweme_shortid")]
                        public string? LiveRoomAwemeShortId { get; set; }

                        /// <summary>
                        /// 获取或设置直播间作者的类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_aweme_type")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_aweme_type")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? LiveRoomAwemeType { get; set; }

                        /// <summary>
                        /// 获取或设置直播间作者的昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_aweme_nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("room_aweme_nickname")]
                        public string? LiveRoomAwemeNickname { get; set; }

                        /// <summary>
                        /// 获取或设置直播间作者的头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_aweme_avt")]
                        [System.Text.Json.Serialization.JsonPropertyName("room_aweme_avt")]
                        public string? LiveRoomAwemeAvatarUrl { get; set; }

                        /// <summary>
                        /// 获取或设置直播间开播时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_duration")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_duration")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? LiveRoomDuration { get; set; }

                        /// <summary>
                        /// 获取或设置直播间开播时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_create_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_create_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public long? LiveRoomCreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置直播间关播时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_finish_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_finish_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public long? LiveRoomFinishTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置直播间最高在线人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_highest_online_count")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_highest_online_count")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? LiveRoomHighestOnlineUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置直播间人均观看时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_once_watch_duration")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_once_watch_duration")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? LiveRoomOnceWatchDuration { get; set; }

                        /// <summary>
                        /// 获取或设置直播间评论次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_comment_count")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_comment_count")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? LiveRoomCommentCount { get; set; }

                        /// <summary>
                        /// 获取或设置直播间评论人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_comment_user_count")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_comment_user_count")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? LiveRoomCommentUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置直播间点赞次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_like_count")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_like_count")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? LiveRoomLikeCount { get; set; }

                        /// <summary>
                        /// 获取或设置直播间点赞人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_like_user_count")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_like_user_count")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? LiveRoomLikeUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置直播间分享次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_share_count")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_share_count")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? LiveRoomShareCount { get; set; }

                        /// <summary>
                        /// 获取或设置直播间分享人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_share_user_count")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_share_user_count")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? LiveRoomShareUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置小程序曝光次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_show_pv")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_show_pv")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int MicroAppShowPV { get; set; }

                        /// <summary>
                        /// 获取或设置小程序曝光人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_show_uv")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_show_uv")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int MicroAppShowUV { get; set; }

                        /// <summary>
                        /// 获取或设置小程序点击次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_click_pv")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_click_pv")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int MicroAppClickPV { get; set; }

                        /// <summary>
                        /// 获取或设置小程序点击人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_click_uv")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_click_uv")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int MicroAppClickUV { get; set; }

                        /// <summary>
                        /// 获取或设置小程序点击率字符串（格式：d%）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_click_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_click_rate")]
                        public string? MicroAppClickRateString { get; set; }

                        /// <summary>
                        /// 获取或设置进入小程序次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_drainage_pv")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_drainage_pv")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int MicroAppDrainagePV { get; set; }

                        /// <summary>
                        /// 获取或设置进入小程序人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mp_drainage_uv")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("mp_drainage_uv")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int MicroAppDrainageUV { get; set; }

                        /// <summary>
                        /// 获取或设置直播间曝光次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_show_pv")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_show_pv")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? LiveRoomShowPV { get; set; }

                        /// <summary>
                        /// 获取或设置直播间曝光人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_show_uv")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_show_uv")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? LiveRoomShowUV { get; set; }

                        /// <summary>
                        /// 获取或设置直播间观看次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_watch_pv")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_watch_pv")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? LiveRoomWatchPV { get; set; }

                        /// <summary>
                        /// 获取或设置直播间观看人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_watch_uv")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_watch_uv")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? LiveRoomWatchUV { get; set; }

                        /// <summary>
                        /// 获取或设置直播间看播率字符串（格式：d%）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_watch_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("room_watch_rate")]
                        public string? LiveRoomWatchRateString { get; set; }

                        /// <summary>
                        /// 获取或设置直播间互动率字符串（格式：d%）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_interactive_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("room_interactive_rate")]
                        public string? LiveRoomInteractiveRateString { get; set; }

                        /// <summary>
                        /// 获取或设置支付订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_order_cnt")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_order_cnt")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int PayOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置支付人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_customer_cnt")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_customer_cnt")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int PayUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置支付金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_order_amount")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_order_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public long PayOrderAmount { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_order_cnt")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_order_cnt")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int RefundOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置退款人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_customer_cnt")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_customer_cnt")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int RefundUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_amount")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public long RefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置客单价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_once_price")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_once_price")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public long CustomerOncePrice { get; set; }

                        /// <summary>
                        /// 获取或设置单均价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_once_price")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("order_once_price")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public long OrderOncePrice { get; set; }

                        /// <summary>
                        /// 获取或设置直播间 UV 价值（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_uv_price")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("room_uv_price")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public long? LiveRoomUVPrice { get; set; }

                        /// <summary>
                        /// 获取或设置 BC 账号绑定关系。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bc_relation_bind_type")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("bc_relation_bind_type")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? BCRelationBindType { get; set; }

                        /// <summary>
                        /// 获取或设置开播平台。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_type")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("app_type")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int? AppType { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置短视频或直播间数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("data_list")]
                public Types.ShortLiveData[]? ShortLiveDataList { get; set; }

                /// <summary>
                /// 获取或设置短视频或直播间每日数据字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_data")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_data")]
                public IDictionary<long, Types.ShortLiveData>? ShortLiveDailyDataMap { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sum")]
                [System.Text.Json.Serialization.JsonPropertyName("sum")]
                public int TotalCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
