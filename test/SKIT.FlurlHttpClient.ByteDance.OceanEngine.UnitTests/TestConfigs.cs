using System;
using System.IO;
using System.Text.Json;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.UnitTests
{
    internal class TestConfigs
    {
        static TestConfigs()
        {
            // NOTICE:  请在项目根目录下按照 appsettings.json 的格式新建 appsettings.local.json 填入测试参数。
            // WARNING: 请在 DEBUG 模式下运行测试用例。
            // WARNING: 敏感信息请不要提交到 git！

            try
            {
                using var stream = File.OpenRead("appsettings.local.json");
                using var json = JsonDocument.Parse(stream);

                var config = json.RootElement.GetProperty("TestConfigs");
                OceanEngineAppId = config.GetProperty("AppId").GetInt64();
                OceanEngineAppSecret = config.GetProperty("AppSecret").GetString()!;
                OceanEngineAccessToken = config.GetProperty("AccessToken").GetString()!;
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因", ex);
            }
        }

        public static readonly long OceanEngineAppId;
        public static readonly string OceanEngineAppSecret;
        public static readonly string OceanEngineAccessToken;
    }
}
