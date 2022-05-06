## 如何解析 Webhook 事件？

---

对于抖音开放平台推送过来的 Webhook 事件，本库封装了直接解析成事件模型的扩展方法，下面给出一个示例：

```csharp
/* 以 authorize 事件为例 */
string callbackJson = "{ ... }";
var callbackModel = client.DeserializeEvent<Events.AuthorizeEvent>(callbackJson);
```

完整的 Webhook 模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.ByteDance.TikTok/Events_ 目录。

---

### 事件类型：

由于抖音开放平台会将全部事件推送到同一个 Webhook 地址上，开发者需要根据事件类型才能决定如何反序列化。

这里给出一种解决方案：

```csharp
TikTokEvent eventModel = client.DeserializeEvent(callbackJson);
string eventType = eventModel.Event?.ToLower();

switch (eventType)
{
    case "authorize":
        {
            var callbackModel = client.DeserializeEvent<Events.AuthorizeEvent>(callbackJson);
        }
        break;
    // 省略其他情况
}
```
