using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/v2/coupon/sync/coupon_available 接口的请求。</para>
    /// </summary>
    public class POICouponSyncCouponAvailableV2Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class Availability
            {
                public static class Types
                {
                    public class SPUExternalInfo : POICouponSyncV2Request.Types.Availability.Types.SPUExternalInfo
                    {
                    }

                    public class SupplierExternalInfo : POICouponSyncV2Request.Types.Availability.Types.SupplierExternalInfo
                    {
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
        /// 获取或设置可用列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_info")]
        [System.Text.Json.Serialization.JsonPropertyName("available_info")]
        public IList<Types.Availability>? AvailabilityList { get; set; }
    }
}
