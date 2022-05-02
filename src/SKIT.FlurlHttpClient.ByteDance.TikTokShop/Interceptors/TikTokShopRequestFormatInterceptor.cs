using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Interceptors
{
    internal partial class TikTokShopRequestFormatInterceptor : FlurlHttpCallInterceptor
    {
        public override async Task BeforeCallAsync(FlurlCall flurlCall)
        {
            if (flurlCall == null) throw new ArgumentNullException(nameof(flurlCall));

            try
            {
                if (flurlCall.HttpRequestMessage.Content is MultipartFormDataContent)
                {
                    var oldFormdataContent = (MultipartFormDataContent)flurlCall.HttpRequestMessage.Content;
                    var oldParamHttpContent = oldFormdataContent.SingleOrDefault(e => Constants.FormDataFields.FORMDATA_PARAM_JSON.Equals(e.Headers.ContentDisposition?.Name?.Trim('\"')));
                    if (oldParamHttpContent != null)
                    {
                        string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
                        var newFormdataContent = new MultipartFormDataContent(boundary);

                        string paramJson = await oldParamHttpContent.ReadAsStringAsync();
                        paramJson = Utilities.JsonUtility.Format(paramJson);

                        foreach (var item in oldFormdataContent)
                        {
                            if (item == oldParamHttpContent)
                                continue;

                            if (string.IsNullOrEmpty(item.Headers.ContentDisposition!.FileName))
                                newFormdataContent.Add(item, item.Headers.ContentDisposition.Name!);
                            else
                                newFormdataContent.Add(item, item.Headers.ContentDisposition.Name!, item.Headers.ContentDisposition.FileName!);
                        }

                        var newParamHttpContent = new StringContent(paramJson, Encoding.UTF8, "application/json");
                        newFormdataContent.Add(newParamHttpContent, Constants.FormDataFields.FORMDATA_PARAM_JSON);
                        flurlCall.HttpRequestMessage.Content = newFormdataContent;

                        flurlCall.Request.AfterCall((_) => oldFormdataContent.Dispose());
                    }
                }
                else
                {
                    string paramJson = flurlCall.RequestBody;
                    paramJson = Utilities.JsonUtility.Format(flurlCall.RequestBody);

                    if (!string.IsNullOrEmpty(paramJson))
                    {
                        var oldParamHttpContent = flurlCall.HttpRequestMessage.Content;

                        var newParamHttpContent = new ByteArrayContent(Encoding.UTF8.GetBytes(paramJson));
                        newParamHttpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=UTF-8");
                        flurlCall.HttpRequestMessage.Content = newParamHttpContent;

                        oldParamHttpContent?.Dispose();
                    }
                }
            }
            catch (Exceptions.TikTokShopRequestSignatureException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exceptions.TikTokShopRequestMarshalException("Marshal request failed. Please see the `InnerException` for more details.", ex);
            }
        }
    }
}
