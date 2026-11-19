# SKIT.FlurlHttpClient.ByteDance.TikTokGlobal

A client SDK for [TikTok Developer](https://developers.tiktok.com/) API based on `Flurl.Http`.

---

## Features

- Encapsulates TikTok Developer API.
- Provides some algorithm utilities (such as HMAC-SHA-256).

---

## Get Started

> [!IMPORTANT]
> The documents are applicable to version 4.x of this SDK. If you are using other versions, please move to the archived branches on GitHub/Gitee.

### Installation:

```shell
# Install by NuGet
> Install-Package SKIT.FlurlHttpClient.ByteDance.TikTokGlobal

# Install by .NET CLI
> dotnet add package SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
```

### Initialization:

```csharp
using SKIT.FlurlHttpClient.ByteDance.TikTokGlobal;

var options = new TikTokV2ClientOptions()
{
    ClientKey = "${CLIENT_KEY}",
    ClientSecret = "${CLIENT_SECRET}}"
};
var client = TikTokV2ClientBuilder.Create(options).Build();
```

### Requests & Responses:

```csharp
using SKIT.FlurlHttpClient.ByteDance.TikTokGlobal;
using SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models;

/* Example: Fetch Access Token Using Authorization Code */
var request = new OAuthAccessTokenRequest()
{
    Code = "AUTHORIZATION_CODE"
};
var response = await client.ExecuteOAuthAccessTokenAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("AccessToken: " + response.Data.AccessToken);
    Console.WriteLine("OpenId: " + response.Data.OpenId);
}
else
{
    Console.WriteLine("Error: " + response.ErrorCode);
    Console.WriteLine("ErrorDescription: " + response.ErrorDescription);
}
```

---

## Basic Usage

- [API Reference Manual](./Basic_ModelDefinition.md)
