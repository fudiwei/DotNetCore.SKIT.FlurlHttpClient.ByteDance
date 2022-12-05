namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.UnitTests
{
    internal class TestClients
    {
        static TestClients()
        {
            Instance = new DouyinShopClient(new DouyinShopClientOptions()
            {
                AppKey = TestConfigs.DouyinShopAppKey,
                AppSecret = TestConfigs.DouyinShopAppSecret
            });
        }

        public static readonly DouyinShopClient Instance;
    }
}
