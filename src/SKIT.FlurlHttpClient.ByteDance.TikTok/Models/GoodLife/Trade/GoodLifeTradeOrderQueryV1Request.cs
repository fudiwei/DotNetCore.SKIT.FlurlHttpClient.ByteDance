namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/trade/order/query 接口的请求。</para>
    /// </summary>
    public class GoodLifeTradeOrderQueryV1Request : TikTokRequest
    {
        /// <summary>
        /// 获取或设置商家团购账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分页页码。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 获取或设置抖音订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置第三方订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ExternalOrderId { get; set; }

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置创建订单起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? CreateOrderStartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置创建订单截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long? CreateOrderEndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置修改订单起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long? UpdateOrderStartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置修改订单截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long? UpdateOrderEndTimestamp { get; set; }
    }
}
