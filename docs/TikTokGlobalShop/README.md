# SKIT.FlurlHttpClient.ByteDance.TikTokGlobal

A HTTP API SDK for [TikTok Shop Open Platform](https://partner.tiktokshop.com/) based on `Flurl.Http`.

---

## Features

-   Based on TikTok Shop Open Platform API.
-   Auto-generated signature on API requests.
-   Provides some algorithm utilities (such as HMAC-SHA-256).

---

## Get Started

### Installation:

```shell
# Install by NuGet
> Install-Package SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop

# Install by .NET CLI
> dotnet add package SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop
```

### Initialization:

```csharp
using SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop;

var options = new TikTokShopClientOptions()
{
    AppKey = "${APP_KEY}",
    AppSecret = "${APP_SECRET}}"
};
var client = new TikTokShopClient(options);
```

### Requests & Responses:

```csharp
using SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop;
using SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models;

/* Example: Get Order List */
var request = new OrderSearchOrdersRequest()
{
    ShopId = "${SHOP_ID}"
};
var response = await client.ExecuteOrderSearchOrdersAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("Orders: " + response.Data.OrderList);
    Console.WriteLine("Total: " + response.Data.TotalCount);
}
else
{
    Console.WriteLine("ErrorCode: " + response.ErrorCode);
    Console.WriteLine("ErrorMessage: " + response.ErrorMessage);
}
```

---

## Basic Usage

-   [API Reference Manual](./Basic_ModelDefinition.md)
