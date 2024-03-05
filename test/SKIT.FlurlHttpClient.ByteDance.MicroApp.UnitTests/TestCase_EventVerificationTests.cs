using Xunit;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    using SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi;
    using SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Events;

    public class TestCase_EventVerificationTests
    {
        [Fact(DisplayName = "测试用例：验签并解密 JSON 回调数据")]
        public void TestVerifyJsonEvent()
        {
            /* ByteDanceMicroAppClient */
            {
                string callbackRawJson = "{\"ToUserName\":\"appid\",\"FromUserName\":\"openid\",\"CreateTime\":1577364225,\"MsgType\":\"text\",\"Content\":\"text content\"}";
                string callbackSecretJson = "{\"Nonce\":\"1372623149\",\"TimeStamp\":\"1409659813\",\"Encrypt\":\"qc4kT4X+UzU6/qfguyGDpAd6mt2SmOYc1FE9DkulrGWTeHgMu3cPa1WQiNQ61+GMZI2DOzHbu4QVxduzuwh83Q3umURGKyRdNgaEY1GNGt+hhVOjLSkU8wHPNbZ8YfBGsZdZfdWxTy+e36Utetrw17T8MYcoHOhOcIml4dD8DU90SAL6oCA7AZrB8nh+J1kahSQ3c30D6LKlPk044cEWKkVBSzF2XWaPuaUIlUVXigknfFVAhfFFKAuQ7e6ftzJ2\",\"MsgSignature\":\"599c9a6a625fec4c7f13cbafbf4083491a515e6b\"}";

                var options = new DouyinMicroAppClientOptions()
                {
                    AppId = "tt5823bf96d3bd56c7",
                    PushEncodingAESKey = "jWmYm7qr5nMoAUwZRjGtBxmz3KA1tkAj3ykkR6q2B2C",
                    PushToken = "QDG6eK"
                };
                var client = new DouyinMicroAppClient(options);
                var eventModel1 = client.DeserializeEventFromJson<Events.TextMessageEvent>(callbackRawJson);
                var eventModel2 = client.DeserializeEventFromJson<Events.TextMessageEvent>(callbackSecretJson);

                Assert.True(client.VerifyEventSignatureFromJson(callbackSecretJson));
                Assert.Equal("appid", eventModel1.ToUserName);
                Assert.Equal("appid", eventModel2.ToUserName);
                Assert.Equal("openid", eventModel1.FromUserName);
                Assert.Equal("openid", eventModel2.FromUserName);
                Assert.Equal("text", eventModel1.MessageType);
                Assert.Equal("text", eventModel2.MessageType);
                Assert.Equal(1577364225L, eventModel1.CreateTimestamp);
                Assert.Equal(1577364225L, eventModel2.CreateTimestamp);
                Assert.Equal("text content", eventModel1.Content);
                Assert.Equal("text content", eventModel2.Content);
            }

            /* ByteDanceMicroAppOpenApiClient */
            {
                string callbackRawJson = "{\"FromUserName\":\"ByteDanceMicroApp\",\"CreateTime\":\"2019-01-14 12:45:10\",\"Event\":\"PUSH\",\"MsgType\":\"Ticket\",\"Ticket\":\"8c0da4968b0d1e28acbc1d738a56607d\"}";
                string callbackSecretJson = "{\"Nonce\":\"1372623149\",\"TimeStamp\":\"1409659813\",\"Encrypt\":\"OheJ/nrK5Liim/H6TjL6ufUBwoxRP4sy2e0mS7IO47WESBIHgIXdGLwhs8iDCgMsPe0I78q2jUNtdO7w6+Vg+gtmEm5mbcljWv18Fs5hw91+hwID9uOGNC5ICeLGMMXW0uaGtqn8XgwXxtROAK220M5oRYK9MvmIoU/Q7Tvx1xnP4Jfunww+2mYqgD3YIYvTFVReX+3BeRuBh7zOK7tRbdqXaPbK/Cko0Vnt82rikDmItgXLUtJC4wxJohhXKZGb/12oFq6L/Uy+CtLqVLZMIH4uxlb5cO9exYfArVocZTc=\",\"MsgSignature\":\"e51e71c9087fc57ae1cf8eb25c0d1ba837db5b7c\"}";
                
                var options = new DouyinMicroAppOpenApiClientOptions()
                {
                    ComponentAppId = "tt5823bf96d3bd56c7",
                    PushEncodingAESKey = "jWmYm7qr5nMoAUwZRjGtBxmz3KA1tkAj3ykkR6q2B2C",
                    PushToken = "QDG6eK"
                };
                var client = new DouyinMicroAppOpenApiClient(options);
                var eventModel1 = client.DeserializeEventFromJson<ComponentPushTicketEvent>(callbackRawJson);
                var eventModel2 = client.DeserializeEventFromJson<ComponentPushTicketEvent>(callbackSecretJson);

                Assert.True(client.VerifyEventSignatureFromJson(callbackSecretJson));
                Assert.Equal("ByteDanceMicroApp", eventModel1.FromUserName);
                Assert.Equal("ByteDanceMicroApp", eventModel2.FromUserName);
                Assert.Equal("PUSH", eventModel1.Event);
                Assert.Equal("PUSH", eventModel2.Event);
                Assert.Equal("2019-01-14 12:45:10", eventModel1.CreateTimeString);
                Assert.Equal("2019-01-14 12:45:10", eventModel2.CreateTimeString);
                Assert.Equal("Ticket", eventModel1.MessageType);
                Assert.Equal("Ticket", eventModel2.MessageType);
                Assert.Equal("8c0da4968b0d1e28acbc1d738a56607d", eventModel1.Ticket);
                Assert.Equal("8c0da4968b0d1e28acbc1d738a56607d", eventModel2.Ticket);
            }
        }

        [Fact(DisplayName = "测试用例：验签并解密 XML 回调数据")]
        public void TestVerifyXmlEvent()
        {
            /* ByteDanceMicroAppClient */
            {
                string callbackRawXml = "<xml><ToUserName><![CDATA[appid]]></ToUserName><FromUserName><![CDATA[openid]]></FromUserName><CreateTime>1577364225</CreateTime><MsgType><![CDATA[text]]></MsgType><Content><![CDATA[text content]]></Content></xml>";
                string callbackSecretXml = "<xml><Nonce>1372623149</Nonce><TimeStamp>1409659813</TimeStamp><Encrypt><![CDATA[MaEUhT8OKNhsVxpr0GbcJdK1imvt2M5bubdxDZ3/iHNJ83KHjOgGUoL8+JAzE3XWBMPpPVUNQR0euBK+hc/8THlA0fwcMFc7Ulkv+bMUgV31ZW8AFEP4c9usWOdK0CX/SJCQlfI42kCoqpOCAr8REYBZEdN6cS1ftxG9nXP2GeHey8ZUJZ72w6xELwoO63RZqbAb0AkAO34xmaIn5Pq1PgkSDKr2xGs2iGW3Tai4sBRpdbYO5uBFIadlGfoKN367TipodV4xt/N+zfijd2YLjbP/9gCMFUUr5PNhRr2WnICn5i9D5BkpvpLxDJz7v+NaHNmIF3f/S3hxLsmt0PpvVQ/qyKWrFDa9Zd/A3ezrUZkMocvj1xP4v0tg/OeILo/+ ]]></Encrypt><MsgSignature><![CDATA[e8216c03c516260d31278537e8c0d60b9c8080b1]]></MsgSignature></xml>";

                var options = new DouyinMicroAppClientOptions()
                {
                    AppId = "tt5823bf96d3bd56c7",
                    PushEncodingAESKey = "jWmYm7qr5nMoAUwZRjGtBxmz3KA1tkAj3ykkR6q2B2C",
                    PushToken = "QDG6eK"
                };
                var client = new DouyinMicroAppClient(options);
                var eventModel1 = client.DeserializeEventFromXml<Events.TextMessageEvent>(callbackRawXml);
                var eventModel2 = client.DeserializeEventFromXml<Events.TextMessageEvent>(callbackSecretXml);

                Assert.True(client.VerifyEventSignatureFromXml(callbackSecretXml));
                Assert.Equal("appid", eventModel1.ToUserName);
                Assert.Equal("appid", eventModel2.ToUserName);
                Assert.Equal("openid", eventModel1.FromUserName);
                Assert.Equal("openid", eventModel2.FromUserName);
                Assert.Equal("text", eventModel1.MessageType);
                Assert.Equal("text", eventModel2.MessageType);
                Assert.Equal(1577364225L, eventModel1.CreateTimestamp);
                Assert.Equal(1577364225L, eventModel2.CreateTimestamp);
                Assert.Equal("text content", eventModel1.Content);
                Assert.Equal("text content", eventModel2.Content);
            }

            /* ByteDanceMicroAppOpenApiClient */
            {
                string callbackRawXml = "<xml><FromUserName><![CDATA[ByteDanceMicroApp]]></FromUserName><CreateTime><![CDATA[2019-01-14 12:45:10]]></CreateTime><Event><![CDATA[PUSH]]></Event><MsgType><![CDATA[Ticket]]></MsgType><Ticket><![CDATA[8c0da4968b0d1e28acbc1d738a56607d]]></Ticket></xml>";
                string callbackSecretXml = "<xml><Nonce>1372623149</Nonce><TimeStamp>1409659813</TimeStamp><Encrypt><![CDATA[Tq2Hc5b/5qnsAx5iKhxotEp447dkaa8qDfCnZbsyQu1VnU+GNilYjsNA8MOkUkN5f03Tsbgjy0DgSKjSuMpbGEms5FwDwvsWzBmyCHI+PK9TuAl3tT5t2LyOZ6LxoXuKMQ8yPRT86x9/6Qd4+nKYTlGUJSSYSoDX6oUOskESQQJhXZh2T6Sqz2MGmtimboH6y7quYD3gK1Rrk61tTAutVyXAPG9TAGf3Pg9+R1lYwlEdO5neVDp9PJFukESQEU5Y2F+CL5NSsKrGgStrmVY1pBDkbjsumDkno5rg6Mu4inDSHhVXKrUAbXLnCG7XuH3Tb06YP8+/4SrZBNY7329/Q2fvwwJyrAiL9MRvN5AaX1kNnpXi4nzYhAXefXaVJOsr2xeMq1VJ1yDYrCOu/rUEF/Iqb8inG26eeVQJ7tE3aXA=]]></Encrypt><MsgSignature><![CDATA[54649c9ee580d983f9b1a034b277055b233ff1de]]></MsgSignature></xml>";

                var options = new DouyinMicroAppOpenApiClientOptions()
                {
                    ComponentAppId = "tt5823bf96d3bd56c7",
                    PushEncodingAESKey = "jWmYm7qr5nMoAUwZRjGtBxmz3KA1tkAj3ykkR6q2B2C",
                    PushToken = "QDG6eK"
                };
                var client = new DouyinMicroAppOpenApiClient(options);
                var eventModel1 = client.DeserializeEventFromXml<ComponentPushTicketEvent>(callbackRawXml);
                var eventModel2 = client.DeserializeEventFromXml<ComponentPushTicketEvent>(callbackSecretXml);
                
                Assert.True(client.VerifyEventSignatureFromXml(callbackSecretXml));
                Assert.Equal("ByteDanceMicroApp", eventModel1.FromUserName);
                Assert.Equal("ByteDanceMicroApp", eventModel2.FromUserName);
                Assert.Equal("PUSH", eventModel1.Event);
                Assert.Equal("PUSH", eventModel2.Event);
                Assert.Equal("2019-01-14 12:45:10", eventModel1.CreateTimeString);
                Assert.Equal("2019-01-14 12:45:10", eventModel2.CreateTimeString);
                Assert.Equal("Ticket", eventModel1.MessageType);
                Assert.Equal("Ticket", eventModel2.MessageType);
                Assert.Equal("8c0da4968b0d1e28acbc1d738a56607d", eventModel1.Ticket);
                Assert.Equal("8c0da4968b0d1e28acbc1d738a56607d", eventModel2.Ticket);
            }
        }
    }
}
