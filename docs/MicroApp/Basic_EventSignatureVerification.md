## 如何验证回调通知事件签名？

---

> 请先自行阅读：
>
> [《抖音小程序文档 - 消息推送客服：验证消息来自今日头条》](https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/component/message-push-customer-service)

同样的，你既可以利用本库提供的 `SHA1Utility` 工具类自行进行签名验证，也可以通过扩展方法实现：

```csharp
/* 在初始化客户端时需指定服务器推送的相关参数 */
var options = new DouyinMicroAppClientOptions()
{
    // 其他配置项略
    PushToken = "服务器推送的 Token"
};
var client = DouyinMicroAppClientBuilder.Create(options).Build();

/* 验证抖音服务器 */
bool ret = client.VerifyEventSignatureForEcho(
    webhookTimestamp: "抖音小程序回调通知中的 timestamp 字段",
    webhookNonce: "抖音小程序回调通知中的 nonce 字段",
    webhookMsg: "抖音回调通知中的 msg 字段",
    webhookSignature: "抖音回调通知中的 signature 字段"
);
```
