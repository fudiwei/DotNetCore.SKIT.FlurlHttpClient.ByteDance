using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.UnitTests
{
    class TestConfigs
    {
        static TestConfigs()
        {
            // NOTICE: 请在项目根目录下按照 appsettings.json 的格式填入测试参数。
            // WARN: 敏感信息请不要提交到 git！

            using var stream = File.OpenRead("appsettings.json");
            using var json = JsonDocument.Parse(stream);

            var config = json.RootElement.GetProperty("TikTokShopConfig");
            TikTokShopAppKey = config.GetProperty("AppKey").GetString();
            TikTokShopAppSecret = config.GetProperty("AppSecret").GetString();
            TikTokShopAccessToken = config.GetProperty("AccessToken").GetString();

            ProjectSourceDirectory = json.RootElement.GetProperty("ProjectSourceDirectory").GetString();
            ProjectTestDirectory = json.RootElement.GetProperty("ProjectTestDirectory").GetString();
        }

        public static readonly string TikTokShopAppKey;
        public static readonly string TikTokShopAppSecret;
        public static readonly string TikTokShopAccessToken;

        public static readonly string ProjectSourceDirectory;
        public static readonly string ProjectTestDirectory;
    }
}
