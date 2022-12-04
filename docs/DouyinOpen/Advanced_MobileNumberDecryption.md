## 如何解密手机号码？

---

> 请先自行阅读：
>
> [《抖音开放平台开发文档 - 用户管理：手机号解密代码示例》](https://open.douyin.com/platform/doc/6943439913106835470)

你可根据官方文档的规则利用本库提供的 `AESUtility` 工具类自行进行数据解密。

此外，本库还封装了直接解密的扩展方法，下面给出一个示例：

```csharp
string rawMobileNumber = client.DecryptMobileNumber("加密过的手机号");
```
