using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
{
    public static class TikTokShopClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="TikTokShopEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TikTokShopEvent DeserializeEvent(this TikTokShopClient client, string webhookJson)
        {
            return DeserializeEvent<TikTokShopEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="TikTokShopEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEvent<TEvent>(this TikTokShopClient client, string webhookJson)
            where TEvent : TikTokShopEvent, new()
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookJson is null) throw new ArgumentNullException(webhookJson);

            try
            {
                return client.JsonSerializer.Deserialize<TEvent>(webhookJson)!;
            }
            catch (Exception ex)
            {
                throw new TikTokShopException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }
    }
}
