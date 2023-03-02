## 如何生成 JSBridge 初始化时所需的参数及签名？

---

> 请先自行阅读：
>
> [《抖音开放平台开发文档 - 授权：JS 验证签名》](https://open.douyin.com/platform/doc/6850443440044410888)

你可根据官方文档的规则利用本库提供的 `MD5Utility` 工具类自行进行签名生成。

此外，本库还封装了直接生成参数及签名的扩展方法，下面给出一个示例：

```csharp
/* 以生成 sdk.config() 所需参数为例 */
var request = new Models.JSGetTicketRequest()
{
    AccessToken = "抖音开放平台的 AccessToken"
};
var response = await client.ExecuteJSGetTicketAsync(request);
var paramMap = client.GenerateParametersForJSBridgeConfig(response.Data.Ticket, "https://example.com");
```

---

### 【附】生成参数相关扩展方法速查表：

-   生成客户端 JSBridge `sdk.config` 所需的参数字典：`GenerateParametersForJSBridgeConfig`

-   生成抖音获取授权临时票据的 URL：`GenerateParameterizedUrlForPlatformOAuthConnect`
