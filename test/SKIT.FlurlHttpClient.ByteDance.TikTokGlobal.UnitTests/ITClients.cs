namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.UnitTests
{
    internal class ITClients
    {
        public static TikTokV2Client CreateInstance()
        {
            return new TikTokV2Client(new TikTokV2ClientOptions()
            {
                ClientKey = ITConfigs.Credentials_ClientKey,
                ClientSecret = ITConfigs.Credentials_ClientSecret
            });
        }
    }
}
