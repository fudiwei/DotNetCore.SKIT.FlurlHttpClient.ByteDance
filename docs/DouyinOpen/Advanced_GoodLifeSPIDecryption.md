## 如何解密抖音生活服务 SPI 接口中的加密字段？

---

> 请先自行阅读：
>
> [《抖音开放平台开发文档 - 生活服务开放能力 - 接入前准备：加密字段解密方法》](https://partner.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/beforeinsert/decrypt)

你可根据官方文档的规则利用本库提供的 `AESUtility` 工具类自行进行数据解密。

此外，本库还封装了直接解密的扩展方法，下面给出一个示例：

```csharp
string rawData = client.DecryptSPICipherField("密文");
```
