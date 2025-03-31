using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Utilities
{
    using SKIT.FlurlHttpClient;

    internal static class HttpContentBuilder
    {
        public static MultipartFormDataContent BuildWithFile(string fileName, byte[] fileBytes, string? fileContentType, string formDataName, Action<HttpContent>? configureFileHttpContent = null)
        {
            if (fileName is null) throw new ArgumentNullException(nameof(fileName));
            if (formDataName is null) throw new ArgumentNullException(nameof(formDataName));

            fileName = fileName.Replace("\"", "");
            fileBytes = fileBytes ?? Array.Empty<byte>();
            fileContentType = string.IsNullOrEmpty(fileContentType) ? MimeTypes.Binary : fileContentType;
            formDataName = formDataName.Replace("\"", "");

            ByteArrayContent fileContent = new ByteArrayContent(fileBytes);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(fileContentType);
            configureFileHttpContent?.Invoke(fileContent);

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            MultipartFormDataContent httpContent = new MultipartFormDataContent(boundary);
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse($"{MimeTypes.FormData}; boundary={boundary}");
            httpContent.Add(fileContent, $"\"{formDataName}\"", $"\"{HttpUtility.UrlEncode(fileName)}\"");
            return httpContent;
        }
    }
}
