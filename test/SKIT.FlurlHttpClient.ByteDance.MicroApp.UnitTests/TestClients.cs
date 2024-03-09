namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new DouyinMicroAppClient(new DouyinMicroAppClientOptions()
            {
                AppId = TestConfigs.ByteDanceMicroAppId,
                AppSecret = TestConfigs.ByteDanceMicroAppSecret
            });
        }

        public static readonly DouyinMicroAppClient Instance;
    }
}
