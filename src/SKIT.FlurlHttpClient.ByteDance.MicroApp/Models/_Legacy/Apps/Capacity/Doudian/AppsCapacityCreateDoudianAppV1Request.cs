using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/capacity/create_doudian_app 接口的请求。</para>
    /// </summary>
    public class AppsCapacityCreateDoudianAppV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置店铺名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_name")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_name")]
        public string ShopName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置备注说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("note")]
        [System.Text.Json.Serialization.JsonPropertyName("note")]
        public string Notes { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置功能截图文件路径列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("screen_shot_list")]
        [System.Text.Json.Serialization.JsonPropertyName("screen_shot_list")]
        public IList<string> ScreenshotFilePathList { get; set; } = new List<string>();
    }
}
