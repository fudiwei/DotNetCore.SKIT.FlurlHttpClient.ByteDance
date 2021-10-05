## 如何验证回调通知事件签名？

---

> 请先自行阅读：
>
> [《抖店开放平台文档中心 - 消息推送服务接入指南：消息解析》](https://op.jinritemai.com/docs/guide-docs/153/99)

同样的，你既可以利用本库提供的 `MD5Utility` 工具类自行进行签名验证，也可以通过扩展方法实现：

```csharp
/* 验证回调通知事件签名 */
bool ret = client.VerifyEventSignature(
    callbackJson: "抖店回调通知中请求正文",
    callbackSignature: "抖店回调通知中的 event-sign 字段"
);
```
