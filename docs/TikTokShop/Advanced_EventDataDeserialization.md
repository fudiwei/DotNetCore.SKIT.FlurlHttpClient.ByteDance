## 如何解析回调通知事件？

---

对于抖店开放平台推送过来的回调通知事件，本库封装了直接解析成事件模型的扩展方法，下面给出一个示例：

```csharp
/* 以 doudian_trade_TradeCreate 事件为例 */
string callbackJson = "{ ... }";
var callbackModels = client.DeserializeEvents<Events.TradeCreateEvent>(callbackJson);
```

这里需要注意，抖店开放平台是以列表形式推送事件的。

完整的回调通知模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.ByteDance.TikTokShop/Events_ 目录。
