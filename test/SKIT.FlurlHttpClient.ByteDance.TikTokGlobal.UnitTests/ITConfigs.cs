using System.Text.Json;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.UnitTests
{
    internal class ITConfigs
    {
        internal class AppSettings
        {
            public static class Types
            {
                public class Credentials
                {
                    public string? ClientKey { get; set; }
                    public string? ClientSecret { get; set; }
                    public string? AccessToken { get; set; }
                }
            }

            public Types.Credentials? Credentials { get; set; }
        }

        static ITConfigs()
        {
            // NOTICE:  请在项目根目录下按照 appsettings.json 的格式新建 appsettings.local.json 填入测试参数。
            // WARNING: 请在 DEBUG 模式下运行测试用例。
            // WARNING: 敏感信息请不要提交到 git！

            try
            {
                using var stream = File.OpenRead("appsettings.local.json");
                var appsettings = JsonSerializer.Deserialize<AppSettings>(stream, JsonSerializerOptions.Web)!;

                Credentials_ClientKey = appsettings.Credentials?.ClientKey ?? string.Empty;
                Credentials_ClientSecret = appsettings.Credentials?.ClientSecret ?? string.Empty;
                Credentials_AccessToken = appsettings.Credentials?.AccessToken ?? string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception("加载配置文件 appsettings.local.json 失败，请查看 `InnerException` 了解具体失败原因", ex);
            }
        }

        public static readonly string Credentials_ClientKey;
        public static readonly string Credentials_ClientSecret;
        public static readonly string Credentials_AccessToken;
    }
}
