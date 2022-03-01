# SKIT.FlurlHttpClient.ByteDance.TikTokShop

基于 `Flurl.Http` 的[抖店开放平台](https://op.jinritemai.com/) API 客户端。

---

## 功能

-   基于抖店开放平台 API 封装。

-   支持商家自研、软件服务商两种模式。

-   请求时自动生成签名，无需开发者手动干预。

-   提供了抖店开放平台 API 所需的 HMAC-SHA-256、MD5 等算法工具类。

-   提供了解析回调通知事件等扩展方法。

---

## 基础用法

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.ByteDance.TikTokShop

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.ByteDance.TikTokShop
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.ByteDance;
using SKIT.FlurlHttpClient.ByteDance.TikTokShop;

var options = new TikTokShopClientOptions()
{
    AppKey = "抖店开放平台应用 Key",
    AppSecret = "抖店开放平台应用密钥"
};
var client = new TikTokShopClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.ByteDance.TikTokShop;
using SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models;

/* 以订单详情查询接口为例 */
var request = new OrderDetailRequest()
{
    ShopOrderId = "店铺订单号"
};
var response = await client.ExecuteOrderDetailAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("支付金额：" + response.Data.ShopOrder.PayAmount);
    Console.WriteLine("支付时间：" + response.Data.ShopOrder.PayTimestamp);
}
else
{
    Console.WriteLine("错误代码：" + response.ErrorNumber);
    Console.WriteLine("错误描述：" + response.ErrorMessage);
}
```

---

## 高级技巧

-   [如何快速找到需要调用的 API 模型类名 / 方法名？](./Advanced_ModelDefinition.md)

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)

-   [如何解析回调通知事件？](./Advanced_EventDataDeserialization.md)

-   [如何验证回调通知事件签名？](./Advanced_EventDataSignatureVerification.md)

-   [如何扩展额外的 API？](./Advanced_Extensions.md)
