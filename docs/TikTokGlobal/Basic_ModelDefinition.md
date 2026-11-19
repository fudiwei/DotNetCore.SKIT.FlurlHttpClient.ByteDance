## API Reference Manual

Naming Policies:

- Request Models: _`${API}`_ + `Request`
- Response Models: _`${API}`_ + `Response`
- API Methods: `Execute` + _`${API}`_ + `Async`

---

### APIs

<details>

<summary>[View Details]</summary>

- Manage OAuth Access Tokens
    - Get a User Access Token: `OAuthAccessToken`
    - Refresh a User Access Token: `OAuthRefreshToken`
    - Revoke a User Access Token: `OAuthRevokeToken`
- TikTok Minis
    - OAuth for TikTok Minis
        - Fetch an Access Token Using an Authorization code: `OAuthAccessToken`
        - Refresh an Access Token Using a Refresh Token: `OAuthRefreshToken`
        - Revoke Access: `OAuthRevokeToken`
    - TikTok User Data
        - Get User Info: `UserInfo`
    - Payment
        - Get Recharge Tiers: `MinisUtilityGetTierInfos`
        - Create an Order: `MinisTradeOrderCreate`
        - Query an Order: `MinisTradeOrderQuery`
        - Check Redeem Amounts: `MinisUtilityCheckRedeemAmounts`
    - Subscription
        - Create a Subscription: `MinisSubscriptionCreate`
        - Reactivate Subscription: `MinisSubscriptionReactivate`
        - Get Active Subscription List: `MinisSubscriptionGetActiveList`
        - Get Subscription Info: `MinisSubscriptionGetSubscriptionInfo`
        - Get Trade Order Info: `MinisSubscriptionGetTradeOrderInfo`
        - Get Subscription Tier Info: `MinisSubscriptionGetSubscriptionTierInfo`
- Login & Identity
    - Login Kit
        - Manage OAuth Access Tokens
            - Get a User Access Token: `OAuthAccessToken`
            - Refresh a User Access Token: `OAuthRefreshToken`
            - Revoke a User Access Token: `OAuthRevokeToken`
        - QR Code Authorization
            - Get QR Code: `OAuthGetQrcode`
            - Check QR Code Status: `OAuthCheckQrcode`
    - Data Portability
        - Add Data Request: `UserDataAdd`
        - Cancel Data Request: `UserDataCancel`
        - Check Status of Data Request: `UserDataCheck`
        - Download: `UserDataDownload`
- Share to TikTok
    - Content Posting
        - Video - Direct Post
            - Initialize the Posting Pequest: `PostPublishVideoInit`
            - Send Video to TikTok Servers: `PostUploadVideo`
        - Video - Upload
            - Initialize Video Upload: `PostPublishInboxVideoInit`
            - Send Video to TikTok Servers: `PostUploadVideo`
        - Photo - Direct Post
            - Initialize the Posting Pequest: `PostPublishContentInit`
        - Query Creator Info: `PostPublishCreatorInfoQuery`
        - Get Post Status: `PostPublishStatusFetch`
- Content Display
    - Get User Info: `UserInfo`
    - Query Videos: `VideoQuery`
    - List Videos: `VideoList`
- Research & Insights
    - Research Tools
        - Query Videos: `ResearchVideoQuery`
        - Query User Info: `ResearchUserInfo`
        - Query Video Comments: `ResearchVideoCommentList`
        - Query User Liked Videos: `ResearchUserLikedVideos`
        - Query User Pinned Videos: `ResearchUserPinnedVideos`
        - Query User Followers: `ResearchUserFollowers`
        - Query User Following: `ResearchUserFollowing`
        - Query User Reposted Videos: `ResearchUserRepostedVideos`
        - Query Playlists: `ResearchPlaylistInfo`
        - Query TikTok Shop Info: `ResearchPlaylistInfo`
        - Query TikTok Shop Products: `ResearchTTSProduct`
        - Query TikTok Shop Reviews: `ResearchTTSReview`
    - Commercial Content
        - Query Ads: `ResearchAdlibAdQuery`
        - Query Advertisers: `ResearchAdlibAdvertiserQuery`
        - Get Ad Details: `ResearchAdlibAdDetail`
        - Get Ad Report: `ResearchAdlibAdReport`
        - Query Commercial Content: `ResearchAdlibCommercialContentQuery`

</details>
