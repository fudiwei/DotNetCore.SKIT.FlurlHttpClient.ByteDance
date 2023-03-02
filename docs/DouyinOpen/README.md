# SKIT.FlurlHttpClient.ByteDance.DouyinOpen

基于 `Flurl.Http` 的[抖音开放平台](https://open.douyin.com/platform) HTTP API SDK。

---

## 功能

-   基于抖音开放平台 API 封装。
-   提供了抖音开放平台 API 所需的 AES、MD5、SHA-1、SHA-256、HMAC-SHA-256 等算法工具类。
-   提供了生成授权链接、生成 JSBridge 签名、解析回调通知事件、解密手机号码等扩展方法。

---

## 快速入门

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.ByteDance.DouyinOpen

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.ByteDance.DouyinOpen
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.ByteDance.DouyinOpen;

var options = new DouyinOpenClientOptions()
{
    ClientKey = "抖音开放平台应用 Key",
    ClientSecret = "抖音开放平台应用密钥"
};
var client = new DouyinOpenClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.ByteDance.DouyinOpen;
using SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models;

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

## 基础用法

-   [如何快速找到需要调用的 API 模型类名 / 方法名？](./Basic_ModelDefinition.md)

-   [如何解析 Webhook 事件？](./Basic_EventDeserialization.md)

-   [如何验证 Webhook 事件签名？](./Basic_EventSignatureVerification.md)

-   [如何生成 JSBridge 初始化时所需的参数及签名？](./Basic_Parameters.md)

-   [如何解密用户公开信息中的手机号码？](./Basic_MobileNumberDecryption.md)

-   [如何解密抖音生活服务 SPI 接口中的加密字段？](./Basic_GoodLifeSPIDecryption.md)

-   [如何自定义额外的 API 接口？](./Basic_Extensions.md)

---

## 高级技巧

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)
