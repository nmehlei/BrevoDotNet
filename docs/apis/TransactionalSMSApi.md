# BrevoDotNet.Api.TransactionalSMSApi

All URIs are relative to *https://api.sendinblue.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSmsEvents**](TransactionalSMSApi.md#getsmsevents) | **GET** /transactionalSMS/statistics/events | Get all your SMS activity (unaggregated events) |
| [**GetTransacAggregatedSmsReport**](TransactionalSMSApi.md#gettransacaggregatedsmsreport) | **GET** /transactionalSMS/statistics/aggregatedReport | Get your SMS activity aggregated over a period of time |
| [**GetTransacSmsReport**](TransactionalSMSApi.md#gettransacsmsreport) | **GET** /transactionalSMS/statistics/reports | Get your SMS activity aggregated per day |
| [**SendTransacSms**](TransactionalSMSApi.md#sendtransacsms) | **POST** /transactionalSMS/sms | Send SMS message to a mobile number |

<a id="getsmsevents"></a>
# **GetSmsEvents**
> GetSmsEventReport GetSmsEvents (long limit = null, string startDate = null, string endDate = null, long offset = null, int days = null, string phoneNumber = null, string varEvent = null, string tags = null, string sort = null)

Get all your SMS activity (unaggregated events)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetSmsEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new TransactionalSMSApi(config);
            var limit = 50L;  // long | Number of documents per page (optional)  (default to 50)
            var startDate = "startDate_example";  // string | Mandatory if endDate is used. Starting date (YYYY-MM-DD) of the report (optional) 
            var endDate = "endDate_example";  // string | Mandatory if startDate is used. Ending date (YYYY-MM-DD) of the report (optional) 
            var offset = 0L;  // long | Index of the first document of the page (optional)  (default to 0)
            var days = 56;  // int | Number of days in the past including today (positive integer). Not compatible with 'startDate' and 'endDate' (optional) 
            var phoneNumber = "phoneNumber_example";  // string | Filter the report for a specific phone number (optional) 
            var varEvent = "bounces";  // string | Filter the report for specific events (optional) 
            var tags = "tags_example";  // string | Filter the report for specific tags passed as a serialized urlencoded array (optional) 
            var sort = "asc";  // string | Sort the results in the ascending/descending order of record creation (optional)  (default to desc)

            try
            {
                // Get all your SMS activity (unaggregated events)
                GetSmsEventReport result = apiInstance.GetSmsEvents(limit, startDate, endDate, offset, days, phoneNumber, varEvent, tags, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionalSMSApi.GetSmsEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmsEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all your SMS activity (unaggregated events)
    ApiResponse<GetSmsEventReport> response = apiInstance.GetSmsEventsWithHttpInfo(limit, startDate, endDate, offset, days, phoneNumber, varEvent, tags, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionalSMSApi.GetSmsEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **long** | Number of documents per page | [optional] [default to 50] |
| **startDate** | **string** | Mandatory if endDate is used. Starting date (YYYY-MM-DD) of the report | [optional]  |
| **endDate** | **string** | Mandatory if startDate is used. Ending date (YYYY-MM-DD) of the report | [optional]  |
| **offset** | **long** | Index of the first document of the page | [optional] [default to 0] |
| **days** | **int** | Number of days in the past including today (positive integer). Not compatible with &#39;startDate&#39; and &#39;endDate&#39; | [optional]  |
| **phoneNumber** | **string** | Filter the report for a specific phone number | [optional]  |
| **varEvent** | **string** | Filter the report for specific events | [optional]  |
| **tags** | **string** | Filter the report for specific tags passed as a serialized urlencoded array | [optional]  |
| **sort** | **string** | Sort the results in the ascending/descending order of record creation | [optional] [default to desc] |

### Return type

[**GetSmsEventReport**](GetSmsEventReport.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Sms events report informations |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettransacaggregatedsmsreport"></a>
# **GetTransacAggregatedSmsReport**
> GetTransacAggregatedSmsReport GetTransacAggregatedSmsReport (string startDate = null, string endDate = null, int days = null, string tag = null)

Get your SMS activity aggregated over a period of time

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetTransacAggregatedSmsReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new TransactionalSMSApi(config);
            var startDate = "startDate_example";  // string | Mandatory if endDate is used. Starting date (YYYY-MM-DD) of the report (optional) 
            var endDate = "endDate_example";  // string | Mandatory if startDate is used. Ending date (YYYY-MM-DD) of the report (optional) 
            var days = 56;  // int | Number of days in the past including today (positive integer). Not compatible with startDate and endDate (optional) 
            var tag = "tag_example";  // string | Filter on a tag (optional) 

            try
            {
                // Get your SMS activity aggregated over a period of time
                GetTransacAggregatedSmsReport result = apiInstance.GetTransacAggregatedSmsReport(startDate, endDate, days, tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionalSMSApi.GetTransacAggregatedSmsReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransacAggregatedSmsReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get your SMS activity aggregated over a period of time
    ApiResponse<GetTransacAggregatedSmsReport> response = apiInstance.GetTransacAggregatedSmsReportWithHttpInfo(startDate, endDate, days, tag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionalSMSApi.GetTransacAggregatedSmsReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startDate** | **string** | Mandatory if endDate is used. Starting date (YYYY-MM-DD) of the report | [optional]  |
| **endDate** | **string** | Mandatory if startDate is used. Ending date (YYYY-MM-DD) of the report | [optional]  |
| **days** | **int** | Number of days in the past including today (positive integer). Not compatible with startDate and endDate | [optional]  |
| **tag** | **string** | Filter on a tag | [optional]  |

### Return type

[**GetTransacAggregatedSmsReport**](GetTransacAggregatedSmsReport.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Aggregated SMS report informations |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettransacsmsreport"></a>
# **GetTransacSmsReport**
> GetTransacSmsReport GetTransacSmsReport (string startDate = null, string endDate = null, int days = null, string tag = null, string sort = null)

Get your SMS activity aggregated per day

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetTransacSmsReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new TransactionalSMSApi(config);
            var startDate = "startDate_example";  // string | Mandatory if endDate is used. Starting date (YYYY-MM-DD) of the report (optional) 
            var endDate = "endDate_example";  // string | Mandatory if startDate is used. Ending date (YYYY-MM-DD) of the report (optional) 
            var days = 56;  // int | Number of days in the past including today (positive integer). Not compatible with 'startDate' and 'endDate' (optional) 
            var tag = "tag_example";  // string | Filter on a tag (optional) 
            var sort = "asc";  // string | Sort the results in the ascending/descending order of record creation (optional)  (default to desc)

            try
            {
                // Get your SMS activity aggregated per day
                GetTransacSmsReport result = apiInstance.GetTransacSmsReport(startDate, endDate, days, tag, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionalSMSApi.GetTransacSmsReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransacSmsReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get your SMS activity aggregated per day
    ApiResponse<GetTransacSmsReport> response = apiInstance.GetTransacSmsReportWithHttpInfo(startDate, endDate, days, tag, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionalSMSApi.GetTransacSmsReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startDate** | **string** | Mandatory if endDate is used. Starting date (YYYY-MM-DD) of the report | [optional]  |
| **endDate** | **string** | Mandatory if startDate is used. Ending date (YYYY-MM-DD) of the report | [optional]  |
| **days** | **int** | Number of days in the past including today (positive integer). Not compatible with &#39;startDate&#39; and &#39;endDate&#39; | [optional]  |
| **tag** | **string** | Filter on a tag | [optional]  |
| **sort** | **string** | Sort the results in the ascending/descending order of record creation | [optional] [default to desc] |

### Return type

[**GetTransacSmsReport**](GetTransacSmsReport.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Aggregated SMS report informations |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendtransacsms"></a>
# **SendTransacSms**
> SendSms SendTransacSms (SendTransacSms sendTransacSms)

Send SMS message to a mobile number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class SendTransacSmsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new TransactionalSMSApi(config);
            var sendTransacSms = new SendTransacSms(); // SendTransacSms | Values to send a transactional SMS

            try
            {
                // Send SMS message to a mobile number
                SendSms result = apiInstance.SendTransacSms(sendTransacSms);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionalSMSApi.SendTransacSms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendTransacSmsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send SMS message to a mobile number
    ApiResponse<SendSms> response = apiInstance.SendTransacSmsWithHttpInfo(sendTransacSms);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionalSMSApi.SendTransacSmsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendTransacSms** | [**SendTransacSms**](SendTransacSms.md) | Values to send a transactional SMS |  |

### Return type

[**SendSms**](SendSms.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | SMS has been sent successfully to the recipient |  -  |
| **400** | bad request |  -  |
| **402** | You don&#39;t have enough credit to send your SMS. Please update your plan |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

