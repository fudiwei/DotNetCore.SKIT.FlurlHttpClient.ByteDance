using SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests.SDK.OpenApi
{
    public class TestCase_EventVerificationTests
    {
        [Fact(DisplayName = "测试用例：回调验签解密")]
        public void TestECPayRequestSignature()
        {
            var client = new ByteDanceMicroAppOpenApiClient(new ByteDanceMicroAppOpenApiClientOptions
            {
                PushToken = "",
                PushEncodingAESKey = ""
            });

            string callbackJson = @"{""Encrypt"":""EncryptData"",""MsgSignature"":""MsgSignatureData"",""Nonce"":""NonceData"",""TimeStamp"":""TimeStampData""}";
            bool verified = client.VerifyEventSignatureFromJson(callbackJson);
            Assert.True(verified);
            var callbackEvent = client.DeserializeEventFromJson(callbackJson);
            Assert.NotNull(callbackEvent);
        }
    }
}
