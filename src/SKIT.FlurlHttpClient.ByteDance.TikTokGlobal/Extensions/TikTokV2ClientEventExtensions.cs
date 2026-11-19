namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// 为 <see cref="TikTokV2Client"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static class TikTokV2ClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="TikTokV2Event"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TikTokV2Event DeserializeEvent(this TikTokV2Client client, string webhookJson)
        {
            return DeserializeEvent<TikTokV2Event>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="TikTokV2Event"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEvent<TEvent>(this TikTokV2Client client, string webhookJson)
            where TEvent : TikTokV2Event, new()
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookJson is null) throw new ArgumentNullException(webhookJson);

            try
            {
                return client.JsonSerializer.Deserialize<TEvent>(webhookJson)!;
            }
            catch (Exception ex)
            {
                throw new TikTokV2Exception("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/overview-guide/smallprogram/encryption ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <param name="webhookSignature"></param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignature(this TikTokV2Client client, string webhookJson, string webhookSignature)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

            try
            {
                Dictionary<string, string> kvParams = webhookSignature.Split(',').Select(s => s.Split('=')).ToDictionary(k => k[0], v => v[1]);

                string msgText = $"{kvParams["t"]}.{webhookJson}";
                string signText = Utilities.SHA256Utility.Hash(msgText).Value!;

                if (string.Equals(signText, kvParams["s"], StringComparison.OrdinalIgnoreCase))
                    result = ErroredResult.Ok();
                else
                    result = ErroredResult.Fail(new Exception($"Signature does not match."));
            }
            catch (Exception ex)
            {
                result = ErroredResult.Fail(ex);
            }

            return result;
        }
    }
}
