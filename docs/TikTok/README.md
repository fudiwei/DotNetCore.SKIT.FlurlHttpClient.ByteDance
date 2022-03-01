# SKIT.FlurlHttpClient.ByteDance.TikTok

基于 `Flurl.Http` 的[抖音开放平台](https://open.douyin.com/platform) API 客户端。

---

## 功能

-   基于抖音开放平台 API 封装。

-   提供了抖音开放平台 API 所需的 HMAC-SHA-256、SHA-1、MD5 等算法工具类。

-   提供了生成授权链接、生成 JSBridge 签名、解析回调通知事件等扩展方法。

---

## 基础用法

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.ByteDance.TikTok

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.ByteDance.TikTok
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.ByteDance;
using SKIT.FlurlHttpClient.ByteDance.TikTok;

var options = new TikTokClientOptions()
{
    Endpoints = TikTokEndpoints.DOUYIN, // 部分接口需指定接入点，默认值 open.douyin.com
    ClientKey = "抖音开放平台应用 Key",
    ClientSecret = "抖音开放平台应用密钥"
};
var client = new TikTokClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.ByteDance.TikTok;
using SKIT.FlurlHttpClient.ByteDance.TikTok.Models;

/* 以获取用户信息接口为例 */
var request = new OAuthUserInfoRequest()
{
    AccessToken = "抖音开放平台的 AccessToken",
    OpenId = "用户唯一标识"
};
var response = await client.ExecuteOAuthUserInfoAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("昵称：" + response.Data.Nickname);
    Console.WriteLine("头像：" + response.Data.AvatarUrl);
}
else
{
    Console.WriteLine("错误代码：" + response.Extra?.ErrorCode);
    Console.WriteLine("错误描述：" + response.Extra?.ErrorDescription);
}
```

---

## 高级技巧

-   [如何快速找到需要调用的 API 模型类名 / 方法名？](./Advanced_ModelDefinition.md)

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)

-   [如何解析 Webhook 事件？](./Advanced_EventDataDeserialization.md)

-   [如何验证 Webhook 事件签名？](./Advanced_EventDataSignatureVerification.md)

-   [如何生成 JSBridge 初始化时所需的参数及签名？](./Advanced_Parameters.md)

-   [如何扩展额外的 API？](./Advanced_Extensions.md)
