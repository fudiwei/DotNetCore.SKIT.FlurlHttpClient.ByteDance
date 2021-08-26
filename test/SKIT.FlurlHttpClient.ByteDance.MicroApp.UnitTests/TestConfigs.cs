using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    class TestConfigs
    {
        static TestConfigs()
        {
            // NOTICE: 请在项目根目录下按照 appsettings.json 的格式填入测试参数。
            // WARN: 敏感信息请不要提交到 git！

            using var stream = File.OpenRead("appsettings.json");
            using var json = JsonDocument.Parse(stream);

            var config = json.RootElement.GetProperty("ByteDanceMicroAppConfig");
            MicroAppAppAppId = config.GetProperty("AppId").GetString();
            MicroAppAppSecret = config.GetProperty("AppSecret").GetString();
            MicroAppAccessToken = config.GetProperty("AccessToken").GetString();

            ProjectSourceDirectory = json.RootElement.GetProperty("ProjectSourceDirectory").GetString();
            ProjectTestDirectory = json.RootElement.GetProperty("ProjectTestDirectory").GetString();
        }

        public static readonly string MicroAppAppAppId;
        public static readonly string MicroAppAppSecret;
        public static readonly string MicroAppAccessToken;

        public static readonly string ProjectSourceDirectory;
        public static readonly string ProjectTestDirectory;
    }
}
