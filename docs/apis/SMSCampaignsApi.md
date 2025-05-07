# BrevoDotNet.Api.SMSCampaignsApi

All URIs are relative to *https://api.sendinblue.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSmsCampaign**](SMSCampaignsApi.md#createsmscampaign) | **POST** /smsCampaigns | Creates an SMS campaign |
| [**DeleteSmsCampaign**](SMSCampaignsApi.md#deletesmscampaign) | **DELETE** /smsCampaigns/{campaignId} | Delete an SMS campaign |
| [**GetSmsCampaign**](SMSCampaignsApi.md#getsmscampaign) | **GET** /smsCampaigns/{campaignId} | Get an SMS campaign |
| [**GetSmsCampaigns**](SMSCampaignsApi.md#getsmscampaigns) | **GET** /smsCampaigns | Returns the information for all your created SMS campaigns |
| [**RequestSmsRecipientExport**](SMSCampaignsApi.md#requestsmsrecipientexport) | **POST** /smsCampaigns/{campaignId}/exportRecipients | Export an SMS campaign&#39;s recipients |
| [**SendSmsCampaignNow**](SMSCampaignsApi.md#sendsmscampaignnow) | **POST** /smsCampaigns/{campaignId}/sendNow | Send your SMS campaign immediately |
| [**SendSmsReport**](SMSCampaignsApi.md#sendsmsreport) | **POST** /smsCampaigns/{campaignId}/sendReport | Send an SMS campaign&#39;s report |
| [**SendTestSms**](SMSCampaignsApi.md#sendtestsms) | **POST** /smsCampaigns/{campaignId}/sendTest | Send a test SMS campaign |
| [**UpdateSmsCampaign**](SMSCampaignsApi.md#updatesmscampaign) | **PUT** /smsCampaigns/{campaignId} | Update an SMS campaign |
| [**UpdateSmsCampaignStatus**](SMSCampaignsApi.md#updatesmscampaignstatus) | **PUT** /smsCampaigns/{campaignId}/status | Update a campaign&#39;s status |

<a id="createsmscampaign"></a>
# **CreateSmsCampaign**
> CreateModel CreateSmsCampaign (CreateSmsCampaign createSmsCampaign)

Creates an SMS campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class CreateSmsCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMSCampaignsApi(config);
            var createSmsCampaign = new CreateSmsCampaign(); // CreateSmsCampaign | Values to create an SMS Campaign

            try
            {
                // Creates an SMS campaign
                CreateModel result = apiInstance.CreateSmsCampaign(createSmsCampaign);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.CreateSmsCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSmsCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates an SMS campaign
    ApiResponse<CreateModel> response = apiInstance.CreateSmsCampaignWithHttpInfo(createSmsCampaign);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSCampaignsApi.CreateSmsCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createSmsCampaign** | [**CreateSmsCampaign**](CreateSmsCampaign.md) | Values to create an SMS Campaign |  |

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
| **201** | SMS campaign created |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletesmscampaign"></a>
# **DeleteSmsCampaign**
> void DeleteSmsCampaign (long campaignId)

Delete an SMS campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class DeleteSmsCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMSCampaignsApi(config);
            var campaignId = 789L;  // long | id of the SMS campaign

            try
            {
                // Delete an SMS campaign
                apiInstance.DeleteSmsCampaign(campaignId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.DeleteSmsCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSmsCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an SMS campaign
    apiInstance.DeleteSmsCampaignWithHttpInfo(campaignId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSCampaignsApi.DeleteSmsCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | id of the SMS campaign |  |

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
| **204** | SMS campaign has been deleted |  -  |
| **404** | Campaign ID not found |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsmscampaign"></a>
# **GetSmsCampaign**
> GetSmsCampaign GetSmsCampaign (long campaignId)

Get an SMS campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetSmsCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMSCampaignsApi(config);
            var campaignId = 789L;  // long | id of the SMS campaign

            try
            {
                // Get an SMS campaign
                GetSmsCampaign result = apiInstance.GetSmsCampaign(campaignId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.GetSmsCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmsCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an SMS campaign
    ApiResponse<GetSmsCampaign> response = apiInstance.GetSmsCampaignWithHttpInfo(campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSCampaignsApi.GetSmsCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | id of the SMS campaign |  |

### Return type

[**GetSmsCampaign**](GetSmsCampaign.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | SMS campaign informations |  -  |
| **400** | bad request |  -  |
| **404** | Campaign ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsmscampaigns"></a>
# **GetSmsCampaigns**
> GetSmsCampaigns GetSmsCampaigns (string status = null, DateTime startDate = null, DateTime endDate = null, long limit = null, long offset = null)

Returns the information for all your created SMS campaigns

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetSmsCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMSCampaignsApi(config);
            var status = "suspended";  // string | Status of campaign. (optional) 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Mandatory if endDate is used. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent sms campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either 'status' not passed and if passed is set to 'sent' ) (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | Mandatory if startDate is used. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent sms campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either 'status' not passed and if passed is set to 'sent' ) (optional) 
            var limit = 500L;  // long | Number limitation for the result returned (optional)  (default to 500)
            var offset = 0L;  // long | Beginning point in the list to retrieve from. (optional)  (default to 0)

            try
            {
                // Returns the information for all your created SMS campaigns
                GetSmsCampaigns result = apiInstance.GetSmsCampaigns(status, startDate, endDate, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.GetSmsCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmsCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the information for all your created SMS campaigns
    ApiResponse<GetSmsCampaigns> response = apiInstance.GetSmsCampaignsWithHttpInfo(status, startDate, endDate, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSCampaignsApi.GetSmsCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **string** | Status of campaign. | [optional]  |
| **startDate** | **DateTime** | Mandatory if endDate is used. Starting (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent sms campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either &#39;status&#39; not passed and if passed is set to &#39;sent&#39; ) | [optional]  |
| **endDate** | **DateTime** | Mandatory if startDate is used. Ending (urlencoded) UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ) to filter the sent sms campaigns. Prefer to pass your timezone in date-time format for accurate result ( only available if either &#39;status&#39; not passed and if passed is set to &#39;sent&#39; ) | [optional]  |
| **limit** | **long** | Number limitation for the result returned | [optional] [default to 500] |
| **offset** | **long** | Beginning point in the list to retrieve from. | [optional] [default to 0] |

### Return type

[**GetSmsCampaigns**](GetSmsCampaigns.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | SMS campaigns informations |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="requestsmsrecipientexport"></a>
# **RequestSmsRecipientExport**
> CreatedProcessId RequestSmsRecipientExport (long campaignId, RequestSmsRecipientExport recipientExport = null)

Export an SMS campaign's recipients

It returns the background process ID which on completion calls the notify URL that you have set in the input.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class RequestSmsRecipientExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMSCampaignsApi(config);
            var campaignId = 789L;  // long | id of the campaign
            var recipientExport = new RequestSmsRecipientExport(); // RequestSmsRecipientExport | Values to send for a recipient export request (optional) 

            try
            {
                // Export an SMS campaign's recipients
                CreatedProcessId result = apiInstance.RequestSmsRecipientExport(campaignId, recipientExport);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.RequestSmsRecipientExport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestSmsRecipientExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export an SMS campaign's recipients
    ApiResponse<CreatedProcessId> response = apiInstance.RequestSmsRecipientExportWithHttpInfo(campaignId, recipientExport);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSCampaignsApi.RequestSmsRecipientExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | id of the campaign |  |
| **recipientExport** | [**RequestSmsRecipientExport**](RequestSmsRecipientExport.md) | Values to send for a recipient export request | [optional]  |

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

<a id="sendsmscampaignnow"></a>
# **SendSmsCampaignNow**
> void SendSmsCampaignNow (long campaignId)

Send your SMS campaign immediately

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class SendSmsCampaignNowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMSCampaignsApi(config);
            var campaignId = 789L;  // long | id of the campaign

            try
            {
                // Send your SMS campaign immediately
                apiInstance.SendSmsCampaignNow(campaignId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.SendSmsCampaignNow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendSmsCampaignNowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send your SMS campaign immediately
    apiInstance.SendSmsCampaignNowWithHttpInfo(campaignId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSCampaignsApi.SendSmsCampaignNowWithHttpInfo: " + e.Message);
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
| **204** | SMS campaign has been scheduled |  -  |
| **400** | SMS Campaign could not be sent |  -  |
| **402** | You don&#39;t have enough credit to send your campaign. Please update your plan |  -  |
| **404** | Campaign ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendsmsreport"></a>
# **SendSmsReport**
> void SendSmsReport (long campaignId, SendReport sendReport)

Send an SMS campaign's report

Send report of Sent and Archived campaign, to the specified email addresses, with respective data and a pdf attachment in detail.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class SendSmsReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMSCampaignsApi(config);
            var campaignId = 789L;  // long | id of the campaign
            var sendReport = new SendReport(); // SendReport | Values for send a report

            try
            {
                // Send an SMS campaign's report
                apiInstance.SendSmsReport(campaignId, sendReport);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.SendSmsReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendSmsReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send an SMS campaign's report
    apiInstance.SendSmsReportWithHttpInfo(campaignId, sendReport);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSCampaignsApi.SendSmsReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | id of the campaign |  |
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

<a id="sendtestsms"></a>
# **SendTestSms**
> void SendTestSms (long campaignId, SendTestSms phoneNumber)

Send a test SMS campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class SendTestSmsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMSCampaignsApi(config);
            var campaignId = 789L;  // long | Id of the SMS campaign
            var phoneNumber = new SendTestSms(); // SendTestSms | Mobile number of the recipient with the country code. This number must belong to one of your contacts in SendinBlue account and must not be blacklisted

            try
            {
                // Send a test SMS campaign
                apiInstance.SendTestSms(campaignId, phoneNumber);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.SendTestSms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendTestSmsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a test SMS campaign
    apiInstance.SendTestSmsWithHttpInfo(campaignId, phoneNumber);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSCampaignsApi.SendTestSmsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | Id of the SMS campaign |  |
| **phoneNumber** | [**SendTestSms**](SendTestSms.md) | Mobile number of the recipient with the country code. This number must belong to one of your contacts in SendinBlue account and must not be blacklisted |  |

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
| **204** | Test SMS has been sent successfully to the recipient |  -  |
| **400** | Test SMS could not be sent to the following email addresses |  -  |
| **404** | Campaign ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatesmscampaign"></a>
# **UpdateSmsCampaign**
> void UpdateSmsCampaign (long campaignId, UpdateSmsCampaign updateSmsCampaign)

Update an SMS campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class UpdateSmsCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMSCampaignsApi(config);
            var campaignId = 789L;  // long | id of the SMS campaign
            var updateSmsCampaign = new UpdateSmsCampaign(); // UpdateSmsCampaign | Values to update an SMS Campaign

            try
            {
                // Update an SMS campaign
                apiInstance.UpdateSmsCampaign(campaignId, updateSmsCampaign);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.UpdateSmsCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSmsCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an SMS campaign
    apiInstance.UpdateSmsCampaignWithHttpInfo(campaignId, updateSmsCampaign);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSCampaignsApi.UpdateSmsCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | id of the SMS campaign |  |
| **updateSmsCampaign** | [**UpdateSmsCampaign**](UpdateSmsCampaign.md) | Values to update an SMS Campaign |  |

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
| **204** | SMS campaign updated |  -  |
| **400** | bad request |  -  |
| **404** | Campaign ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatesmscampaignstatus"></a>
# **UpdateSmsCampaignStatus**
> void UpdateSmsCampaignStatus (long campaignId, UpdateCampaignStatus status)

Update a campaign's status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class UpdateSmsCampaignStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMSCampaignsApi(config);
            var campaignId = 789L;  // long | id of the campaign
            var status = new UpdateCampaignStatus(); // UpdateCampaignStatus | Status of the campaign.

            try
            {
                // Update a campaign's status
                apiInstance.UpdateSmsCampaignStatus(campaignId, status);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSCampaignsApi.UpdateSmsCampaignStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSmsCampaignStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a campaign's status
    apiInstance.UpdateSmsCampaignStatusWithHttpInfo(campaignId, status);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSCampaignsApi.UpdateSmsCampaignStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **campaignId** | **long** | id of the campaign |  |
| **status** | [**UpdateCampaignStatus**](UpdateCampaignStatus.md) | Status of the campaign. |  |

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

