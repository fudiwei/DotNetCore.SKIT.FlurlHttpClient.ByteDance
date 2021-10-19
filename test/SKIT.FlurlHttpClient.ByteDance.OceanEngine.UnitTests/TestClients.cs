using System;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            Instance = new OceanEngineClient(new OceanEngineClientOptions()
            {
                AppId = TestConfigs.OceanEngineAppId,
                AppSecret =  TestConfigs.OceanEngineAppSecret
            });
        }

        public static readonly OceanEngineClient Instance;
    }
}
