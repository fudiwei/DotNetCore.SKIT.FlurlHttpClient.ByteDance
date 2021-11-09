# SKIT.FlurlHttpClient.ByteDance.MicroApp

基于 `Flurl.Http` 的[字节小程序开放平台](https://microapp.bytedance.com/) API 客户端。

---

## 功能

-   基于字节小程序开放平台 API 封装。

-   提供了字节小程序开放平台 API 所需的 HMAC-SHA-256、SHA-1、MD5 等算法工具类。

-   提供了解析回调通知事件等扩展方法。

---

## 基础用法

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.ByteDance.MicroApp

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.ByteDance.MicroApp
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.ByteDance;
using SKIT.FlurlHttpClient.ByteDance.MicroApp;

var options = new ByteDanceMicroAppClientOptions()
{
    AppId = "字节小程序 AppId",
    AppSecret = "字节小程序 AppSecret",
    ECPaySalt = "担保支付相关服务的密钥，不用则不填"
};
var client = new ByteDanceMicroAppClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.ByteDance.MicroApp;
using SKIT.FlurlHttpClient.ByteDance.MicroApp.Models;

/* 以获取用户授权登录凭证接口为例 */
var request = new AppsJsCode2SessionRequest()
{
    Code = "登录 Code，与匿名 Code 二选一",
    AnoymousCode = "匿名 Code，与登录 Code 二选一"
};
var response = await client.ExecuteAppsJsCode2SessionAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("会话密钥：" + response.SessionKey);
    Console.WriteLine("用户 OpenId：" + response.OpenId);
    Console.WriteLine("匿名 OpenId：" + response.AnonymousOpenId);
}
else
{
    Console.WriteLine("错误代码：" + response.ErrorCode);
    Console.WriteLine("错误描述：" + response.ErrorMessage);
}
```

---

## 高级技巧

-   [如何快速找到需要调用的 API 模型类名 / 方法名？](./Advanced_ModelDefinition.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)

-   [如何解析回调通知事件？](./Advanced_EventDataDeserialization.md)

-   [如何验证回调通知事件签名？](./Advanced_EventDataSignatureVerification.md)

-   [如何扩展额外的 API？](./Advanced_Extensions.md)
