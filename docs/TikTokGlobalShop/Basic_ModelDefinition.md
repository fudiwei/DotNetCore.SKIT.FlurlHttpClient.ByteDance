## API Reference Manual

Naming Policies:

-   Request Models: _`${API}`_ + `Request`
-   Response Models: _`${API}`_ + `Response`
-   API Methods: `Execute` + _`${API}`_ + `Async`

---

### APIs

<details>

<summary>[View Details]</summary>

-   Authentication
    -   Get Access Token: `AuthGetToken`
    -   Refresh Access Token: `AuthRefreshToken`
-   Authorization
    -   Get Authorized Shops: `AuthorizationGetShops`
-   Event
    -   Get Shop Webhooks: `EventGetWebhooks`
    -   Update Shop Webhook: `EventUpdateWebhook`
    -   Delete Shop Webhook: `EventDeleteWebhook`
-   Seller
    -   Get Seller Permissions: `SellerGetPermissions`
    -   Get Active Shops: `SellerGetShops`
-   Products
    -   Get Brands: `ProductGetBrands`
    -   Create Custom Brands: `ProductCreateBrand`
    -   Get Categories: `ProductGetCategories`
    -   Get Category Rules: `ProductGetCategoryRules`
    -   Get Attributes: `ProductGetCategoryAttributes`
    -   Recommend Categories: `ProductRecommendCategories`
    -   Get Global Categories: `ProductGetGlobalCategories`
    -   Get Global Category Rules: `ProductGetGlobalCategoryRules`
    -   Get Global Attributes: `ProductGetGlobalCategoryAttributes`
    -   Recommend Global Categories: `ProductRecommendGlobalCategories`
-   Orders
    -   Get Order List: `OrderSearchOrders`
    -   Get Order Detail: `OrderGetOrderDetail`
-   Supply Chain
    -   Confirm Package Shipment: `SupplyChainSyncPackages`

</details>
