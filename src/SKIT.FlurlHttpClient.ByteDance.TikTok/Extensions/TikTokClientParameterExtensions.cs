using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    /// <summary>
    /// 为 <see cref="TikTokClient"/> 提供客户端调起 JSBridge 签名的扩展方法。
    /// </summary>
    public static class TikTokClientParameterExtensions
    {
        /// <summary>
        /// <para>生成客户端 JSBridge `sdk.config` 所需的参数。</para>
        /// <para>REF: https://open.douyin.com/platform/doc/6850443440044410888 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="jsapiTicket"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJSBridgeConfig(this TikTokClient client, string jsapiTicket, string url)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (jsapiTicket is null) throw new ArgumentNullException(nameof(jsapiTicket));
            if (url is null) throw new ArgumentNullException(nameof(url));

            url = url.Split('#')[0];
            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string sign = Security.MD5Utility.Hash($"jsapi_ticket={jsapiTicket}&nonce_str={nonce}&timestamp={timestamp}&url={url}").ToLower();

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "client_key", client.Credentials.ClientKey },
                { "timestamp", timestamp },
                { "nonce_str", nonce },
                { "url", url },
                { "signature", sign }
            });
        }
    }
}
