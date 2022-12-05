namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/poi/poi/decorate 接口的响应。</para>
    /// </summary>
    public class GoodLifePOIDecorateV1Response : DouyinOpenResponse<GoodLifePOIDecorateV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class Task : GoodLifePOIUpdateV1Response.Types.Data.Types.Task
                    {
                    }
                }

                /// <summary>
                /// 获取或设置任务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tasks")]
                [System.Text.Json.Serialization.JsonPropertyName("tasks")]
                public Types.Task[] TaskList { get; set; } = default!;
            }
        }
    }
}
