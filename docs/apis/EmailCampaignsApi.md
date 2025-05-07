# BrevoDotNet.Api.EmailCampaignsApi

All URIs are relative to *https://api.sendinblue.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateEmailCampaign**](EmailCampaignsApi.md#createemailcampaign) | **POST** /emailCampaigns | Create an email campaign |
| [**DeleteEmailCampaign**](EmailCampaignsApi.md#deleteemailcampaign) | **DELETE** /emailCampaigns/{campaignId} | Delete an email campaign |
| [**EmailExportRecipients**](EmailCampaignsApi.md#emailexportrecipients) | **POST** /emailCampaigns/{campaignId}/exportRecipients | Export the recipients of an email campaign |
| [**GetAbTestCampaignResult**](EmailCampaignsApi.md#getabtestcampaignresult) | **GET** /emailCampaigns/{campaignId}/abTestCampaignResult | Get an A/B test email campaign results |
| [**GetEmailCampaign**](EmailCampaignsApi.md#getemailcampaign) | **GET** /emailCampaigns/{campaignId} | Get an email campaign report |
| [**GetEmailCampaigns**](EmailCampaignsApi.md#getemailcampaigns) | **GET** /emailCampaigns | Return all your created email campaigns |
| [**GetSharedTemplateUrl**](EmailCampaignsApi.md#getsharedtemplateurl) | **GET** /emailCampaigns/{campaignId}/sharedUrl | Get a shared template url |
| [**SendEmailCampaignNow**](EmailCampaignsApi.md#sendemailcampaignnow) | **POST** /emailCampaigns/{campaignId}/sendNow | Send an email campaign immediately, based on campaignId |
| [**SendReport**](EmailCampaignsApi.md#sendreport) | **POST** /emailCampaigns/{campaignId}/sendReport | Send the report of a campaign |
| [**SendTestEmail**](EmailCampaignsApi.md#sendtestemail) | **POST** /emailCampaigns/{campaignId}/sendTest | Send an email campaign to your test list |
| [**UpdateCampaignStatus**](EmailCampaignsApi.md#updatecampaignstatus) | **PUT** /emailCampaigns/{campaignId}/status | Update an email campaign status |
| [**UpdateEmailCampaign**](EmailCampaignsApi.md#updateemailcampaign) | **PUT** /emailCampaigns/{campaignId} | Update an email campaign |
| [**UploadImageToGallery**](EmailCampaignsApi.md#uploadimagetogallery) | **POST** /emailCampaigns/images | Upload an image to your account&#39;s image gallery |

<a id="createemailcampaign"></a>
# **CreateEmailCampaign**
> CreateModel CreateEmailCampaign (CreateEmailCampaign emailCampaigns)

Create an email campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class CreateEmailCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new EmailCampaignsApi(config);
            var emailCampaigns = new CreateEmailCampaign(); // CreateEmailCampaign | Values to create a campaign

            try
            {
                // Create an email campaign
                CreateModel result = apiInstance.CreateEmailCampaign(emailCampaigns);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.CreateEmailCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEmailCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an email campaign
    ApiResponse<CreateModel> response = apiInstance.CreateEmailCampaignWithHttpInfo(emailCampaigns);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.CreateEmailCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailCampaigns** | [**CreateEmailCampaign**](CreateEmailCampaign.md) | Values to create a campaign |  |

### Return type

[**CreateModel**](CreateModel.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Email campaign created |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteemailcampaign"></a>
# **DeleteEmailCampaign**
> void DeleteEmailCampaign (long campaignId)

Delete an email campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class DeleteEmailCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new EmailCampaignsApi(config);
            var campaignId = 789L;  // long | id of the campaign

            try
            {
                // Delete an email campaign
                apiInstance.DeleteEmailCampaign(campaignId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.DeleteEmailCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEmailCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an email campaign
    apiInstance.DeleteEmailCampaignWithHttpInfo(campaignId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.DeleteEmailCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | id of the campaign |  |

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Email campaign has been deleted |  -  |
| **404** | Campaign ID not found |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="emailexportrecipients"></a>
# **EmailExportRecipients**
> CreatedProcessId EmailExportRecipients (long campaignId, EmailExportRecipients recipientExport = null)

Export the recipients of an email campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class EmailExportRecipientsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new EmailCampaignsApi(config);
            var campaignId = 789L;  // long | Id of the campaign
            var recipientExport = new EmailExportRecipients(); // EmailExportRecipients | Values to send for a recipient export request (optional) 

            try
            {
                // Export the recipients of an email campaign
                CreatedProcessId result = apiInstance.EmailExportRecipients(campaignId, recipientExport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.EmailExportRecipients: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmailExportRecipientsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export the recipients of an email campaign
    ApiResponse<CreatedProcessId> response = apiInstance.EmailExportRecipientsWithHttpInfo(campaignId, recipientExport);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.EmailExportRecipientsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | Id of the campaign |  |
| **recipientExport** | [**EmailExportRecipients**](EmailExportRecipients.md) | Values to send for a recipient export request | [optional]  |

### Return type

[**CreatedProcessId**](CreatedProcessId.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Recipient export request has been accepted |  -  |
| **400** | bad request |  -  |
| **404** | Campaign ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getabtestcampaignresult"></a>
# **GetAbTestCampaignResult**
> AbTestCampaignResult GetAbTestCampaignResult (long campaignId)

Get an A/B test email campaign results

Obtain winning version of an A/B test email campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetAbTestCampaignResultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new EmailCampaignsApi(config);
            var campaignId = 789L;  // long | Id of the A/B test campaign

            try
            {
                // Get an A/B test email campaign results
                AbTestCampaignResult result = apiInstance.GetAbTestCampaignResult(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.GetAbTestCampaignResult: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAbTestCampaignResultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an A/B test email campaign results
    ApiResponse<AbTestCampaignResult> response = apiInstance.GetAbTestCampaignResultWithHttpInfo(campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.GetAbTestCampaignResultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | Id of the A/B test campaign |  |

### Return type

[**AbTestCampaignResult**](AbTestCampaignResult.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A/B test email campaign Result |  -  |
| **404** | A/B test Email Campaign not found |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getemailcampaign"></a>
# **GetEmailCampaign**
> GetEmailCampaign GetEmailCampaign (long campaignId, string statistics = null)

Get an email campaign report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetEmailCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new EmailCampaignsApi(config);
            var campaignId = 789L;  // long | Id of the campaign
            var statistics = "globalStats";  // string | Filter on type of the statistics required. Example **globalStats** value will only fetch globalStats info of the campaign in returned response. (optional) 

            try
            {
                // Get an email campaign report
                GetEmailCampaign result = apiInstance.GetEmailCampaign(campaignId, statistics);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.GetEmailCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an email campaign report
    ApiResponse<GetEmailCampaign> response = apiInstance.GetEmailCampaignWithHttpInfo(campaignId, statistics);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.GetEmailCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | Id of the campaign |  |
| **statistics** | **string** | Filter on type of the statistics required. Example **globalStats** value will only fetch globalStats info of the campaign in returned response. | [optional]  |

### Return type

[**GetEmailCampaign**](GetEmailCampaign.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Email campaign informations |  -  |
| **404** | Campaign ID not found |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getemailcampaigns"></a>
# **GetEmailCampaigns**
> GetEmailCampaigns GetEmailCampaigns (string type = null, string status = null, string statistics = null, DateTime startDate = null, DateTime endDate = null, long limit = null, long offset = null, bool excludeHtmlContent = null)

Return all your created email campaigns

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetEmailCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new EmailCampaignsApi(config);
            var type = "classic";  // string | Filter on the type of the campaigns (optional) 
            var status = "suspended";  // string | Filter on the status of the campaign (optional) 
            var statistics = "globalStats";  // string | Filter on type of the statistics required. Example **globalStats** value will only fetch globalStats info of the campaign in returned response. (optional) 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Mandatory if endDate is used. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent email campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either 'status' not passed and if passed is set to 'sent' ) (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Mandatory if startDate is used. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent email campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either 'status' not passed and if passed is set to 'sent' ) (optional) 
            var limit = 500L;  // long | Number of documents per page (optional)  (default to 500)
            var offset = 0L;  // long | Index of the first document in the page (optional)  (default to 0)
            var excludeHtmlContent = true;  // bool | Use this flag to exclude htmlContent from the response body. If set to **true**, htmlContent field will be returned as empty string in the response body (optional) 

            try
            {
                // Return all your created email campaigns
                GetEmailCampaigns result = apiInstance.GetEmailCampaigns(type, status, statistics, startDate, endDate, limit, offset, excludeHtmlContent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.GetEmailCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return all your created email campaigns
    ApiResponse<GetEmailCampaigns> response = apiInstance.GetEmailCampaignsWithHttpInfo(type, status, statistics, startDate, endDate, limit, offset, excludeHtmlContent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.GetEmailCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string** | Filter on the type of the campaigns | [optional]  |
| **status** | **string** | Filter on the status of the campaign | [optional]  |
| **statistics** | **string** | Filter on type of the statistics required. Example **globalStats** value will only fetch globalStats info of the campaign in returned response. | [optional]  |
| **startDate** | **DateTime** | Mandatory if endDate is used. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent email campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either &#39;status&#39; not passed and if passed is set to &#39;sent&#39; ) | [optional]  |
| **endDate** | **DateTime** | Mandatory if startDate is used. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent email campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either &#39;status&#39; not passed and if passed is set to &#39;sent&#39; ) | [optional]  |
| **limit** | **long** | Number of documents per page | [optional] [default to 500] |
| **offset** | **long** | Index of the first document in the page | [optional] [default to 0] |
| **excludeHtmlContent** | **bool** | Use this flag to exclude htmlContent from the response body. If set to **true**, htmlContent field will be returned as empty string in the response body | [optional]  |

### Return type

[**GetEmailCampaigns**](GetEmailCampaigns.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, applications/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Email campaigns informations |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsharedtemplateurl"></a>
# **GetSharedTemplateUrl**
> GetSharedTemplateUrl GetSharedTemplateUrl (long campaignId)

Get a shared template url

Get a unique URL to share & import an email template from one Sendinblue account to another.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetSharedTemplateUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new EmailCampaignsApi(config);
            var campaignId = 789L;  // long | Id of the campaign or template

            try
            {
                // Get a shared template url
                GetSharedTemplateUrl result = apiInstance.GetSharedTemplateUrl(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.GetSharedTemplateUrl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSharedTemplateUrlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a shared template url
    ApiResponse<GetSharedTemplateUrl> response = apiInstance.GetSharedTemplateUrlWithHttpInfo(campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.GetSharedTemplateUrlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | Id of the campaign or template |  |

### Return type

[**GetSharedTemplateUrl**](GetSharedTemplateUrl.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Shared template URL information |  -  |
| **404** | Campaign/Template ID not found |  -  |
| **405** | Only email campaigns or templates are allowed |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendemailcampaignnow"></a>
# **SendEmailCampaignNow**
> void SendEmailCampaignNow (long campaignId)

Send an email campaign immediately, based on campaignId

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class SendEmailCampaignNowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new EmailCampaignsApi(config);
            var campaignId = 789L;  // long | Id of the campaign

            try
            {
                // Send an email campaign immediately, based on campaignId
                apiInstance.SendEmailCampaignNow(campaignId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.SendEmailCampaignNow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendEmailCampaignNowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send an email campaign immediately, based on campaignId
    apiInstance.SendEmailCampaignNowWithHttpInfo(campaignId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.SendEmailCampaignNowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | Id of the campaign |  |

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Email campaign has been scheduled |  -  |
| **400** | Campaign could not be sent |  -  |
| **402** | You don&#39;t have enough credit to send your campaign. Please update your plan |  -  |
| **404** | Campaign ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendreport"></a>
# **SendReport**
> void SendReport (long campaignId, SendReport sendReport)

Send the report of a campaign

A PDF will be sent to the specified email addresses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class SendReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new EmailCampaignsApi(config);
            var campaignId = 789L;  // long | Id of the campaign
            var sendReport = new SendReport(); // SendReport | Values for send a report

            try
            {
                // Send the report of a campaign
                apiInstance.SendReport(campaignId, sendReport);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.SendReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send the report of a campaign
    apiInstance.SendReportWithHttpInfo(campaignId, sendReport);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.SendReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | Id of the campaign |  |
| **sendReport** | [**SendReport**](SendReport.md) | Values for send a report |  |

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Report has been successfully sent to the defined recipients |  -  |
| **400** | bad request |  -  |
| **404** | Campaign ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendtestemail"></a>
# **SendTestEmail**
> void SendTestEmail (long campaignId, SendTestEmail emailTo)

Send an email campaign to your test list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class SendTestEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new EmailCampaignsApi(config);
            var campaignId = 789L;  // long | Id of the campaign
            var emailTo = new SendTestEmail(); // SendTestEmail | 

            try
            {
                // Send an email campaign to your test list
                apiInstance.SendTestEmail(campaignId, emailTo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.SendTestEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendTestEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send an email campaign to your test list
    apiInstance.SendTestEmailWithHttpInfo(campaignId, emailTo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.SendTestEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | Id of the campaign |  |
| **emailTo** | [**SendTestEmail**](SendTestEmail.md) |  |  |

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Test email has been sent successfully to all recipients |  -  |
| **400** | Test email could not be sent to the following email addresses |  -  |
| **404** | Campaign ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatecampaignstatus"></a>
# **UpdateCampaignStatus**
> void UpdateCampaignStatus (long campaignId, UpdateCampaignStatus status)

Update an email campaign status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class UpdateCampaignStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new EmailCampaignsApi(config);
            var campaignId = 789L;  // long | Id of the campaign
            var status = new UpdateCampaignStatus(); // UpdateCampaignStatus | Status of the campaign

            try
            {
                // Update an email campaign status
                apiInstance.UpdateCampaignStatus(campaignId, status);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.UpdateCampaignStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCampaignStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an email campaign status
    apiInstance.UpdateCampaignStatusWithHttpInfo(campaignId, status);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.UpdateCampaignStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | Id of the campaign |  |
| **status** | [**UpdateCampaignStatus**](UpdateCampaignStatus.md) | Status of the campaign |  |

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The campaign status has been updated successfully |  -  |
| **400** | bad request |  -  |
| **404** | Campaign ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateemailcampaign"></a>
# **UpdateEmailCampaign**
> void UpdateEmailCampaign (long campaignId, UpdateEmailCampaign emailCampaign)

Update an email campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class UpdateEmailCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new EmailCampaignsApi(config);
            var campaignId = 789L;  // long | Id of the campaign
            var emailCampaign = new UpdateEmailCampaign(); // UpdateEmailCampaign | Values to update a campaign

            try
            {
                // Update an email campaign
                apiInstance.UpdateEmailCampaign(campaignId, emailCampaign);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.UpdateEmailCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEmailCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an email campaign
    apiInstance.UpdateEmailCampaignWithHttpInfo(campaignId, emailCampaign);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.UpdateEmailCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | Id of the campaign |  |
| **emailCampaign** | [**UpdateEmailCampaign**](UpdateEmailCampaign.md) | Values to update a campaign |  |

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Email Campaign has been updated |  -  |
| **400** | bad request |  -  |
| **404** | Campaign ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="uploadimagetogallery"></a>
# **UploadImageToGallery**
> void UploadImageToGallery (UploadImageToGallery uploadImage)

Upload an image to your account's image gallery

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class UploadImageToGalleryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new EmailCampaignsApi(config);
            var uploadImage = new UploadImageToGallery(); // UploadImageToGallery | Parameters to upload an image

            try
            {
                // Upload an image to your account's image gallery
                apiInstance.UploadImageToGallery(uploadImage);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailCampaignsApi.UploadImageToGallery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadImageToGalleryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload an image to your account's image gallery
    apiInstance.UploadImageToGalleryWithHttpInfo(uploadImage);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailCampaignsApi.UploadImageToGalleryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uploadImage** | [**UploadImageToGallery**](UploadImageToGallery.md) | Parameters to upload an image |  |

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Image successfully uploaded |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

