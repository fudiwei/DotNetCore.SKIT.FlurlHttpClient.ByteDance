using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// 为 <see cref="DouyinOpenClient"/> 提供 Webhook 事件的扩展方法。
    /// </summary>
    public static class DouyinOpenClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="DouyinOpenEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEvent<TEvent>(this DouyinOpenClient client, string webhookJson)
            where TEvent : DouyinOpenEvent, new()
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookJson is null) throw new ArgumentNullException(webhookJson);

            try
            {
                return client.JsonSerializer.Deserialize<TEvent>(webhookJson);
            }
            catch (Exception ex)
            {
                throw new DouyinOpenException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }

        /// <summary>
        /// <para>验证 Webhook 事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/webhooks/summarize ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson">抖音 Webhook 事件中请求正文（JSON 格式）。</param>
        /// <param name="webhookSignature">抖音 Webhook 事件中的 "X-Douyin-Signature" 请求标头。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignature(this DouyinOpenClient client, string webhookJson, string webhookSignature)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookJson is null) throw new ArgumentNullException(nameof(webhookJson));

            ErroredResult result;

            try
            {
                string msg = $"{client.Credentials.ClientSecret}{webhookJson}";
                string sign = Utilities.SHA1Utility.Hash(msg).Value!;
                bool valid = string.Equals(sign, webhookSignature, StringComparison.OrdinalIgnoreCase);

                if (valid)
                    result = ErroredResult.Ok();
                else
                    result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{webhookSignature}\" is an illegal signature."));
            }
            catch (Exception ex)
            {
                result = ErroredResult.Fail(ex);
            }

            return result;
        }
    }
}
