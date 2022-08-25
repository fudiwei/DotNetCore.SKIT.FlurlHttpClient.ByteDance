using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Flurl;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    public static class TikTokClientParameterExtensions
    {
        /// <summary>
        /// <para>生成客户端 JSBridge `sdk.config` 所需的参数。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/sdk/web-app/js-access </para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/sdk/web-app/js/signature </para>
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
            string sign = Utilities.MD5Utility.Hash($"jsapi_ticket={jsapiTicket}&nonce_str={nonce}&timestamp={timestamp}&url={url}").ToLower();

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
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-permission/douyin-get-permission-code </para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/sdk/web-app/web/permission </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="scope"></param>
        /// <param name="optionalScope"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForPlatformOAuthConnect(this TikTokClient client, string? scope = null, string? optionalScope = null, string? redirectUrl = null, string? state = null)
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

        /// <summary>
        /// <para>生成抖音获取静默授权临时票据的 URL。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/sdk/web-app/web/silent-auth </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="scope"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string GenerateParameterizedUrlForPlatformOAuthSlientAuth(this TikTokClient client, string? scope = null, string? redirectUrl = null, string? state = null)
        {
            return new Url("https://open.douyin.com/")
                .AppendPathSegments("platform", "oauth", "slient_auth")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("response_type", "code")
                .SetQueryParam("scope", scope)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("state", state)
                .ToString();
        }

        /// <summary>
        /// <para>生成头条获取授权临时票据的 URL。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/sdk/web-app/web/permission </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="scope"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2022-08-09 下线。")]
        public static string GenerateParameterizedUrlForOAuthAuthorize(this TikTokClient client, string? scope = null, string? redirectUrl = null, string? state = null)
        {
            return new Url("https://open.snssdk.com/")
                .AppendPathSegments("oauth", "authorize")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("response_type", "code")
                .SetQueryParam("scope", scope)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("state", state)
                .ToString();
        }

        /// <summary>
        /// <para>生成头条获取静默授权临时票据的 URL。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/sdk/web-app/web/permission </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="scope"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2022-08-09 下线。")]
        public static string GenerateParameterizedUrlForOAuthAuthorizeV2(this TikTokClient client, string? scope = null, string? redirectUrl = null, string? state = null)
        {
            return new Url("https://open.snssdk.com/")
                .AppendPathSegments("oauth", "authorize", "v2")
                .SetQueryParam("client_key", client.Credentials.ClientKey)
                .SetQueryParam("response_type", "code")
                .SetQueryParam("scope", scope)
                .SetQueryParam("redirect_uri", redirectUrl)
                .SetQueryParam("state", state)
                .ToString();
        }

        /// <summary>
        /// <para>生成西瓜获取授权临时票据的 URL。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/sdk/web-app/web/permission </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="scope"></param>
        /// <param name="optionalScope"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        [Obsolete("相关接口或字段于 2022-08-09 下线。")]
        public static string GenerateParameterizedUrlForOAuthConnect(this TikTokClient client, string? scope = null, string? optionalScope = null, string? redirectUrl = null, string? state = null)
        {
            return new Url("https://open-api.ixigua.com/")
                .AppendPathSegments("oauth", "connect")
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
