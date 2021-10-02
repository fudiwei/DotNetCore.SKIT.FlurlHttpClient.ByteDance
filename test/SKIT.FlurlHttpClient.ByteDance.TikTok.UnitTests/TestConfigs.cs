using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.UnitTests
{
    class TestConfigs
    {
        static TestConfigs()
        {
            // NOTICE: 请在项目根目录下按照 appsettings.json 的格式填入测试参数。
            // WARN: 敏感信息请不要提交到 git！

            using var stream = File.OpenRead("appsettings.json");
            using var json = JsonDocument.Parse(stream);

            var config = json.RootElement.GetProperty("TikTokConfig");
            TikTokClientKey = config.GetProperty("ClientKey").GetString();
            TikTokClientSecret = config.GetProperty("ClientSecret").GetString();
            TikTokAccessToken = config.GetProperty("AccessToken").GetString();

            ProjectSourceDirectory = json.RootElement.GetProperty("ProjectSourceDirectory").GetString();
            ProjectTestDirectory = json.RootElement.GetProperty("ProjectTestDirectory").GetString();
        }

        public static readonly string TikTokClientKey;
        public static readonly string TikTokClientSecret;
        public static readonly string TikTokAccessToken;

        public static readonly string ProjectSourceDirectory;
        public static readonly string ProjectTestDirectory;
    }
}
