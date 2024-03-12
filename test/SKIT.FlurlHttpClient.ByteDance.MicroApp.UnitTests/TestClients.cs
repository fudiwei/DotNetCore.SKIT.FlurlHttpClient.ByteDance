namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new DouyinMicroAppClient(new DouyinMicroAppClientOptions()
            {
                AppId = TestConfigs.DouyinMicroAppId,
                AppSecret = TestConfigs.DouyinMicroAppSecret
            });
        }

        public static readonly DouyinMicroAppClient Instance;
    }
}
