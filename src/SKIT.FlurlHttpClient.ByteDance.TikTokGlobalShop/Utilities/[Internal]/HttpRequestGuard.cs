namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Utilities
{
    internal static class HttpRequestGuard
    {
        public static void AgainstEmptyPathVariable(string? varValue, string varName)
        {
            if (string.IsNullOrEmpty(varValue))
                throw new ArgumentException($"Bad request, missing path variable: \"{NormalizePathName(varName)}\".");
        }

        private static string NormalizePathName(string segment)
        {
            if (segment is not null && !segment.StartsWith("{") && !segment.EndsWith("}"))
                segment = "{" + segment + "}";
            return segment ?? "{}";
        }
    }
}
