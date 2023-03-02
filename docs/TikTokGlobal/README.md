# SKIT.FlurlHttpClient.ByteDance.TikTokGlobal

A HTTP API SDK for [TikTok Developer](https://developers.tiktok.com/) based on `Flurl.Http`.

---

## Features

-   Based on TikTok Developer Open API.

---

## Get Started

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

var options = new TikTokClientOptions()
{
    ClientKey = "${CLIENT_KEY}",
    ClientSecret = "${CLIENT_SECRET}}"
};
var client = new TikTokClient(options);
```

### Requests & Responses:

```csharp
using SKIT.FlurlHttpClient.ByteDance.TikTokGlobal;
using SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models;

/* Example: Fetch Access Token Using Authorization Code */
var request = new OAuthAccessTokenRequest()
{
    Code = "${AUTHORIZATION_CODE}"
};
var response = await client.ExecuteOAuthAccessTokenAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("AccessToken: " + response.Data.AccessToken);
    Console.WriteLine("OpenId: " + response.Data.OpenId);
}
else
{
    Console.WriteLine("ErrorCode: " + response.Error?.ErrorCode);
    Console.WriteLine("ErrorMessage: " + response.Error?.ErrorMessage);
}
```
