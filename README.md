# SKIT.FlurlHttpClient.ByteDance

[![Gitee Stars](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance/badge/star.svg?title=Stars)](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance)
[![Gitee Forks](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance/badge/fork.svg?title=Forks)](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance)
[![GitHub Stars](https://img.shields.io/github/stars/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance?logo=github&label=Stars)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance)
[![GitHub Forks](https://img.shields.io/github/forks/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance?logo=github&label=Forks)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance)
[![Vistors](https://visitor-badge.laobi.icu/badge?page_id=fudiwei.DotNetCore.SKIT.FlurlHttpClient.ByteDance&title=Visitors)](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance)
[![License](https://img.shields.io/github/license/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance?label=License)](https://mit-license.org/)

基于 `Flurl.Http` 的字节跳动 HTTP API SDK，目前已包含字节小程序开放平台、抖音开放平台、抖店开放平台、巨量引擎开放平台、TikTok Developer、TikTok Shop 等模块。

> 更多 SKIT.FlurlHttpClient 系列开发工具包请[点此查看](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient)。

---

## 特性

-   基于 `Flurl.Http`，可与 `IHttpClientFactory` 集成。
-   支持 .NET Framework 4.6.1+、.NET Standard 2.0+、.NET Core 2.0+、.NET 5+。
-   支持 Windows / Linux / macOS 多平台部署。
-   支持 `System.Text.Json`（默认）和 `Newtonsoft.Json` 两种序列化方式。
-   强类型接口模型。
-   全异步式编程。
-   提供 SourceLink 调试符号文件。
-   完整、完善、完全的字节跳动 HTTP API 封装。

---

## 模块

|                 名称                 |                                                                                                                                                                                                     NuGet                                                                                                                                                                                                      |                      其他                      |
| :----------------------------------: | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: | :--------------------------------------------: |
| 字节小程序开放平台（小程序、小游戏） |         [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.ByteDance.MicroApp.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.ByteDance.MicroApp) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.ByteDance.MicroApp.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.ByteDance.MicroApp)         |     [开发文档](./docs/MicroApp/README.md)      |
|             抖音开放平台             |     [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.ByteDance.DouyinOpen.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.ByteDance.DouyinOpen) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.ByteDance.DouyinOpen.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.ByteDance.DouyinOpen)     |    [开发文档](./docs/DouyinOpen/README.md)     |
|   抖店开放平台（今日特卖、放心购）   |                                                                                                                                                                                                  _已停止维护_                                                                                                                                                                                                  |    [开发文档](./docs/DouyinShop/README.md)     |
|     巨量引擎开放平台（头条广告）     |                                                                                                                                                                                                    _开发中_                                                                                                                                                                                                    |                                                |
|           TikTok Developer           | [![NuGet Version](https://img.shields.io/nuget/v/SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.svg?label=NuGet)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.ByteDance.TikTokGlobal) <br> [![NuGet Download](https://img.shields.io/nuget/dt/SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.svg?sanitize=true&label=Downloads)](https://www.nuget.org/packages/SKIT.FlurlHttpClient.ByteDance.TikTokGlobal) | [Documentation](./docs/TikTokGlobal/README.md) |
|             TikTok Shop              |                                                                                                                                                                                                    _开发中_                                                                                                                                                                                                    |                                                |

---

## 参与贡献

-   GitHub Repo：https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance.git
-   Gitee Repo：https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.ByteDance.git

以上仓库地址同步更新，均可接受 Issue 或 Pull Request。

如何参与贡献请参阅 [CONTRIBUTING](./CONTRIBUTING.md)。

---

## 更新日志

详细更新说明请参阅 [CHANGELOG](./CHANGELOG.md)。
