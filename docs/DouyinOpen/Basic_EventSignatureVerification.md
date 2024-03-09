## 如何验证 Webhook 事件签名？

---

> 请先自行阅读：
>
> [《抖音开放平台开发文档 - Webhooks：概述》](https://open.douyin.com/platform/doc/6850452582826067975)

同样的，你既可以利用本库提供的 `SHA1Utility` 工具类自行进行签名验证，也可以通过扩展方法实现：

```csharp
/* 验证 Webhook 事件签名 */
bool ret = client.VerifyEventSignature(
    webhookJson: "抖音 Webhook 事件中请求正文",
    webhookSignature: "抖音 Webhook 事件中的 X-Douyin-Signature 字段"
);
```
