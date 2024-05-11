using System.IO;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Utilities
{
    internal static class FileNameToContentTypeMapper
    {
        public static string? GetContentTypeForImage(string fileName)
        {
            string extension = Path.GetExtension(fileName ?? "/")?.ToLower() ?? string.Empty;
            switch (extension)
            {
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".png":
                    return "image/png";
            }

            return null;
        }

        public static string? GetContentTypeForFile(string fileName)
        {
            string extension = Path.GetExtension(fileName ?? "/")?.ToLower() ?? string.Empty;
            switch (extension)
            {
                case ".jpg":
                case ".jpeg":
                case ".png":
                    return GetContentTypeForImage(fileName!);
                case ".pdf":
                    return "application/pdf";
                case ".mp4":
                case ".mpeg":
                case ".m4v":
                    return "video/mp4";
            }

            return null;
        }
    }
}
