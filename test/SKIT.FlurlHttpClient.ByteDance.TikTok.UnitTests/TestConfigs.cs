using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.UnitTests
{
    class TestConfigs
    {
        static TestConfigs()
        {
            // NOTICE: 请在项目根目录下按照 appsettings.json 的格式新建 appsettings.local.json 填入测试参数。
            // WARN: 敏感信息请不要提交到 git！

            try
            {
                using var stream = File.OpenRead("appsettings.local.json");
                using var json = JsonDocument.Parse(stream);

                var config = json.RootElement.GetProperty("TestConfig");
                TikTokClientKey = config.GetProperty("ClientKey").GetString();
                TikTokClientSecret = config.GetProperty("ClientSecret").GetString();
                TikTokAccessToken = config.GetProperty("AccessToken").GetString();

                ProjectSourceDirectory = json.RootElement.GetProperty("ProjectSourceDirectory").GetString();
                ProjectTestDirectory = json.RootElement.GetProperty("ProjectTestDirectory").GetString();
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因", ex);
            }
        }

        public static readonly string TikTokClientKey;
        public static readonly string TikTokClientSecret;
        public static readonly string TikTokAccessToken;

        public static readonly string ProjectSourceDirectory;
        public static readonly string ProjectTestDirectory;
    }
}
