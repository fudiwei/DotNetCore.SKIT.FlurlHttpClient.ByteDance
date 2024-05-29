# SKIT.FlurlHttpClient.ByteDance.MicroApp

基于 `Flurl.Http` 的[抖音小程序开放平台](https://microapp.bytedance.com/) HTTP API SDK。

本模块仅支持抖音小程序专属的 API，如需接入与抖音开放平台共享的 API，请移步 [`SKIT.FlurlHttpClient.ByteDance.DouyinOpen`](../DouyinOpen/README.md) 模块。

---

## 功能

-   基于抖音小程序开放平台 API 封装。
-   提供了抖音小程序所需的 RSA、AES、MD5、SHA-1、HMAC-SHA-256 等算法工具类。
-   提供了解析回调通知事件等扩展方法。
-   配合 [SKIT.FlurlHttpClient.ByteDance.DouyinOpen](../DouyinOpen/README.md) 模块，可无缝对接抖音开放平台。

---

## 快速入门

> [!IMPORTANT]
> 此目录下的文档适用于 v3.x 版本的模块。如果你正在使用 2.x 版本，请移步至 GitHub/Gitee 的已归档分支。

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
using SKIT.FlurlHttpClient.ByteDance.MicroApp;

var options = new DouyinMicroAppClientOptions()
{
    AppId = "抖音小程序 AppId",
    AppSecret = "抖音小程序 AppSecret",
    AppKeyVersion = "应用密钥版本号，用于交易系统等需要请求签名的 API，不用则不填",
    AppPrivateKey = "应用密钥私钥，用于交易系统等需要请求签名的 API，不用则不填",
    ECPaySalt = "担保支付相关服务的密钥，不用则不填"
};
var client = DouyinMicroAppClientBuilder.Create(options).Build();
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
    Console.WriteLine("错误代码：" + response.ErrorNumber);
    Console.WriteLine("错误描述：" + response.ErrorTips);
}
```

### 独立的扩展客户端（服务商平台、泛知识课程库、泛知识角色系统、直播小玩法等）：

部分 API 的接入点、接口模型公共参数等配置项与基础 API 完全不同，需要使用独立的扩展客户端。

-   服务商平台：

```csharp
using SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi;

var options = new DouyinMicroAppOpenApiClientOptions()
{
    ComponentAppId = "第三方应用 AppId",
    ComponentAppSecret = "第三方应用 AppSecret"
};
var client = DouyinMicroAppOpenApiClientBuilder.Create(options).Build();
```

-   泛知识课程库：

```csharp
using SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi;

var options = new DouyinMicroAppProductApiClientOptions()
{
    AppId = "抖音小程序 AppId",
    AppSecret = "抖音小程序 AppSecret"
};
var client = DouyinMicroAppProductApiClientBuilder.Create(options).Build();
```

-   泛知识角色系统：

```csharp
using SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi;

var options = new DouyinMicroAppRoleApiClientOptions()
{
    AppId = "抖音小程序 AppId",
    AppSecret = "抖音小程序 AppSecret"
};
var client = DouyinMicroAppRoleApiClientBuilder.Create(options).Build();
```

-   直播小玩法：

```csharp
using SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast;

var options = new DouyinMicroAppWebcastClientOptions()
{
    AppId = "抖音小程序 AppId",
    AppSecret = "抖音小程序 AppSecret",
    AppKeyVersion = "应用密钥版本号",
    AppPrivateKey = "应用密钥私钥",
    PlatformPublicKey = "平台密钥公钥"
};
var client = DouyinMicroAppWebcastClientBuilder.Create(options).Build();
```

这些扩展客户端在用法上基础客户端完全相同，只需引入各自的命名空间即可。

---

## 基础用法

-   ⭐ [如何快速找到需要调用的 API 模型类名 / 方法名？](./Basic_ModelDefinition.md)

-   [如何解析回调通知事件？](./Basic_EventDeserialization.md)

-   [如何验证回调通知事件签名？](./Basic_EventSignatureVerification.md)

-   [如何自定义额外的 API 接口？](./Basic_Extensions.md)

---

## 高级技巧

-   [配置 JSON 序列化器](./Advanced_JsonSerializer.md)

-   [配置 HttpClient](./Advanced_HttpClient.md)

-   [使用拦截器](./Advanced_Interceptor.md)

-   [避免内存泄漏](./Advanced_Dispose.md)

-   [与 `IHttpClientFactory` 集成](./Advanced_HttpClientFactory.md)

---

## 迁移指南

-   [v3.x 迁移指南](./Migration_V3.md)
