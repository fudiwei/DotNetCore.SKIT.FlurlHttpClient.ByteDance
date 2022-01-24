namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new OceanEngineClient(new OceanEngineClientOptions()
            {
                AppId = TestConfigs.OceanEngineAppId,
                AppSecret = TestConfigs.OceanEngineAppSecret
            });
        }

        public static readonly OceanEngineClient Instance;
    }
}
