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
    -   Upload Product Image: `ProductUploadImage`
    -   Upload Product File: `ProductUploadFile`
    -   Create Product: `ProductCreateProduct`
    -   Partial Edit Product: `ProductUpdateProductPartial`
    -   Edit Product: `ProductUpdateProduct`
    -   Update Inventory: `ProductUpdateProductInventory`
    -   Update Price: `ProductUpdateProductPrice`
    -   Activate Products: `ProductActivateProducts`
    -   Deactivate Products: `ProductDeactivateProducts`
    -   Delete Products: `ProductDeleteProducts`
    -   Recover Products: `ProductRecoverProducts`
    -   Get Product: `ProductGetProductDetail`
    -   Inventory Search: `ProductGetInventories`
    -   Get Global Categories: `ProductGetGlobalCategories`
    -   Get Global Category Rules: `ProductGetGlobalCategoryRules`
    -   Get Global Attributes: `ProductGetGlobalCategoryAttributes`
    -   Recommend Global Categories: `ProductRecommendGlobalCategories`
    -   Create Global Product: `ProductCreateGlobalProduct`
    -   Publish Global Product: `ProductPublishGlobalProduct`
    -   Update Global Inventory: `ProductUpdateGlobalProductInventory`
    -   Get Global Product: `ProductGetGlobalProductDetail`
    -   Edit Global Product: `ProductUpdateGlobalProduct`
    -   Delete Global Products: `ProductDeleteGlobalProducts`
    -   Check Listing Prerequisites: `ProductGetPrerequisites`
    -   Search Global Products: `ProductSearchGlobalProducts`
    -   Search Products: `ProductSearchProducts`
    -   Listing Schemas: `ProductGetListingSchemas`
-   Orders
    -   Get Order List: `OrderSearchOrders`
    -   Get Order Detail: `OrderBatchGetOrderDetail`
-   Supply Chain
    -   Confirm Package Shipment: `SupplyChainSyncPackages`

</details>
