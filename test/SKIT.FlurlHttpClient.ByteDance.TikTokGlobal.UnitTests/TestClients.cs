namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new TikTokV2Client(new TikTokV2ClientOptions()
            {
                ClientKey = TestConfigs.TikTokClientKey,
                ClientSecret = TestConfigs.TikTokClientSecret
            });
        }

        public static readonly TikTokV2Client Instance;
    }
}
