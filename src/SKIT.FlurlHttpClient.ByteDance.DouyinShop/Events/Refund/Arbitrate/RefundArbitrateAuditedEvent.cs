namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Events
{
    /// <summary>
    /// <para>表示 doudian_refund_ArbitrateAudited 消息的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://op.jinritemai.com/docs/message-docs/31/259 ]]>
    /// </para>
    /// </summary>
    public class RefundArbitrateAuditedEvent : DouyinShopEvent<RefundArbitrateAuditedEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : RefundArbitrateAppliedEvent.Types.Data
            {
                /// <summary>
                /// 获取或设置仲裁结果编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("arbitrate_conclusion")]
                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_conclusion")]
                public int ArbitrateConclusionCode { get; set; }
            }
        }
    }
}
