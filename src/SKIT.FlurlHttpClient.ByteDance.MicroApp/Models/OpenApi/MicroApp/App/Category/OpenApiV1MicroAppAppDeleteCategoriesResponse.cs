﻿namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/v1/microapp/app/del_categories 接口的响应。</para>
    /// </summary>
    public class OpenApiV1MicroAppAppDeleteCategoriesResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errno")]
        [System.Text.Json.Serialization.JsonPropertyName("errno")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public override string? ErrorMessage { get; set; }
    }
}
