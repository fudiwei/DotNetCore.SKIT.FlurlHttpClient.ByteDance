using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/coupon/sync 接口的请求。</para>
    /// </summary>
    public class POICouponSyncV2Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class Availability
            {
                public static class Types
                {
                    public class SPUExternalInfo
                    {
                        /// <summary>
                        /// 获取或设置商品外部 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spu_ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("spu_ext_id")]
                        public string? SPUExternalId { get; set; }

                        /// <summary>
                        /// 获取或设置可用门店外部 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_ext_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_ids")]
                        public IList<string>? SupplierExternalIdList { get; set; }
                    }

                    public class SupplierExternalInfo
                    {
                        /// <summary>
                        /// 获取或设置商品外部 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spu_ext_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("spu_ext_ids")]
                        public IList<string>? SPUExternalIdList { get; set; }

                        /// <summary>
                        /// 获取或设置可用门店外部 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
                        public string? SupplierExternalId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置入口信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entry_info")]
                [System.Text.Json.Serialization.JsonPropertyName("entry_info")]
                public Entry? Entry { get; set; }

                /// <summary>
                /// 获取或设置商品维度可用信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_ext_info")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_ext_info")]
                public Types.SPUExternalInfo? SPUExternalInfo { get; set; }

                /// <summary>
                /// 获取或设置店铺维度可用信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_ext_info")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_info")]
                public Types.SupplierExternalInfo? SupplierExternalInfo { get; set; }
            }

            public class Entry
            {
                public static class Types
                {
                    public class EntryMiniApp : POISupplierSyncRequest.Types.Service.Types.Entry.Types.EntryMiniApp
                    {
                    }
                }

                /// <summary>
                /// 获取或设置入口类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entry_type")]
                [System.Text.Json.Serialization.JsonPropertyName("entry_type")]
                public int EntryType { get; set; }

                /// <summary>
                /// 获取或设置入口链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entry_url")]
                [System.Text.Json.Serialization.JsonPropertyName("entry_url")]
                public string? EntryUrl { get; set; }

                /// <summary>
                /// 获取或设置小程序入口信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entry_miniApp")]
                [System.Text.Json.Serialization.JsonPropertyName("entry_miniApp")]
                public Types.EntryMiniApp? EntryMiniApp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置优惠券外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_coupon_id")]
        public string ExternalCouponId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置上线状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置领取开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("claim_start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("claim_start_time")]
        public long? ClaimStartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置领取结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("claim_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("claim_end_time")]
        public long? ClaimEndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置优惠券属性字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attribute")]
        [System.Text.Json.Serialization.JsonPropertyName("attribute")]
        public IDictionary<int, object> AttributeMap { get; set; } = new Dictionary<int, object>();

        /// <summary>
        /// 获取或设置可用列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_info")]
        [System.Text.Json.Serialization.JsonPropertyName("available_info")]
        public IList<Types.Availability>? AvailabilityList { get; set; }

        /// <summary>
        /// 获取或设置入口信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entry_info")]
        [System.Text.Json.Serialization.JsonPropertyName("entry_info")]
        public Types.Entry? Entry { get; set; }
    }
}
