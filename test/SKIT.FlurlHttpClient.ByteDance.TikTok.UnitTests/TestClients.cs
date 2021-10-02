using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            Instance = new TikTokClient(new TikTokClientOptions()
            { 
                ClientKey = TestConfigs.TikTokClientKey,
                ClientSecret =  TestConfigs.TikTokClientSecret
            });
        }

        public static readonly TikTokClient Instance;
    }
}
