## API Reference Manual

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
    -   Check Product Listing: `ProductCreateProductListingCheck`
    -   Check Listing Prerequisites: `ProductGetPrerequisites`
    -   Search Global Products: `ProductSearchGlobalProducts`
    -   Search Products: `ProductSearchProducts`
    -   Listing Schemas: `ProductGetListingSchemas`
    -   Product Information Issue Diagnosis: `ProductGetProductDiagnoses`
    -   Get Products SEO Words: `ProductGetProductSEOWords`
    -   Get Recommended Product Title And Description: `ProductGetProductSuggestions`
    -   Optimized Images: `ProductOptimizeImages`
-   Orders
    -   Get Order List: `OrderSearchOrders`
    -   Get Order Detail: `OrderBatchGetOrderDetail`
-   Fulfillment
    -   Search Package: `FulfillmentSearchPackages`
    -   Get Package Detail: `FulfillmentGetPackageDetail`
    -   Get Package Shipping Document: `FulfillmentGetPackageShippingDocuments`
    -   Get Package Handover Time Slots: `FulfillmentGetPackageHandoverTimeSlots`
    -   Get Tracking: `FulfillmentGetOrderTracking`
    -   Update Package Shipping Info: `FulfillmentUpdatePackageShippingInfo`
    -   Update Package Delivery Status: `FulfillmentBatchUpdatePackagesDeliveryStatus`
    -   Get Order Split Attributes: `FulfillmentGetOrderSplitAttributes`
    -   Split Orders: `FulfillmentSplitOrder`
    -   Search Combinable Packages: `FulfillmentSearchCombinablePackages`
    -   Combine Package: `FulfillmentCombinePackage`
    -   Uncombine Packages: `FulfillmentUncombinePackage`
    -   Mark Package As Shipped: `FulfillmentUpdateOrderPackages`
    -   Ship Package: `FulfillmentShipPackage`
    -   Batch Ship Packages: `FulfillmentBatchShipPackages`
    -   Fulfillment Upload Delivery Image: `FulfillmentUploadImage`
    -   Fulfillment Upload Delivery File: `FulfillmentUploadFile`
    -   Get Eligible Shipping Service: `FulfillmentSearchOrderShippingServices`
    -   Create Packages: `FulfillmentCreatePackage`
    -   Update Shipping Info: `FulfillmentUpdateOrderShippingInfo`
-   Return and Refund
    -   Search Cancellations: `ReturnRefundSearchCancellations`
    -   Approve Cancellation: `ReturnRefundApproveCancellation`
    -   Reject Cancellation: `ReturnRefundRejectCancellation`
    -   Search Returns: `ReturnRefundSearchReturns`
    -   Approve Return: `ReturnRefundApproveReturn`
    -   Reject Return: `ReturnRefundRejectReturn`
    -   Get Aftersale Eligibility: `ReturnRefundGetOrderAftersaleEligibility`
    -   Get Reject Reasons: `ReturnRefundGetRejectReasons`
    -   Calculate Refund: `ReturnRefundCalculateRefund`
    -   Get Return Records: `ReturnRefundGetReturnRecords`
    -   Cancel Order: `ReturnRefundCreateCancellation`
    -   Create Return: `ReturnRefundCreateReturn`
-   Logistics
    -   Get Warehouse Delivery Options: `LogisticsGetWarehouseDeliveryOptions`
    -   Get Warehouse List: `LogisticsGetWarehouses`
    -   Get Shipping Providers: `LogisticsGetDeliveryOptionShippingProviders`
    -   Get Global Seller Warehouse: `LogisticsGetGlobalWarehouses`
-   Promotion
    -   Create Activity: `PromotionCreateActivity`
    -   Update Activity Product: `PromotionUpdateActivityProducts`
    -   Remove Activity Product: `PromotionDeleteActivityProducts`
    -   Search Activities: `PromotionSearchActivities`
    -   Get Activity: `PromotionGetActivityDetail`
    -   Update Activity: `PromotionUpdateActivity`
    -   Deactivate Activity: `PromotionDeactivateActivity`
-   Finance
    -   Get Order Statement Transactions: `FinanceGetOrderStatementTransactions`
    -   Get Statement Transactions: `FinanceGetStatementTransactions`
    -   Get Withdrawals: `FinanceGetWithdrawals`
    -   Get Statements: `FinanceGetStatements`
    -   Get Payments: `FinanceGetPayments`
-   Customer Service
    -   Get Conversation Messages: `CustomerServiceGetConversationMessages`
    -   Get Conversations: `CustomerServiceGetConversations`
    -   Send Message: `CustomerServiceCreateConversationMessage`
    -   Get Agent Settings: `CustomerServiceGetAgentSettings`
    -   Update Agent Settings: `CustomerServiceUpdateAgentSettings`
    -   Upload Buyer Messages Image: `CustomerServiceUploadImage`
    -   Read Message: `CustomerServiceReadConversationMessage`
    -   Create Conversation: `CustomerServiceCreateConversation`
-   Supply Chain
    -   Confirm Package Shipment: `SupplyChainSyncPackages`

</details>
