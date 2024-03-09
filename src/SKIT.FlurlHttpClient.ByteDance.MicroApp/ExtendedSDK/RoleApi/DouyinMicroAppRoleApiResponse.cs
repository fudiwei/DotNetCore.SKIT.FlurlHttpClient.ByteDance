namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi
{
    /// <summary>
    /// 抖音小程序泛知识角色系统 API 响应的基类。
    /// </summary>
    public abstract class DouyinMicroAppRoleApiResponse : CommonResponseBase, ICommonResponse
    {
        /// <summary>
        /// 获取抖音小程序 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public virtual int ErrorNumber { get; set; }

        /// <summary>
        /// 获取抖音小程序 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_tips")]
        [System.Text.Json.Serialization.JsonPropertyName("err_tips")]
        public virtual string? ErrorTips { get; set; }

        /// <summary>
        /// 获取抖音小程序 API 返回的错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err")]
        [System.Text.Json.Serialization.JsonPropertyName("err")]
        public virtual ByteDanceMicroAppRoleApiResponseError? Error { get; set; }

        /// <summary>
        /// 获取一个值，该值指示调用抖音小程序 API 是否成功。
        /// <para>
        ///（即 HTTP 状态码为 200，且 <see cref="ErrorNumber"/> 值为 0、<see cref="Error.ErrorCode"/> 值为 0）
        /// </para>
        /// </summary>
        /// <returns></returns>
        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorNumber == 0 && (Error is null || Error.ErrorCode == 0);
        }
    }

    public class ByteDanceMicroAppRoleApiResponseError
    {
        /// <summary>
        /// 获取抖音小程序 API 返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_code")]
        [System.Text.Json.Serialization.JsonPropertyName("err_code")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// 获取抖音小程序 API 返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ErrorMessage { get; set; }
    }
}
