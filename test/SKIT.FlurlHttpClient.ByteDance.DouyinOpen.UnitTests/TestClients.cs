namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new DouyinOpenClient(new DouyinOpenClientOptions()
            {
                ClientKey = TestConfigs.DouyinOpenClientKey,
                ClientSecret = TestConfigs.DouyinOpenClientSecret
            });
        }

        public static readonly DouyinOpenClient Instance;
    }
}
