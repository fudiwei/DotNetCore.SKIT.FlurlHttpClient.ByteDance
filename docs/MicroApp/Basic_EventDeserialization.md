## 如何解析回调通知事件？

---

对于抖音小程序推送过来的回调通知事件，本库封装了直接解析成事件模型的扩展方法，下面给出一个示例：

```csharp
/* 如果是 JSON 格式的通知内容，以 text 事件为例 */
string webhookJson = "{ ... }";
var webhookModel = client.DeserializeEventFromJson<Events.TextMessageEvent>(webhookJson);

/* 如果是 XML 格式的通知内容，以 text 事件为例 */
string webhookXml = "<xml> ... </xml>";
var webhookModel = client.DeserializeEventFromXml<Events.TextMessageEvent>(webhookXml);
```

完整的回调通知模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.ByteDance.MicroApp/Events_、_src/SKIT.FlurlHttpClient.ByteDance.Api/ExtendedSDK/OpenApi/Events_、_src/SKIT.FlurlHttpClient.ByteDance.Api/ExtendedSDK/ProductApi/Events_ 目录。

---

### 事件类型：

由于抖音小程序会将全部事件推送到同一个回调通知地址上，开发者需要根据事件类型才能决定如何反序列化。

这里给出两种解决方案。

一种是利用 `System.Xml.Linq`：

```csharp
XDocument xDoc = XDocument.Parse(webhookXml);
string msgType = xDoc.Root?.Element("MsgType")?.Value?.ToUpper();
```

另一种是利用本库的扩展方法：

```csharp
ByteDanceMicroAppEvent eventModel = client.DeserializeEventFromXml(webhookXml);
string msgType = eventModel.MessageType?.ToUpper();

switch (msgType)
{
    case "TEXT":
        {
            var webhookModel = client.DeserializeEventFromXml<Events.TextMessageEvent>(webhookXml);
        }
        break;
    // 省略其他情况
}
```
