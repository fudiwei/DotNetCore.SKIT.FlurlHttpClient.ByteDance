## API Reference Manual

Naming Policies:

-   Request Models: _`${API}`_ + `Request`
-   Response Models: _`${API}`_ + `Response`
-   API Methods: `Execute` + _`${API}`_ + `Async`

---

### APIs

<details>

<summary>[View Details]</summary>

-   Authorization
    -   Get Access Token: `AuthGetToken`
    -   Refresh Access Token: `AuthRefreshToken`
-   Shop
    -   Get Authorized Shop: `ShopGetAuthorizedShopList`
-   Seller
    -   Get Active Shop List: `SellerGetGlobalActiveShopList`
    -   Check Global Product Mode: `SellerCheckGlobalProductMode`
-   Product
    -   Upload File: `ProductUploadFile`
    -   Upload Image: `ProductUploadImage`
    -   Create Product: `ProductCreateProduct`
    -   Delete Product: `ProductDeleteProducts`
    -   Edit Product: `ProductUpdateProduct`
    -   Update Stock: `ProductUpdateProductStock`
    -   Get Product List: `ProductSearchProducts`
    -   Get Product Detail: `ProductGetProductDetail`
    -   Get Product Stock: `ProductGetProductStocks`
    -   Deactivate Product: `ProductDeactivateProducts`
    -   Activate Product: `ProductActivateProducts`
    -   Recover Deleted Product: `ProductRecoverProducts`
    -   Update Price: `ProductUpdateProductPrice`
    -   Get Categories: `ProductGetCategoryList`
    -   Get Brands: `ProductGetBrandList`
    -   Create Brand: `ProductCreateBrand`
    -   Get Attributes: `ProductGetAttributeList`
    -   Get Category Rule: `ProductGetCategoryRules`
    -   Category Recommended: `ProductRecommendCategory`
-   Order
    -   Get Order Detail: `OrderGetOrderDetail`
    -   Get Order List: `OrderSearchOrders`
    -   Ship Order: `OrderShipOrder`
-   Fulfillment
    -   Verify Order Split: `FulfillmentVerifyOrderSplit`
    -   Confirm Order Split: `FulfillmentConfirmOrderSplit`
    -   Search Pre Combine Package: `FulfillmentSearchPreCombinePackages`
    -   Get Package Shipping Document: `FulfillmentGetShippingDocument`
    -   Update Package Shipping Info: `FulfillmentUpdateShippingInfo`
    -   Get Package Shipping Info: `FulfillmentGetShippingInfo`
    -   Search Package: `FulfillmentSearchPackages`
    -   Ship Package: `FulfillmentShipPackage`
    -   Get Package Pickup Config: `FulfillmentGetPackagePickupConfigList`
    -   Remove Package Order: `FulfillmentRemovePackageOrders`
    -   Confirm Precombine Package: `FulfillmentConfirmPreCombinePackage`
    -   Get Package Detail: `FulfillmentGetPackageDetail`
    -   Fulfillment Upload Image: `FulfillmentUploadImage`
    -   Update Package Delivery Status: `FulfillmentUpdatePackageDeliveryStatus`
    -   Fulfillment Upload File: `FulfillmentUploadFile`
    -   Batch Ship Packages: `FulfillmentBatchShipPackage`
-   Logistics
    -   Get Subscribed Delivery Options: `LogisticsGetSubscribedDeliveryOptions`
    -   Update Shipping Info: `LogisticsUpdateShippingInfo`
    -   Get Shipping Document: `LogisticsGetShippingDocument`
    -   Get Shipping Provider: `LogisticsGetShippingProviderList`
    -   Get Shipping Info: `LogisticsGetShippingInfo`
    -   Get Warehouse List: `LogisticsGetWarehouseList`
-   Reverse
    -   Reject Reverse Request: `ReverseRejectReverseRequest`
    -   Get Reverse Order List: `ReverseSearchReverseOrders`
    -   Confirm Reverse Request: `ReverseConfirmReverseRequest`
    -   Cancel Order: `ReverseCancelOrder`
    -   Get Reject Reason List: `ReverseGetRejectReasonList`
-   Finance
    -   Get Settlements: `FinanceSearchSettlements`
    -   Get Transactions: `FinanceSearchTransactions`
    -   Get Order Settlements: `FinanceGetOrderSettlementList`
-   Global Product
    -   Create Global Product: `GlobalProductCreateProduct`
    -   Get Global Product List: `GlobalProductSearchProducts`
    -   Get Global Product Detail: `GlobalProductGetProductDetail`
    -   Publish Global Product: `GlobalProductPublishProduct`
    -   Update Global Product Price: `GlobalProductUpdateProductPrice`
    -   Get Global Categories: `GlobalProductGetCategoryList`
    -   Edit Global Product: `GlobalProductUpdateProduct`
    -   Get Global Attributes: `GlobalProductGetAttributeList`
    -   Get Global Category Rule: `GlobalProductGetCategoryRules`
    -   Delete Global Product: `GlobalProductDeleteProducts`
-   Promotion
    -   Update Basic Information: `PromotionUpdateActivity`
    -   Get Promotion List: `PromotionSearchActivities`
    -   Deactivate Promotion: `PromotionDeactivateActivity`
    -   Remove Promotion Item: `PromotionRemoveActivityItems`
    -   Get Promotion Details: `PromotionGetActivityDetail`
    -   Add/Update Discount Item: `PromotionAddOrUpdateActivityItems`
    -   Add Promotion: `PromotionCreateActivity`
-   Supply Chain
    -   Package Fulfillment Data Sync: `SupplyChainSyncPackageFulfillmentData`

</details>
