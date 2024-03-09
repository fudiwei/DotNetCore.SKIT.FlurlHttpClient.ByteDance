using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Flurl;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientParameterExtensions
    {
        /// <summary>
        /// <para>生成客户端 JSBridge `sdk.config` 所需的参数。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/sdk/web-app/js/js-access ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/sdk/web-app/js/signature ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="jsapiTicket"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJSBridgeConfig(this DouyinOpenClient client, string jsapiTicket, string url)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (jsapiTicket is null) throw new ArgumentNullException(nameof(jsapiTicket));
            if (url is null) throw new ArgumentNullException(nameof(url));

            url = url.Split('#')[0];
            string timestamp = DateTimeOffset.Now.ToLocalTime().ToUnixTimeSeconds().ToString();
            string nonce = Guid.NewGuid().ToString("N");
            string sign = Utilities.MD5Utility.Hash($"jsapi_ticket={jsapiTicket}&nonce_str={nonce}&timestamp={timestamp}&url={url}").Value!.ToLower();

            return new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "client_key", client.Credentials.ClientKey },
                { "timestamp", timestamp },
                { "nonce_str", nonce },
                { "url", url },
                { "signature", sign }
            });
        }

        /// <summary>
        /// <para>生成抖音获取授权临时票据的 URL。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/sdk/web-app/web/permission ]]> <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-permission/douyin-get-permission-code ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="scope"></param>
        /// <param name="optionalScope"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForPlatformOAuthConnect(this DouyinOpenClient client, string? scope = null, string? optionalScope = null, string? redirectUrl = null, string? state = null)
        {
            return new Url("https://open.douyin.com/")
                .AppendPathSegments("platform", "oauth", "connect")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("response_type", "code")
                .SetQueryParam("scope", scope)
                .SetQueryParam("optionalScope", optionalScope)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("state", state)
                .ToString();
        }
    }
}
