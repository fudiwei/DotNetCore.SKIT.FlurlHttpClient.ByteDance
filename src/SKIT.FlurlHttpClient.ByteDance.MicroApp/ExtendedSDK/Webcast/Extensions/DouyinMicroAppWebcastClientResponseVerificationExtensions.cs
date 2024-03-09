using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast
{
    using System.Text;
    using SKIT.FlurlHttpClient.Primitives;

    public static class DouyinMicroAppWebcastClientResponseVerificationExtensions
    {
        /// <summary>
        /// <para>验证响应签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/interaction/develop/server/live/sign#%E7%AD%BE%E5%90%8D%E9%AA%8C%E8%AF%81 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static ErroredResult VerifyResponseSignature<TResponse>(this DouyinMicroAppWebcastClient client, TResponse response)
            where TResponse : DouyinMicroAppWebcastResponse
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (response is null) throw new ArgumentNullException(nameof(response));

            ErroredResult result;

            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(response.ByteTimestamp);
                stringBuilder.Append("\n");
                stringBuilder.Append(response.ByteNonce);
                stringBuilder.Append("\n");
                stringBuilder.Append(Encoding.UTF8.GetString(response.GetRawBytes()));
                stringBuilder.Append("\n");

                bool valid = Utilities.RSAUtility.Verify(
                    publicKeyPem: client.Credentials.PlatformPublicKey,
                    messageData: stringBuilder.ToString(),
                    encodingSignature: new EncodedString(response.ByteSignature, EncodingKinds.Base64),
                    Utilities.RSAUtility.DIGEST_ALGORITHM_SHA256
                );
                if (valid)
                    result = ErroredResult.Ok();
                else
                    result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{response.ByteSignature}\" is an illegal signature."));
            }
            catch (Exception ex)
            {
                result = ErroredResult.Fail(ex);
            }

            return result;
        }
    }
}
