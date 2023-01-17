namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/get_aweme_user_bind_qrcode 接口的请求。</para>
    /// </summary>
    public class AppsCapacityGetAwemeUserBindQrcodeV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置绑定类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BindType { get; set; } = string.Empty;
    }
}
