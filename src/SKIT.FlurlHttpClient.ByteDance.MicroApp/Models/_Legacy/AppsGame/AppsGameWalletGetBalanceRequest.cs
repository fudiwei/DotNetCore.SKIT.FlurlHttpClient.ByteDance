namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/game/wallet/get_balance 接口的请求。</para>
    /// </summary>
    public class AppsGameWalletGetBalanceRequest : AppsGameWalletRequestBase
    {
        protected internal override string GetRequestMethod()
        {
            return "POST";
        }

        protected internal override string GetRequestPath()
        {
            return "/api/apps/game/wallet/get_balance";
        }
    }
}
