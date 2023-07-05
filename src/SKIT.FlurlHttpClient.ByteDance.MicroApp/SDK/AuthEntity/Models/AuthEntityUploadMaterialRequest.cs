using System.IO;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityUploadMaterialRequest: ByteDanceMicroAppAuthEntityRequest
    {
        // public static class Types
        // {
        //     public class MyClass
        //     {
        //
        //     }
        // }


        public int MaterialType { get; set; }


        public string? FileName { get; set; }
        public byte[] FileBytes { get; set; }
        public string? FileContentType { get; set; }
        // public  Stream MaterialFile { get; set; }

    }
}
