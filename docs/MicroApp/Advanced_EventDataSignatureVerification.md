## 如何验证回调通知事件签名？

---

> 请先自行阅读：
>
> [《字节小程序文档 - 消息推送客服：验证消息来自今日头条》](https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/component/message-push-customer-service)

同样的，你既可以利用本库提供的 `SHA1Utility` 工具类自行进行签名验证，也可以通过扩展方法实现：

```csharp
/* 在初始化客户端时需指定服务器推送的相关参数 */
var options = new ByteDanceMicroAppClientOptions()
{
    AppId = "字节小程序 AppId",
    AppSecret = "字节小程序 AppSecret",
    PushToken = "服务器推送的 Token"
};
var client = new ByteDanceMicroAppClient(options);

/* 验证字节小程序服务器 */
bool ret = client.VerifyEventSignatureForEcho(
    callbackTimestamp: "字节小程序回调通知中的 timestamp 字段",
    callbackNonce: "字节小程序回调通知中的 nonce 字段",
    callbackMessage: "头条回调通知中的 msg 字段",
    callbackSignature: "头条回调通知中的 signature 字段"
);
```
