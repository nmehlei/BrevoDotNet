# BrevoDotNet.Api.WhatsAppCampaignsApi

All URIs are relative to *https://api.sendinblue.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteWhatsAppCampaign**](WhatsAppCampaignsApi.md#deletewhatsappcampaign) | **DELETE** /whatsappCampaigns/{campaignId} | Delete a WhatsApp campaign |
| [**GetWhatsAppCampaign**](WhatsAppCampaignsApi.md#getwhatsappcampaign) | **GET** /whatsappCampaigns/{campaignId} | Get a WhatsApp campaign |
| [**GetWhatsAppCampaigns**](WhatsAppCampaignsApi.md#getwhatsappcampaigns) | **GET** /whatsappCampaigns | Return all your created WhatsApp campaigns |
| [**GetWhatsAppTemplates**](WhatsAppCampaignsApi.md#getwhatsapptemplates) | **GET** /whatsappCampaigns/template-list | Return all your created WhatsApp templates |

<a id="deletewhatsappcampaign"></a>
# **DeleteWhatsAppCampaign**
> void DeleteWhatsAppCampaign (long campaignId)

Delete a WhatsApp campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class DeleteWhatsAppCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new WhatsAppCampaignsApi(config);
            var campaignId = 789L;  // long | id of the campaign

            try
            {
                // Delete a WhatsApp campaign
                apiInstance.DeleteWhatsAppCampaign(campaignId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WhatsAppCampaignsApi.DeleteWhatsAppCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWhatsAppCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a WhatsApp campaign
    apiInstance.DeleteWhatsAppCampaignWithHttpInfo(campaignId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WhatsAppCampaignsApi.DeleteWhatsAppCampaignWithHttpInfo: " + e.Message);
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
| **204** | WhatsApp campaign has been deleted |  -  |
| **400** | bad request |  -  |
| **404** | Campaign Id not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwhatsappcampaign"></a>
# **GetWhatsAppCampaign**
> GetWhatsappCampaignOverview GetWhatsAppCampaign (long campaignId)

Get a WhatsApp campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetWhatsAppCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new WhatsAppCampaignsApi(config);
            var campaignId = 789L;  // long | Id of the campaign

            try
            {
                // Get a WhatsApp campaign
                GetWhatsappCampaignOverview result = apiInstance.GetWhatsAppCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WhatsAppCampaignsApi.GetWhatsAppCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWhatsAppCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a WhatsApp campaign
    ApiResponse<GetWhatsappCampaignOverview> response = apiInstance.GetWhatsAppCampaignWithHttpInfo(campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WhatsAppCampaignsApi.GetWhatsAppCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | Id of the campaign |  |

### Return type

[**GetWhatsappCampaignOverview**](GetWhatsappCampaignOverview.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get WhatsApp campaign information on the basis of campaignId |  -  |
| **400** | bad request |  -  |
| **404** | Campaign Id not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwhatsappcampaigns"></a>
# **GetWhatsAppCampaigns**
> GetWhatsappCampaigns GetWhatsAppCampaigns (string startDate = null, string endDate = null, long limit = null, long offset = null, string sort = null)

Return all your created WhatsApp campaigns

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetWhatsAppCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new WhatsAppCampaignsApi(config);
            var startDate = "startDate_example";  // string | **Mandatory if endDate is used**. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the campaigns created. **Prefer to pass your timezone in date-time format for accurate result**  (optional) 
            var endDate = "endDate_example";  // string | **Mandatory if startDate is used**. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the campaigns created. **Prefer to pass your timezone in date-time format for accurate result**  (optional) 
            var limit = 50L;  // long | Number of documents per page (optional)  (default to 50)
            var offset = 0L;  // long | Index of the first document in the page (optional)  (default to 0)
            var sort = "asc";  // string | Sort the results in the ascending/descending order of record modification. Default order is **descending** if `sort` is not passed (optional)  (default to desc)

            try
            {
                // Return all your created WhatsApp campaigns
                GetWhatsappCampaigns result = apiInstance.GetWhatsAppCampaigns(startDate, endDate, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WhatsAppCampaignsApi.GetWhatsAppCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWhatsAppCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return all your created WhatsApp campaigns
    ApiResponse<GetWhatsappCampaigns> response = apiInstance.GetWhatsAppCampaignsWithHttpInfo(startDate, endDate, limit, offset, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WhatsAppCampaignsApi.GetWhatsAppCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startDate** | **string** | **Mandatory if endDate is used**. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the campaigns created. **Prefer to pass your timezone in date-time format for accurate result**  | [optional]  |
| **endDate** | **string** | **Mandatory if startDate is used**. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the campaigns created. **Prefer to pass your timezone in date-time format for accurate result**  | [optional]  |
| **limit** | **long** | Number of documents per page | [optional] [default to 50] |
| **offset** | **long** | Index of the first document in the page | [optional] [default to 0] |
| **sort** | **string** | Sort the results in the ascending/descending order of record modification. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc] |

### Return type

[**GetWhatsappCampaigns**](GetWhatsappCampaigns.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | WhatsApp campaigns informations |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwhatsapptemplates"></a>
# **GetWhatsAppTemplates**
> GetWATemplates GetWhatsAppTemplates (string startDate = null, string endDate = null, long limit = null, long offset = null, string sort = null)

Return all your created WhatsApp templates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetWhatsAppTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new WhatsAppCampaignsApi(config);
            var startDate = "startDate_example";  // string | **Mandatory if endDate is used**. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the templates created. **Prefer to pass your timezone in date-time format for accurate result**  (optional) 
            var endDate = "endDate_example";  // string | **Mandatory if startDate is used**. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the templates created. **Prefer to pass your timezone in date-time format for accurate result**  (optional) 
            var limit = 50L;  // long | Number of documents per page (optional)  (default to 50)
            var offset = 0L;  // long | Index of the first document in the page (optional)  (default to 0)
            var sort = "asc";  // string | Sort the results in the ascending/descending order of record modification. Default order is **descending** if `sort` is not passed (optional)  (default to desc)

            try
            {
                // Return all your created WhatsApp templates
                GetWATemplates result = apiInstance.GetWhatsAppTemplates(startDate, endDate, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WhatsAppCampaignsApi.GetWhatsAppTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWhatsAppTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return all your created WhatsApp templates
    ApiResponse<GetWATemplates> response = apiInstance.GetWhatsAppTemplatesWithHttpInfo(startDate, endDate, limit, offset, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WhatsAppCampaignsApi.GetWhatsAppTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startDate** | **string** | **Mandatory if endDate is used**. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the templates created. **Prefer to pass your timezone in date-time format for accurate result**  | [optional]  |
| **endDate** | **string** | **Mandatory if startDate is used**. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the templates created. **Prefer to pass your timezone in date-time format for accurate result**  | [optional]  |
| **limit** | **long** | Number of documents per page | [optional] [default to 50] |
| **offset** | **long** | Index of the first document in the page | [optional] [default to 0] |
| **sort** | **string** | Sort the results in the ascending/descending order of record modification. Default order is **descending** if &#x60;sort&#x60; is not passed | [optional] [default to desc] |

### Return type

[**GetWATemplates**](GetWATemplates.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | WhatsApp templates informations |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

