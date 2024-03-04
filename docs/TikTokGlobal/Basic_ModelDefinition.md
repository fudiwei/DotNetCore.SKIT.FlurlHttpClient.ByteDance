## API Reference Manual

Naming Policies:

-   Request Models: _`${API}`_ + `Request`
-   Response Models: _`${API}`_ + `Response`
-   API Methods: `Execute` + _`${API}`_ + `Async`

---

### API Functions

<details>

<summary>[View Details]</summary>

-   Manage User Access Tokens
    -   Fetch an Access Token Using an Authorization Aode: `OAuthAccessToken`
    -   Refresh an Access Token Using a Refresh Token: `OAuthRefreshToken`
    -   Revoke Access: `OAuthRevokeToken`
-   QR Code Authorization
    -   Get QR Code: `OAuthGetQrcode`
    -   Check QR Code Status: `OAuthCheckQrcode`
-   Content Posting
    -   Video - Direct Post
        -   Initialize the Posting Pequest: `PostPublishVideoInit`
        -   Send Video to TikTok Servers: `PostUploadVideo`
    -   Video - Upload
        -   Initialize Video Upload: `PostPublishInboxVideoInit`
        -   Send Video to TikTok Servers: `PostUploadVideo`
    -   Photo - Direct Post
        -   Initialize the Posting Pequest: `PostPublishContentInit`
    -   Query Creator Info: `PostPublishCreatorInfoQuery`
    -   Get Post Status: `PostPublishStatusFetch`
-   Data Portability
    -   Add Data Request: `UserDataAdd`
    -   Cancel Data Request: `UserDataCancel`
    -   Check Status of Data Request: `UserDataCheck`
    -   Download: `UserDataDownload`
-   Display
    -   Get User Info: `UserInfo`
    -   Query Videos: `VideoQuery`
    -   List Videos: `VideoList`
-   Research
    -   Query Videos: `ResearchVideoQuery`
    -   Query User Info: `ResearchUserInfo`
    -   Query Video Comments: `ResearchVideoCommentList`
    -   Query User Liked Videos: `ResearchUserLikedVideos`
    -   Query User Pinned Videos: `ResearchUserPinnedVideos`
    -   Query User Followers: `ResearchUserFollowers`
    -   Query User Following: `ResearchUserFollowing`
    -   Query User Reposted Videos: `ResearchUserRepostedVideos`
-   Commercial Content
    -   Query Ads: `ResearchAdlibAdQuery`
    -   Query Advertisers: `ResearchAdlibAdvertiserQuery`
    -   Get Ad Details: `ResearchAdlibAdDetail`
    -   Get Ad Report: `ResearchAdlibAdReport`
    -   Query Commercial Content: `ResearchAdlibCommercialContentQuery`

</details>
