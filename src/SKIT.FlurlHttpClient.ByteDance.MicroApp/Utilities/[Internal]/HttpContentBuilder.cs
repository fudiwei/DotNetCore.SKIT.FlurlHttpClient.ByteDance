namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Utilities
{
    using SKIT.FlurlHttpClient;

    internal static class HttpContentBuilder
    {
        public static MultipartFormDataContent BuildWithFile(string? fileName, byte[]? fileBytes, string? fileContentType, string formDataName, Action<HttpContent>? configureFileHttpContent = null)
        {
            if (formDataName is null) throw new ArgumentNullException(nameof(formDataName));

            fileName = fileName?.Replace("\"", string.Empty);
            fileBytes = fileBytes ?? Array.Empty<byte>();
            fileContentType = string.IsNullOrEmpty(fileContentType) ? MimeTypes.Binary : fileContentType;
            formDataName = formDataName.Replace("\"", string.Empty);
            
            ByteArrayContent fileContent = new ByteArrayContent(fileBytes);
            fileContent.Headers.ContentDisposition = ContentDispositionHeaderValue.Parse(fileName is null ? $"form-data; name=\"{formDataName}\"" : $"form-data; name=\"{formDataName}\"; filename=\"{HttpUtility.UrlEncode(fileName)}\"");
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(fileContentType);
            fileContent.Headers.ContentLength = fileBytes.Length;
            configureFileHttpContent?.Invoke(fileContent);

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            MultipartFormDataContent httpContent = new MultipartFormDataContent(boundary);
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse($"{MimeTypes.FormData}; boundary={boundary}");
            httpContent.Add(fileContent);
            return httpContent;
        }
    }
}
