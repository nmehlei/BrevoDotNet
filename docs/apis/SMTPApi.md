# BrevoDotNet.Api.SMTPApi

All URIs are relative to *https://api.sendinblue.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BlockNewDomain**](SMTPApi.md#blocknewdomain) | **POST** /smtp/blockedDomains | Add a new domain to the list of blocked domains |
| [**CreateSmtpTemplate**](SMTPApi.md#createsmtptemplate) | **POST** /smtp/templates | Create an email template |
| [**DeleteBlockedDomain**](SMTPApi.md#deleteblockeddomain) | **DELETE** /smtp/blockedDomains/{domain} | Unblock an existing domain from the list of blocked domains |
| [**DeleteHardbounces**](SMTPApi.md#deletehardbounces) | **POST** /smtp/deleteHardbounces | Delete hardbounces |
| [**DeleteSmtpTemplate**](SMTPApi.md#deletesmtptemplate) | **DELETE** /smtp/templates/{templateId} | Delete an inactive email template |
| [**GetAggregatedSmtpReport**](SMTPApi.md#getaggregatedsmtpreport) | **GET** /smtp/statistics/aggregatedReport | Get your transactional email activity aggregated over a period of time |
| [**GetBlockedDomains**](SMTPApi.md#getblockeddomains) | **GET** /smtp/blockedDomains | Get the list of blocked domains |
| [**GetEmailEventReport**](SMTPApi.md#getemaileventreport) | **GET** /smtp/statistics/events | Get all your transactional email activity (unaggregated events) |
| [**GetSmtpReport**](SMTPApi.md#getsmtpreport) | **GET** /smtp/statistics/reports | Get your transactional email activity aggregated per day |
| [**GetSmtpTemplate**](SMTPApi.md#getsmtptemplate) | **GET** /smtp/templates/{templateId} | Returns the template information |
| [**GetSmtpTemplates**](SMTPApi.md#getsmtptemplates) | **GET** /smtp/templates | Get the list of email templates |
| [**GetTransacBlockedContacts**](SMTPApi.md#gettransacblockedcontacts) | **GET** /smtp/blockedContacts | Get the list of blocked or unsubscribed transactional contacts |
| [**GetTransacEmailContent**](SMTPApi.md#gettransacemailcontent) | **GET** /smtp/emails/{uuid} | Get the personalized content of a sent transactional email |
| [**GetTransacEmailsList**](SMTPApi.md#gettransacemailslist) | **GET** /smtp/emails | Get the list of transactional emails on the basis of allowed filters |
| [**SendTemplate**](SMTPApi.md#sendtemplate) | **POST** /smtp/templates/{templateId}/send | Send a template |
| [**SendTestTemplate**](SMTPApi.md#sendtesttemplate) | **POST** /smtp/templates/{templateId}/sendTest | Send a template to your test list |
| [**SendTransacEmail**](SMTPApi.md#sendtransacemail) | **POST** /smtp/email | Send a transactional email |
| [**SmtpBlockedContactsEmailDelete**](SMTPApi.md#smtpblockedcontactsemaildelete) | **DELETE** /smtp/blockedContacts/{email} | Unblock or resubscribe a transactional contact |
| [**SmtpLogMessageIdDelete**](SMTPApi.md#smtplogmessageiddelete) | **DELETE** /smtp/log/{messageId} | Delete an SMTP transactional log |
| [**UpdateSmtpTemplate**](SMTPApi.md#updatesmtptemplate) | **PUT** /smtp/templates/{templateId} | Update an email template |

<a id="blocknewdomain"></a>
# **BlockNewDomain**
> void BlockNewDomain (BlockDomain blockDomain)

Add a new domain to the list of blocked domains

Blocks a new domain in order to avoid messages being sent to the same

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class BlockNewDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var blockDomain = new BlockDomain(); // BlockDomain | 

            try
            {
                // Add a new domain to the list of blocked domains
                apiInstance.BlockNewDomain(blockDomain);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.BlockNewDomain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BlockNewDomainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new domain to the list of blocked domains
    apiInstance.BlockNewDomainWithHttpInfo(blockDomain);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.BlockNewDomainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockDomain** | [**BlockDomain**](BlockDomain.md) |  |  |

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
| **201** | Domain is successfully blocked |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createsmtptemplate"></a>
# **CreateSmtpTemplate**
> CreateModel CreateSmtpTemplate (CreateSmtpTemplate smtpTemplate)

Create an email template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class CreateSmtpTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var smtpTemplate = new CreateSmtpTemplate(); // CreateSmtpTemplate | values to update in transactional email template

            try
            {
                // Create an email template
                CreateModel result = apiInstance.CreateSmtpTemplate(smtpTemplate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.CreateSmtpTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSmtpTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an email template
    ApiResponse<CreateModel> response = apiInstance.CreateSmtpTemplateWithHttpInfo(smtpTemplate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.CreateSmtpTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smtpTemplate** | [**CreateSmtpTemplate**](CreateSmtpTemplate.md) | values to update in transactional email template |  |

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
| **201** | transactional email template created |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteblockeddomain"></a>
# **DeleteBlockedDomain**
> void DeleteBlockedDomain (string domain)

Unblock an existing domain from the list of blocked domains

Unblocks an existing domain from the list of blocked domains

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class DeleteBlockedDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var domain = "domain_example";  // string | The name of the domain to be deleted

            try
            {
                // Unblock an existing domain from the list of blocked domains
                apiInstance.DeleteBlockedDomain(domain);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.DeleteBlockedDomain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBlockedDomainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unblock an existing domain from the list of blocked domains
    apiInstance.DeleteBlockedDomainWithHttpInfo(domain);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.DeleteBlockedDomainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | The name of the domain to be deleted |  |

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
| **204** | Domain is successfully deleted from the list of blocked domains |  -  |
| **404** | Domain not found |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletehardbounces"></a>
# **DeleteHardbounces**
> void DeleteHardbounces (DeleteHardbounces deleteHardbounces = null)

Delete hardbounces

Delete hardbounces. To use carefully (e.g. in case of temporary ISP failures)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class DeleteHardbouncesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var deleteHardbounces = new DeleteHardbounces(); // DeleteHardbounces | values to delete hardbounces (optional) 

            try
            {
                // Delete hardbounces
                apiInstance.DeleteHardbounces(deleteHardbounces);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.DeleteHardbounces: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteHardbouncesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete hardbounces
    apiInstance.DeleteHardbouncesWithHttpInfo(deleteHardbounces);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.DeleteHardbouncesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteHardbounces** | [**DeleteHardbounces**](DeleteHardbounces.md) | values to delete hardbounces | [optional]  |

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
| **204** | Hardbounces deleted |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletesmtptemplate"></a>
# **DeleteSmtpTemplate**
> void DeleteSmtpTemplate (long templateId)

Delete an inactive email template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class DeleteSmtpTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var templateId = 789L;  // long | id of the template

            try
            {
                // Delete an inactive email template
                apiInstance.DeleteSmtpTemplate(templateId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.DeleteSmtpTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSmtpTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an inactive email template
    apiInstance.DeleteSmtpTemplateWithHttpInfo(templateId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.DeleteSmtpTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **long** | id of the template |  |

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
| **204** | Inactive transactional email template has been deleted |  -  |
| **404** | Template ID not found |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getaggregatedsmtpreport"></a>
# **GetAggregatedSmtpReport**
> GetAggregatedReport GetAggregatedSmtpReport (string startDate = null, string endDate = null, int days = null, string tag = null)

Get your transactional email activity aggregated over a period of time

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetAggregatedSmtpReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var startDate = "startDate_example";  // string | Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD). Must be lower than equal to endDate (optional) 
            var endDate = "endDate_example";  // string | Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate (optional) 
            var days = 56;  // int | Number of days in the past including today (positive integer). Not compatible with 'startDate' and 'endDate' (optional) 
            var tag = "tag_example";  // string | Tag of the emails (optional) 

            try
            {
                // Get your transactional email activity aggregated over a period of time
                GetAggregatedReport result = apiInstance.GetAggregatedSmtpReport(startDate, endDate, days, tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.GetAggregatedSmtpReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAggregatedSmtpReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get your transactional email activity aggregated over a period of time
    ApiResponse<GetAggregatedReport> response = apiInstance.GetAggregatedSmtpReportWithHttpInfo(startDate, endDate, days, tag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.GetAggregatedSmtpReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startDate** | **string** | Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD). Must be lower than equal to endDate | [optional]  |
| **endDate** | **string** | Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate | [optional]  |
| **days** | **int** | Number of days in the past including today (positive integer). Not compatible with &#39;startDate&#39; and &#39;endDate&#39; | [optional]  |
| **tag** | **string** | Tag of the emails | [optional]  |

### Return type

[**GetAggregatedReport**](GetAggregatedReport.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Aggregated report informations |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getblockeddomains"></a>
# **GetBlockedDomains**
> GetBlockedDomains GetBlockedDomains ()

Get the list of blocked domains

Get the list of blocked domains

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetBlockedDomainsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);

            try
            {
                // Get the list of blocked domains
                GetBlockedDomains result = apiInstance.GetBlockedDomains();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.GetBlockedDomains: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBlockedDomainsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the list of blocked domains
    ApiResponse<GetBlockedDomains> response = apiInstance.GetBlockedDomainsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.GetBlockedDomainsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetBlockedDomains**](GetBlockedDomains.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of blocked domains |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getemaileventreport"></a>
# **GetEmailEventReport**
> GetEmailEventReport GetEmailEventReport (long limit = null, long offset = null, string startDate = null, string endDate = null, int days = null, string email = null, string varEvent = null, string tags = null, string messageId = null, long templateId = null)

Get all your transactional email activity (unaggregated events)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetEmailEventReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var limit = 50L;  // long | Number limitation for the result returned (optional)  (default to 50)
            var offset = 0L;  // long | Beginning point in the list to retrieve from. (optional)  (default to 0)
            var startDate = "startDate_example";  // string | Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD). Must be lower than equal to endDate (optional) 
            var endDate = "endDate_example";  // string | Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate (optional) 
            var days = 56;  // int | Number of days in the past including today (positive integer). Not compatible with 'startDate' and 'endDate' (optional) 
            var email = "email_example";  // string | Filter the report for a specific email addresses (optional) 
            var varEvent = "bounces";  // string | Filter the report for a specific event type (optional) 
            var tags = "tags_example";  // string | Filter the report for tags (serialized and urlencoded array) (optional) 
            var messageId = "messageId_example";  // string | Filter on a specific message id (optional) 
            var templateId = 789L;  // long | Filter on a specific template id (optional) 

            try
            {
                // Get all your transactional email activity (unaggregated events)
                GetEmailEventReport result = apiInstance.GetEmailEventReport(limit, offset, startDate, endDate, days, email, varEvent, tags, messageId, templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.GetEmailEventReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEmailEventReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all your transactional email activity (unaggregated events)
    ApiResponse<GetEmailEventReport> response = apiInstance.GetEmailEventReportWithHttpInfo(limit, offset, startDate, endDate, days, email, varEvent, tags, messageId, templateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.GetEmailEventReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **long** | Number limitation for the result returned | [optional] [default to 50] |
| **offset** | **long** | Beginning point in the list to retrieve from. | [optional] [default to 0] |
| **startDate** | **string** | Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD). Must be lower than equal to endDate | [optional]  |
| **endDate** | **string** | Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD). Must be greater than equal to startDate | [optional]  |
| **days** | **int** | Number of days in the past including today (positive integer). Not compatible with &#39;startDate&#39; and &#39;endDate&#39; | [optional]  |
| **email** | **string** | Filter the report for a specific email addresses | [optional]  |
| **varEvent** | **string** | Filter the report for a specific event type | [optional]  |
| **tags** | **string** | Filter the report for tags (serialized and urlencoded array) | [optional]  |
| **messageId** | **string** | Filter on a specific message id | [optional]  |
| **templateId** | **long** | Filter on a specific template id | [optional]  |

### Return type

[**GetEmailEventReport**](GetEmailEventReport.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Email events report informations |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsmtpreport"></a>
# **GetSmtpReport**
> GetReports GetSmtpReport (long limit = null, long offset = null, string startDate = null, string endDate = null, int days = null, string tag = null)

Get your transactional email activity aggregated per day

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetSmtpReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var limit = 10L;  // long | Number of documents returned per page (optional)  (default to 10)
            var offset = 0L;  // long | Index of the first document on the page (optional)  (default to 0)
            var startDate = "startDate_example";  // string | Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD) (optional) 
            var endDate = "endDate_example";  // string | Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD) (optional) 
            var days = 56;  // int | Number of days in the past including today (positive integer). Not compatible with 'startDate' and 'endDate' (optional) 
            var tag = "tag_example";  // string | Tag of the emails (optional) 

            try
            {
                // Get your transactional email activity aggregated per day
                GetReports result = apiInstance.GetSmtpReport(limit, offset, startDate, endDate, days, tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.GetSmtpReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmtpReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get your transactional email activity aggregated per day
    ApiResponse<GetReports> response = apiInstance.GetSmtpReportWithHttpInfo(limit, offset, startDate, endDate, days, tag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.GetSmtpReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **long** | Number of documents returned per page | [optional] [default to 10] |
| **offset** | **long** | Index of the first document on the page | [optional] [default to 0] |
| **startDate** | **string** | Mandatory if endDate is used. Starting date of the report (YYYY-MM-DD) | [optional]  |
| **endDate** | **string** | Mandatory if startDate is used. Ending date of the report (YYYY-MM-DD) | [optional]  |
| **days** | **int** | Number of days in the past including today (positive integer). Not compatible with &#39;startDate&#39; and &#39;endDate&#39; | [optional]  |
| **tag** | **string** | Tag of the emails | [optional]  |

### Return type

[**GetReports**](GetReports.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Aggregated report informations |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsmtptemplate"></a>
# **GetSmtpTemplate**
> GetSmtpTemplateOverview GetSmtpTemplate (long templateId)

Returns the template information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetSmtpTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var templateId = 789L;  // long | id of the template

            try
            {
                // Returns the template information
                GetSmtpTemplateOverview result = apiInstance.GetSmtpTemplate(templateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.GetSmtpTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmtpTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the template information
    ApiResponse<GetSmtpTemplateOverview> response = apiInstance.GetSmtpTemplateWithHttpInfo(templateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.GetSmtpTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **long** | id of the template |  |

### Return type

[**GetSmtpTemplateOverview**](GetSmtpTemplateOverview.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Email template informations |  -  |
| **404** | Template ID not found |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsmtptemplates"></a>
# **GetSmtpTemplates**
> GetSmtpTemplates GetSmtpTemplates (bool templateStatus = null, long limit = null, long offset = null)

Get the list of email templates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetSmtpTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var templateStatus = true;  // bool | Filter on the status of the template. Active = true, inactive = false (optional) 
            var limit = 50L;  // long | Number of documents returned per page (optional)  (default to 50)
            var offset = 0L;  // long | Index of the first document in the page (optional)  (default to 0)

            try
            {
                // Get the list of email templates
                GetSmtpTemplates result = apiInstance.GetSmtpTemplates(templateStatus, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.GetSmtpTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmtpTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the list of email templates
    ApiResponse<GetSmtpTemplates> response = apiInstance.GetSmtpTemplatesWithHttpInfo(templateStatus, limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.GetSmtpTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateStatus** | **bool** | Filter on the status of the template. Active &#x3D; true, inactive &#x3D; false | [optional]  |
| **limit** | **long** | Number of documents returned per page | [optional] [default to 50] |
| **offset** | **long** | Index of the first document in the page | [optional] [default to 0] |

### Return type

[**GetSmtpTemplates**](GetSmtpTemplates.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | transactional email templates informations |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettransacblockedcontacts"></a>
# **GetTransacBlockedContacts**
> GetTransacBlockedContacts GetTransacBlockedContacts (string startDate = null, string endDate = null, long limit = null, long offset = null, List<string> senders = null)

Get the list of blocked or unsubscribed transactional contacts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetTransacBlockedContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var startDate = "startDate_example";  // string | Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the blocked or unsubscribed contacts (optional) 
            var endDate = "endDate_example";  // string | Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the blocked or unsubscribed contacts (optional) 
            var limit = 50L;  // long | Number of documents returned per page (optional)  (default to 50)
            var offset = 0L;  // long | Index of the first document on the page (optional)  (default to 0)
            var senders = new List<string>(); // List<string> | Comma separated list of emails of the senders from which contacts are blocked or unsubscribed (optional) 

            try
            {
                // Get the list of blocked or unsubscribed transactional contacts
                GetTransacBlockedContacts result = apiInstance.GetTransacBlockedContacts(startDate, endDate, limit, offset, senders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.GetTransacBlockedContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransacBlockedContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the list of blocked or unsubscribed transactional contacts
    ApiResponse<GetTransacBlockedContacts> response = apiInstance.GetTransacBlockedContactsWithHttpInfo(startDate, endDate, limit, offset, senders);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.GetTransacBlockedContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startDate** | **string** | Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the blocked or unsubscribed contacts | [optional]  |
| **endDate** | **string** | Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the blocked or unsubscribed contacts | [optional]  |
| **limit** | **long** | Number of documents returned per page | [optional] [default to 50] |
| **offset** | **long** | Index of the first document on the page | [optional] [default to 0] |
| **senders** | [**List&lt;string&gt;**](string.md) | Comma separated list of emails of the senders from which contacts are blocked or unsubscribed | [optional]  |

### Return type

[**GetTransacBlockedContacts**](GetTransacBlockedContacts.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of blocked or unsubscribed transactional contacts |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettransacemailcontent"></a>
# **GetTransacEmailContent**
> GetTransacEmailContent GetTransacEmailContent (string uuid)

Get the personalized content of a sent transactional email

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetTransacEmailContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var uuid = "uuid_example";  // string | Unique id of the transactional email that has been sent to a particular contact

            try
            {
                // Get the personalized content of a sent transactional email
                GetTransacEmailContent result = apiInstance.GetTransacEmailContent(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.GetTransacEmailContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransacEmailContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the personalized content of a sent transactional email
    ApiResponse<GetTransacEmailContent> response = apiInstance.GetTransacEmailContentWithHttpInfo(uuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.GetTransacEmailContentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** | Unique id of the transactional email that has been sent to a particular contact |  |

### Return type

[**GetTransacEmailContent**](GetTransacEmailContent.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transactional email content |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettransacemailslist"></a>
# **GetTransacEmailsList**
> GetTransacEmailsList GetTransacEmailsList (string email = null, long templateId = null, string messageId = null, DateOnly startDate = null, DateOnly endDate = null)

Get the list of transactional emails on the basis of allowed filters

This endpoint will show the list of emails for past 30 days by default. To retrieve emails before that time, please pass startDate and endDate in query filters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetTransacEmailsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var email = "email_example";  // string | Mandatory if templateId and messageId are not passed in query filters. Email address to which transactional email has been sent. (optional) 
            var templateId = 789L;  // long | Mandatory if email and messageId are not passed in query filters. Id of the template that was used to compose transactional email. (optional) 
            var messageId = "messageId_example";  // string | Mandatory if templateId and email are not passed in query filters. Message ID of the transactional email sent. (optional) 
            var startDate = DateOnly.Parse("2013-10-20");  // DateOnly | Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the list. Maximum time period that can be selected is one month. (optional) 
            var endDate = DateOnly.Parse("2013-10-20");  // DateOnly | Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the list. Maximum time period that can be selected is one month. (optional) 

            try
            {
                // Get the list of transactional emails on the basis of allowed filters
                GetTransacEmailsList result = apiInstance.GetTransacEmailsList(email, templateId, messageId, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.GetTransacEmailsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransacEmailsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the list of transactional emails on the basis of allowed filters
    ApiResponse<GetTransacEmailsList> response = apiInstance.GetTransacEmailsListWithHttpInfo(email, templateId, messageId, startDate, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.GetTransacEmailsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | Mandatory if templateId and messageId are not passed in query filters. Email address to which transactional email has been sent. | [optional]  |
| **templateId** | **long** | Mandatory if email and messageId are not passed in query filters. Id of the template that was used to compose transactional email. | [optional]  |
| **messageId** | **string** | Mandatory if templateId and email are not passed in query filters. Message ID of the transactional email sent. | [optional]  |
| **startDate** | **DateOnly** | Mandatory if endDate is used. Starting date (YYYY-MM-DD) from which you want to fetch the list. Maximum time period that can be selected is one month. | [optional]  |
| **endDate** | **DateOnly** | Mandatory if startDate is used. Ending date (YYYY-MM-DD) till which you want to fetch the list. Maximum time period that can be selected is one month. | [optional]  |

### Return type

[**GetTransacEmailsList**](GetTransacEmailsList.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of transactional emails |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendtemplate"></a>
# **SendTemplate**
> SendTemplateEmail SendTemplate (long templateId, SendEmail sendEmail)

Send a template

This endpoint is deprecated. Prefer v3/smtp/email instead.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class SendTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var templateId = 789L;  // long | Id of the template
            var sendEmail = new SendEmail(); // SendEmail | 

            try
            {
                // Send a template
                SendTemplateEmail result = apiInstance.SendTemplate(templateId, sendEmail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.SendTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a template
    ApiResponse<SendTemplateEmail> response = apiInstance.SendTemplateWithHttpInfo(templateId, sendEmail);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.SendTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **long** | Id of the template |  |
| **sendEmail** | [**SendEmail**](SendEmail.md) |  |  |

### Return type

[**SendTemplateEmail**](SendTemplateEmail.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Email has been sent successfully to all recipients |  -  |
| **400** | Email could not be sent to the following email addresses |  -  |
| **404** | Template ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendtesttemplate"></a>
# **SendTestTemplate**
> void SendTestTemplate (long templateId, SendTestEmail sendTestEmail)

Send a template to your test list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class SendTestTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var templateId = 789L;  // long | Id of the template
            var sendTestEmail = new SendTestEmail(); // SendTestEmail | 

            try
            {
                // Send a template to your test list
                apiInstance.SendTestTemplate(templateId, sendTestEmail);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.SendTestTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendTestTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a template to your test list
    apiInstance.SendTestTemplateWithHttpInfo(templateId, sendTestEmail);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.SendTestTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **long** | Id of the template |  |
| **sendTestEmail** | [**SendTestEmail**](SendTestEmail.md) |  |  |

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
| **404** | Template ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendtransacemail"></a>
# **SendTransacEmail**
> CreateSmtpEmail SendTransacEmail (SendSmtpEmail sendSmtpEmail)

Send a transactional email

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class SendTransacEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var sendSmtpEmail = new SendSmtpEmail(); // SendSmtpEmail | Values to send a transactional email

            try
            {
                // Send a transactional email
                CreateSmtpEmail result = apiInstance.SendTransacEmail(sendSmtpEmail);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.SendTransacEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendTransacEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a transactional email
    ApiResponse<CreateSmtpEmail> response = apiInstance.SendTransacEmailWithHttpInfo(sendSmtpEmail);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.SendTransacEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sendSmtpEmail** | [**SendSmtpEmail**](SendSmtpEmail.md) | Values to send a transactional email |  |

### Return type

[**CreateSmtpEmail**](CreateSmtpEmail.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | transactional email sent |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="smtpblockedcontactsemaildelete"></a>
# **SmtpBlockedContactsEmailDelete**
> void SmtpBlockedContactsEmailDelete (string email)

Unblock or resubscribe a transactional contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class SmtpBlockedContactsEmailDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var email = "email_example";  // string | contact email (urlencoded) to unblock.

            try
            {
                // Unblock or resubscribe a transactional contact
                apiInstance.SmtpBlockedContactsEmailDelete(email);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.SmtpBlockedContactsEmailDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmtpBlockedContactsEmailDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unblock or resubscribe a transactional contact
    apiInstance.SmtpBlockedContactsEmailDeleteWithHttpInfo(email);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.SmtpBlockedContactsEmailDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | contact email (urlencoded) to unblock. |  |

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
| **204** | Contact unblocked |  -  |
| **400** | bad request |  -  |
| **404** | Contact email not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="smtplogmessageiddelete"></a>
# **SmtpLogMessageIdDelete**
> void SmtpLogMessageIdDelete (string messageId)

Delete an SMTP transactional log

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class SmtpLogMessageIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var messageId = "messageId_example";  // string | MessageId of the transactional log to delete

            try
            {
                // Delete an SMTP transactional log
                apiInstance.SmtpLogMessageIdDelete(messageId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.SmtpLogMessageIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmtpLogMessageIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an SMTP transactional log
    apiInstance.SmtpLogMessageIdDeleteWithHttpInfo(messageId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.SmtpLogMessageIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** | MessageId of the transactional log to delete |  |

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
| **204** | Transactional Logs deleted |  -  |
| **404** | Message ID not found |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatesmtptemplate"></a>
# **UpdateSmtpTemplate**
> void UpdateSmtpTemplate (long templateId, UpdateSmtpTemplate smtpTemplate)

Update an email template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class UpdateSmtpTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new SMTPApi(config);
            var templateId = 789L;  // long | id of the template
            var smtpTemplate = new UpdateSmtpTemplate(); // UpdateSmtpTemplate | values to update in transactional email template

            try
            {
                // Update an email template
                apiInstance.UpdateSmtpTemplate(templateId, smtpTemplate);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPApi.UpdateSmtpTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSmtpTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an email template
    apiInstance.UpdateSmtpTemplateWithHttpInfo(templateId, smtpTemplate);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPApi.UpdateSmtpTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **long** | id of the template |  |
| **smtpTemplate** | [**UpdateSmtpTemplate**](UpdateSmtpTemplate.md) | values to update in transactional email template |  |

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
| **204** | transactional email template updated |  -  |
| **400** | bad request |  -  |
| **404** | Template ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

