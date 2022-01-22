using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /material/deleteMaterial 接口的响应。</para>
    /// </summary>
    public class MaterialDeleteMaterialResponse : TikTokShopResponse<MaterialDeleteMaterialResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class FailReason
                    {
                        /// <summary>
                        /// 获取或设置错误码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public int ErrorCode { get; set; }

                        /// <summary>
                        /// 获取或设置错误原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg")]
                        public string ErrorMessage { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置删除成功的素材 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("success_ids")]
                public string[] SucceedObjectIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置删除失败的素材字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_map")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_map")]
                public IDictionary<string, Types.FailReason> FailedObjectMap { get; set; } = default!;
            }
        }
    }
}
