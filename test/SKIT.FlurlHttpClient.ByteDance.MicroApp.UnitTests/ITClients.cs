namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.UnitTests
{
    internal class ITClients
    {
        public static DouyinMicroAppClient CreateInstance()
        {
            return new DouyinMicroAppClient(new DouyinMicroAppClientOptions()
            {
                AppId = ITConfigs.Credentials_AppId,
                AppSecret = ITConfigs.Credentials_AppSecret
            });
        }
    }
}
