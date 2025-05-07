# BrevoDotNet.Api.AttributesApi

All URIs are relative to *https://api.sendinblue.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAttribute**](AttributesApi.md#createattribute) | **POST** /contacts/attributes/{attributeCategory}/{attributeName} | Create contact attribute |
| [**DeleteAttribute**](AttributesApi.md#deleteattribute) | **DELETE** /contacts/attributes/{attributeCategory}/{attributeName} | Delete an attribute |
| [**GetAttributes**](AttributesApi.md#getattributes) | **GET** /contacts/attributes | List all attributes |
| [**UpdateAttribute**](AttributesApi.md#updateattribute) | **PUT** /contacts/attributes/{attributeCategory}/{attributeName} | Update contact attribute |

<a id="createattribute"></a>
# **CreateAttribute**
> void CreateAttribute (string attributeCategory, string attributeName, CreateAttribute createAttribute)

Create contact attribute

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class CreateAttributeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new AttributesApi(config);
            var attributeCategory = "normal";  // string | Category of the attribute
            var attributeName = "attributeName_example";  // string | Name of the attribute
            var createAttribute = new CreateAttribute(); // CreateAttribute | Values to create an attribute

            try
            {
                // Create contact attribute
                apiInstance.CreateAttribute(attributeCategory, attributeName, createAttribute);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributesApi.CreateAttribute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAttributeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create contact attribute
    apiInstance.CreateAttributeWithHttpInfo(attributeCategory, attributeName, createAttribute);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributesApi.CreateAttributeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **attributeCategory** | **string** | Category of the attribute |  |
| **attributeName** | **string** | Name of the attribute |  |
| **createAttribute** | [**CreateAttribute**](CreateAttribute.md) | Values to create an attribute |  |

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
| **201** | Attribute created |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteattribute"></a>
# **DeleteAttribute**
> void DeleteAttribute (string attributeCategory, string attributeName)

Delete an attribute

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class DeleteAttributeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new AttributesApi(config);
            var attributeCategory = "normal";  // string | Category of the attribute
            var attributeName = "attributeName_example";  // string | Name of the existing attribute

            try
            {
                // Delete an attribute
                apiInstance.DeleteAttribute(attributeCategory, attributeName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributesApi.DeleteAttribute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAttributeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an attribute
    apiInstance.DeleteAttributeWithHttpInfo(attributeCategory, attributeName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributesApi.DeleteAttributeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **attributeCategory** | **string** | Category of the attribute |  |
| **attributeName** | **string** | Name of the existing attribute |  |

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
| **204** | Attribute deleted |  -  |
| **404** | Attribute not found |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getattributes"></a>
# **GetAttributes**
> GetAttributes GetAttributes ()

List all attributes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetAttributesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new AttributesApi(config);

            try
            {
                // List all attributes
                GetAttributes result = apiInstance.GetAttributes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributesApi.GetAttributes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAttributesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all attributes
    ApiResponse<GetAttributes> response = apiInstance.GetAttributesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributesApi.GetAttributesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetAttributes**](GetAttributes.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Attributes listed |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateattribute"></a>
# **UpdateAttribute**
> void UpdateAttribute (string attributeCategory, string attributeName, UpdateAttribute updateAttribute)

Update contact attribute

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class UpdateAttributeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new AttributesApi(config);
            var attributeCategory = "category";  // string | Category of the attribute
            var attributeName = "attributeName_example";  // string | Name of the existing attribute
            var updateAttribute = new UpdateAttribute(); // UpdateAttribute | Values to update an attribute

            try
            {
                // Update contact attribute
                apiInstance.UpdateAttribute(attributeCategory, attributeName, updateAttribute);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttributesApi.UpdateAttribute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAttributeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update contact attribute
    apiInstance.UpdateAttributeWithHttpInfo(attributeCategory, attributeName, updateAttribute);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttributesApi.UpdateAttributeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **attributeCategory** | **string** | Category of the attribute |  |
| **attributeName** | **string** | Name of the existing attribute |  |
| **updateAttribute** | [**UpdateAttribute**](UpdateAttribute.md) | Values to update an attribute |  |

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
| **204** | Attribute updated |  -  |
| **400** | bad request |  -  |
| **404** | Attribute not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

