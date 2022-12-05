## 如何快速找到需要调用的 API 模型类名 / 方法名？

---

本库提供的请求模型、响应模型和接口方法，三者均保持同名。

例如，设置商品限购的请求是 `ProductEditBuyerLimitRequest`，响应是 `ProductEditBuyerLimitResponse`，接口是 `ExecuteProductEditBuyerLimitAsync()`。知道其中一个，其余两个就可以快速地推断出了。

再有，每个对象的命名与官方文档的接口地址大体保持一致。例如刚刚提到的获取粉丝列表，它的接口地址是 `[POST] /product/editBuyerLimit`，将其中的反斜杠去掉、并以大驼峰命名法的方式调整它，就可以得到前文提到的几个对象了。

完整的模型定义可以参考项目目录下的 _src/SKIT.FlurlHttpClient.ByteDance.DouyinShop/Models_ 目录。

---

### 抖店开放平台 API 支持情况：

<details>

<summary>[展开查看]</summary>

|     |   抖店 API    | 备注 |
| :-: | :-----------: | :--: |
|  √  |   店铺 API    |      |
|  √  |   商品 API    |      |
|  √  |   库存 API    |      |
|  √  |   订单 API    |      |
|  √  | 物流发货 API  |      |
|  √  | 售后退款 API  |      |
|  √  |   保险 API    |      |
|  √  |   代发 API    |      |
|  √  |   跨境 API    |      |
|  √  |   卡券 API    |      |
|  √  | BIC 质检 API  |      |
|  √  | BTAS 质检 API |      |
|  √  | 仓库作业 API  |      |
|  √  | 精选联盟 API  |      |
|  √  | 回收寄卖 API  |      |
|  √  | 素材中心 API  |      |

</details>
