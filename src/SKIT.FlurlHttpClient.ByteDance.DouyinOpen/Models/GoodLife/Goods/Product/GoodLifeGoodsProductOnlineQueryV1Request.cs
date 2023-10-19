namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/goods/product/online/query 接口的请求。</para>
    /// </summary>
    public class GoodLifeGoodsProductOnlineQueryV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置商家 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? AccountId { get; set; }

        /// <summary>
        /// 获取或设置上线状态。过滤在线状态 1-在线 2-下线 3-封禁
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? PageCursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。分页数量，不传默认为5，最大上限50
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? PageSize { get; set; }
    }
}
