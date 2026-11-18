namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.UnitTests
{
    internal class ITClients
    {
        public static DouyinOpenClient CreateInstance()
        {
            return new DouyinOpenClient(new DouyinOpenClientOptions()
            {
                ClientKey = ITConfigs.Credentials_ClientKey,
                ClientSecret = ITConfigs.Credentials_ClientSecret
            });
        }
    }
}
