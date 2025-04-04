﻿## API Reference Manual

Naming Policies:

-   Request Models: _`${API}`_ + `Request`
-   Response Models: _`${API}`_ + `Response`
-   API Methods: `Execute` + _`${API}`_ + `Async`

---

### APIs

Notes: The following catalog is consistent with the catalog structure of [TikTokShop Partner Center API Reference](https://partner.tiktokshop.com/docv2/page/6632a7434585a502e1cb5591).

<details>

<summary>[View Details]</summary>

-   Authentication
    -   Get Access Token: `AuthGetToken`
    -   Refresh Access Token: `AuthRefreshToken`
-   Authorization
    -   Get Authorized Category Assets: `AuthorizationGetCategoryAssets`
    -   Get Authorized Shops: `AuthorizationGetShops`
-   Event
    -   Get Shop Webhooks: `EventGetWebhooks`
    -   Update Shop Webhook: `EventUpdateWebhook`
    -   Delete Shop Webhook: `EventDeleteWebhook`
-   Seller
    -   Get Seller Permissions: `SellerGetPermissions`
    -   Get Active Shops: `SellerGetShops`
-   Products
    -   Check Listing Prerequisites: `ProductGetPrerequisites`
    -   Get Categories: `ProductGetCategories`
    -   Recommend Categories: `ProductRecommendCategories`
    -   Get Category Rules: `ProductGetCategoryRules`
    -   Get Attributes: `ProductGetCategoryAttributes`
    -   Get Brands: `ProductGetBrands`
    -   Create Custom Brands: `ProductCreateBrand`
    -   Check Product Listing: `ProductCreateProductListingCheck`
    -   Upload Product Image: `ProductUploadImage`
    -   Upload Product File: `ProductUploadFile`
    -   Search Size Charts: `ProductSearchSizeCharts`
    -   Create Product: `ProductCreateProduct`
    -   Partial Edit Product: `ProductUpdateProductPartially`
    -   Edit Product: `ProductUpdateProduct`
    -   Activate Products: `ProductActivateProducts`
    -   Deactivate Products: `ProductDeactivateProducts`
    -   Delete Products: `ProductDeleteProducts`
    -   Recover Products: `ProductRecoverProducts`
    -   Get Product: `ProductGetProductDetail`
    -   Search Products: `ProductSearchProducts`
    -   Update Price: `ProductUpdateProductPrice`
    -   Update Inventory: `ProductUpdateProductInventory`
    -   Inventory Search: `ProductGetInventories`
    -   Product Information Issue Diagnosis: `ProductGetProductDiagnoses`
    -   Get Products SEO Words: `ProductGetProductSEOWords`
    -   Get Recommended Product Title And Description: `ProductGetProductSuggestions`
    -   Optimized Images: `ProductOptimizeImages`
    -   Get Global Categories: `ProductGetGlobalCategories`
    -   Recommend Global Categories: `ProductRecommendGlobalCategories`
    -   Get Global Category Rules: `ProductGetGlobalCategoryRules`
    -   Get Global Attributes: `ProductGetGlobalCategoryAttributes`
    -   Create Global Product: `ProductCreateGlobalProduct`
    -   Publish Global Product: `ProductPublishGlobalProduct`
    -   Edit Global Product: `ProductUpdateGlobalProduct`
    -   Delete Global Products: `ProductDeleteGlobalProducts`
    -   Get Global Product: `ProductGetGlobalProductDetail`
    -   Search Global Products: `ProductSearchGlobalProducts`
    -   Update Global Inventory: `ProductUpdateGlobalProductInventory`
    -   Create Manufacturer: `ProductCreateComplianceManufacturer`
    -   Partial Edit Manufacturer: `ProductUpdateComplianceManufacturerPartially`
    -   Search Manufacturers: `ProductSearchComplianceManufacturers`
    -   Create Responsible Person: `ProductCreateComplianceResponsiblePerson`
    -   Partial Edit Responsible Person: `ProductUpdateComplianceResponsiblePersonPartially`
    -   Search Responsible Persons: `ProductSearchComplianceResponsiblePersons`
    -   Create Category Upgrade Task: `ProductCreateProductCategoryUpgradeTask`
    -   Listing Schemas: `ProductGetListingSchemas`
-   Promotion
    -   Create Activity: `PromotionCreateActivity`
    -   Update Activity: `PromotionUpdateActivity`
    -   Deactivate Activity: `PromotionDeactivateActivity`
    -   Get Activity: `PromotionGetActivityDetail`
    -   Search Activities: `PromotionSearchActivities`
    -   Update Activity Product: `PromotionUpdateActivityProducts`
    -   Remove Activity Product: `PromotionDeleteActivityProducts`
    -   Get Coupon: `PromotionGetCouponDetail`
    -   Search Coupons: `PromotionSearchCoupons`
-   Orders
    -   Get Order List: `OrderSearchOrders`
    -   Get Order Detail: `OrderBatchGetOrderDetail`
    -   Get Price Detail: `OrderGetOrderPriceDetail`
    -   Add External Order References: `OrderCreateExternalOrder`
    -   Get External Order References: `OrderGetExternalOrders`
    -   Search Order By External Order Reference: `OrderSearchExternalOrders`
-   Fulfillment
    -   Get Order Split Attributes: `FulfillmentGetOrderSplitAttributes`
    -   Split Orders: `FulfillmentSplitOrder`
    -   Get Eligible Shipping Service: `FulfillmentSearchOrderShippingServices`
    -   Create First Mile Bundle: `FulfillmentCreateBundle`
    -   Create Packages: `FulfillmentCreatePackage`
    -   Search Package: `FulfillmentSearchPackages`
    -   Search Combinable Packages: `FulfillmentSearchCombinablePackages`
    -   Combine Package: `FulfillmentCombinePackage`
    -   Uncombine Packages: `FulfillmentUncombinePackage`
    -   Get Package Handover Time Slots: `FulfillmentGetPackageHandoverTimeSlots`
    -   Ship Package: `FulfillmentShipPackage`
    -   Batch Ship Packages: `FulfillmentBatchShipPackages`
    -   Mark Package As Shipped: `FulfillmentUpdateOrderPackages`
    -   Get Package Shipping Document: `FulfillmentGetPackageShippingDocuments`
    -   Get Package Detail: `FulfillmentGetPackageDetail`
    -   Get Tracking: `FulfillmentGetOrderTracking`
    -   Update Shipping Info: `FulfillmentUpdateOrderShippingInfo`
    -   Update Package Shipping Info: `FulfillmentUpdatePackageShippingInfo`
    -   Fulfillment Upload Delivery File: `FulfillmentUploadFile`
    -   Fulfillment Upload Delivery Image: `FulfillmentUploadImage`
    -   Update Package Delivery Status: `FulfillmentBatchUpdatePackagesDeliveryStatus`
-   Fulfillment By TikTok (FBT)
    -   Get FBT Merchant Onboarded Regions: `FBTGetMerchantOnboardedRegions`
    -   Get FBT Warehouse List: `FBTGetWarehouses`
    -   Get Inbound Order: `FBTGetInboundOrders`
    -   Search FBT Inventory: `FBTGetInventories`
    -   Search FBT Inventory Record: `FBTGetInventoryRecords`
    -   Search Goods Info: `FBTGetGoods`
-   Logistics
    -   Get Warehouse List: `LogisticsGetWarehouses`
    -   Get Global Seller Warehouse: `LogisticsGetGlobalWarehouses`
    -   Get Warehouse Delivery Options: `LogisticsGetWarehouseDeliveryOptions`
    -   Get Shipping Providers: `LogisticsGetDeliveryOptionShippingProviders`
-   Return and Refund
    -   Get Aftersale Eligibility: `ReturnRefundGetOrderAftersaleEligibility`
    -   Get Reject Reasons: `ReturnRefundGetRejectReasons`
    -   Create Return: `ReturnRefundCreateReturn`
    -   Approve Return: `ReturnRefundApproveReturn`
    -   Reject Return: `ReturnRefundRejectReturn`
    -   Search Returns: `ReturnRefundSearchReturns`
    -   Get Return Records: `ReturnRefundGetReturnRecords`
    -   Cancel Order: `ReturnRefundCreateCancellation`
    -   Approve Cancellation: `ReturnRefundApproveCancellation`
    -   Reject Cancellation: `ReturnRefundRejectCancellation`
    -   Search Cancellations: `ReturnRefundSearchCancellations`
    -   Calculate Refund: `ReturnRefundCalculateRefund`
-   Finance
    -   Get Statements: `FinanceGetStatements`
    -   Get Statement Transactions: `FinanceGetStatementTransactions`
    -   Get Order Statement Transactions: `FinanceGetOrderStatementTransactions`
    -   Get Payments: `FinanceGetPayments`
    -   Get Withdrawals: `FinanceGetWithdrawals`
-   Customer Service
    -   Create Conversation: `CustomerServiceCreateConversation`
    -   Get Conversations: `CustomerServiceGetConversations`
    -   Get Conversation Messages: `CustomerServiceGetConversationMessages`
    -   Upload Buyer Messages Image: `CustomerServiceUploadImage`
    -   Send Message: `CustomerServiceCreateConversationMessage`
    -   Read Message: `CustomerServiceReadConversationMessage`
    -   Get Agent Settings: `CustomerServiceGetAgentSettings`
    -   Update Agent Settings: `CustomerServiceUpdateAgentSettings`
    -   Get Customer Service Performance: `CustomerServiceGetPerformance`
-   Supply Chain
    -   Confirm Package Shipment: `SupplyChainSyncPackages`

</details>
