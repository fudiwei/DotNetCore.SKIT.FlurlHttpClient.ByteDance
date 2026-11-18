namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.UnitTests
{
    internal class ITClients
    {
        public static OceanEngineClient CreateInstance()
        {
            return new OceanEngineClient(new OceanEngineClientOptions()
            {
                AppId = ITConfigs.Credentials_AppId,
                AppSecret = ITConfigs.Credentials_AppSecret
            });
        }
    }
}
