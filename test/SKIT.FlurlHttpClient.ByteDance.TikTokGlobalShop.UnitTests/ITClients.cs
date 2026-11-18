namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.UnitTests
{
    internal class ITClients
    {
        public static TikTokShopClient CreateInstance()
        {
            return new TikTokShopClient(new TikTokShopClientOptions()
            {
                AppKey = ITConfigs.Credentials_AppKey,
                AppSecret = ITConfigs.Credentials_AppSecret
            });
        }
    }
}
