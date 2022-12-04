using System.Collections;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /poi/ext/hotel/sku 接口的响应。</para>
    /// </summary>
    public class POIExternalHotelSKUResponse : DouyinOpenResponse<POIExternalHotelSKUResponse.Types.Data>
    {
        public static class Types
        {
            public class SKU
            {
                /// <summary>
                /// 获取或设置 SPU 外部 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_ext_id")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_ext_id")]
                public string SPUExternalId { get; set; } = default!;

                /// <summary>
                /// 获取或设置拉取价格时间区间开始时间字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_date")]
                [System.Text.Json.Serialization.JsonPropertyName("start_date")]
                public string StartDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置拉取价格时间区间结束时间字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_date")]
                [System.Text.Json.Serialization.JsonPropertyName("end_date")]
                public string EndDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置房型价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public int Price { get; set; }

                /// <summary>
                /// 获取或设置库存数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock")]
                [System.Text.Json.Serialization.JsonPropertyName("stock")]
                public int Stock { get; set; }
            }

            public class Data : DouyinOpenResposneData, IList<SKU>
            {
                private readonly IList<SKU> _list = new List<SKU>();

                public SKU this[int index]
                {
                    get => _list[index];
                    set => _list[index] = value;
                }

                public int Count
                {
                    get { return _list.Count; }
                }

                public bool IsReadOnly
                {
                    get { return _list.IsReadOnly; }
                }

                public void Add(SKU item)
                {
                    _list.Add(item);
                }

                public void Clear()
                {
                    _list.Clear();
                }

                public bool Contains(SKU item)
                {
                    return _list.Contains(item);
                }

                public void CopyTo(SKU[] array, int arrayIndex)
                {
                    _list.CopyTo(array, arrayIndex);
                }

                public IEnumerator<SKU> GetEnumerator()
                {
                    return _list.GetEnumerator();
                }

                public int IndexOf(SKU item)
                {
                    return _list.IndexOf(item);
                }

                public void Insert(int index, SKU item)
                {
                    _list.Insert(index, item);
                }

                public bool Remove(SKU item)
                {
                    return _list.Remove(item);
                }

                public void RemoveAt(int index)
                {
                    _list.RemoveAt(index);
                }

                IEnumerator IEnumerable.GetEnumerator()
                {
                    return ((IEnumerable)_list).GetEnumerator();
                }
            }
        }
    }
}
