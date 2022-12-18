using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Interceptors
{
    internal partial class DouyinShopRequestFormatInterceptor : FlurlHttpCallInterceptor
    {
        public override async Task BeforeCallAsync(FlurlCall flurlCall)
        {
            if (flurlCall == null) throw new ArgumentNullException(nameof(flurlCall));

            try
            {
                if (flurlCall.HttpRequestMessage.Content is MultipartFormDataContent)
                {
                    MultipartFormDataContent oldFormdataContent = (MultipartFormDataContent)flurlCall.HttpRequestMessage.Content;
                    HttpContent? oldParamHttpContent = oldFormdataContent.SingleOrDefault(e => Constants.FormDataFields.FORMDATA_PARAM_JSON.Equals(e.Headers.ContentDisposition?.Name?.Trim('\"')));
                    if (oldParamHttpContent != null)
                    {
                        string paramJson = Utilities.JsonUtility.Format(await oldParamHttpContent.ReadAsStringAsync());

                        MultipartFormDataContent newFormdataContent = new MultipartFormDataContent("--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x"));
                        foreach (HttpContent formdataItem in oldFormdataContent)
                        {
                            if (formdataItem == oldParamHttpContent)
                                continue;

                            if (string.IsNullOrEmpty(formdataItem.Headers.ContentDisposition!.FileName))
                                newFormdataContent.Add(formdataItem, formdataItem.Headers.ContentDisposition.Name!);
                            else
                                newFormdataContent.Add(formdataItem, formdataItem.Headers.ContentDisposition.Name!, formdataItem.Headers.ContentDisposition.FileName!);
                        }

                        HttpContent newParamHttpContent = new StringContent(paramJson, Encoding.UTF8, "application/json");
                        newFormdataContent.Add(newParamHttpContent, Constants.FormDataFields.FORMDATA_PARAM_JSON);
                        flurlCall.HttpRequestMessage.Content = newFormdataContent;

                        flurlCall.Request.AfterCall((_) => oldFormdataContent.Dispose());
                    }
                }
                else
                {
                    string paramJson = Utilities.JsonUtility.Format(flurlCall.RequestBody);

                    if (!string.IsNullOrEmpty(paramJson))
                    {
                        HttpContent oldParamHttpContent = flurlCall.HttpRequestMessage.Content;

                        HttpContent newParamHttpContent = new ByteArrayContent(Encoding.UTF8.GetBytes(paramJson));
                        newParamHttpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=UTF-8");
                        flurlCall.HttpRequestMessage.Content = newParamHttpContent;

                        oldParamHttpContent?.Dispose();
                    }
                }
            }
            catch (Exceptions.DouyinShopRequestSignatureException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exceptions.DouyinShopRequestMarshalException("Marshal request failed. Please see the `InnerException` for more details.", ex);
            }
        }
    }
}
