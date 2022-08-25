namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/fulfilment/certificate/query 接口的响应。</para>
    /// </summary>
    public class GoodLifeFulfilmentCertificateQueryV1Response : TikTokResponse<GoodLifeFulfilmentCertificateQueryV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                public static class Types
                {
                    public class Certificate : GoodLifeFulfilmentCertificateGetV1Response.Types.Data.Types.Certificate
                    {
                    }
                }

                /// <summary>
                /// 获取或设置团购券列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificates")]
                [System.Text.Json.Serialization.JsonPropertyName("certificates")]
                public Types.Certificate[] CertificateList { get; set; } = default!;
            }
        }
    }
}
