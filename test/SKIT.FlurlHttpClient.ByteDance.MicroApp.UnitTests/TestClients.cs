namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new ByteDanceMicroAppClient(new ByteDanceMicroAppClientOptions()
            {
                AppId = TestConfigs.ByteDanceMicroAppId,
                AppSecret = TestConfigs.ByteDanceMicroAppSecret
            });
        }

        public static readonly ByteDanceMicroAppClient Instance;
    }
}
