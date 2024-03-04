# SKIT.FlurlHttpClient.ByteDance.TikTokGlobal

A HTTP API SDK for [TikTok Developer API](https://developers.tiktok.com/) based on `Flurl.Http`.

---

## Features

-   Based on TikTok Developer API.

---

## Get Started

> [!IMPORTANT]
> The documents are applicable to version 3.x of this SDK. If you are using version 2.x, please move to the archived branches on GitHub/Gitee.

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

-   [API Reference Manual](./Basic_ModelDefinition.md)
