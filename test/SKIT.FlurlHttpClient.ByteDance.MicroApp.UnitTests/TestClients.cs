using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            Instance = new ByteDanceMicroAppClient(new ByteDanceMicroAppClientOptions()
            {
                AppId = TestConfigs.MicroAppAppAppId,
                AppSecret =  TestConfigs.MicroAppAppSecret
            });
        }

        public static readonly ByteDanceMicroAppClient Instance;
    }
}
