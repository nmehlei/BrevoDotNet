# BrevoDotNet.Api.FoldersApi

All URIs are relative to *https://api.sendinblue.com/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateFolder**](FoldersApi.md#createfolder) | **POST** /contacts/folders | Create a folder |
| [**DeleteFolder**](FoldersApi.md#deletefolder) | **DELETE** /contacts/folders/{folderId} | Delete a folder (and all its lists) |
| [**GetFolder**](FoldersApi.md#getfolder) | **GET** /contacts/folders/{folderId} | Returns a folder&#39;s details |
| [**GetFolderLists**](FoldersApi.md#getfolderlists) | **GET** /contacts/folders/{folderId}/lists | Get lists in a folder |
| [**GetFolders**](FoldersApi.md#getfolders) | **GET** /contacts/folders | Get all folders |
| [**UpdateFolder**](FoldersApi.md#updatefolder) | **PUT** /contacts/folders/{folderId} | Update a folder |

<a id="createfolder"></a>
# **CreateFolder**
> CreateModel CreateFolder (CreateUpdateFolder createFolder)

Create a folder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class CreateFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new FoldersApi(config);
            var createFolder = new CreateUpdateFolder(); // CreateUpdateFolder | Name of the folder

            try
            {
                // Create a folder
                CreateModel result = apiInstance.CreateFolder(createFolder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.CreateFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a folder
    ApiResponse<CreateModel> response = apiInstance.CreateFolderWithHttpInfo(createFolder);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.CreateFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createFolder** | [**CreateUpdateFolder**](CreateUpdateFolder.md) | Name of the folder |  |

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
| **201** | Folder created |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletefolder"></a>
# **DeleteFolder**
> void DeleteFolder (long folderId)

Delete a folder (and all its lists)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class DeleteFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new FoldersApi(config);
            var folderId = 789L;  // long | Id of the folder

            try
            {
                // Delete a folder (and all its lists)
                apiInstance.DeleteFolder(folderId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.DeleteFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a folder (and all its lists)
    apiInstance.DeleteFolderWithHttpInfo(folderId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.DeleteFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **long** | Id of the folder |  |

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
| **204** | Folder deleted |  -  |
| **404** | Folder ID not found |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfolder"></a>
# **GetFolder**
> GetFolder GetFolder (long folderId)

Returns a folder's details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new FoldersApi(config);
            var folderId = 789L;  // long | id of the folder

            try
            {
                // Returns a folder's details
                GetFolder result = apiInstance.GetFolder(folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a folder's details
    ApiResponse<GetFolder> response = apiInstance.GetFolderWithHttpInfo(folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **long** | id of the folder |  |

### Return type

[**GetFolder**](GetFolder.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Folder details |  -  |
| **404** | Folder ID not found |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfolderlists"></a>
# **GetFolderLists**
> GetFolderLists GetFolderLists (long folderId, long limit = null, long offset = null, string sort = null)

Get lists in a folder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetFolderListsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new FoldersApi(config);
            var folderId = 789L;  // long | Id of the folder
            var limit = 10L;  // long | Number of documents per page (optional)  (default to 10)
            var offset = 0L;  // long | Index of the first document of the page (optional)  (default to 0)
            var sort = "asc";  // string | Sort the results in the ascending/descending order of record creation (optional)  (default to desc)

            try
            {
                // Get lists in a folder
                GetFolderLists result = apiInstance.GetFolderLists(folderId, limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolderLists: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFolderListsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get lists in a folder
    ApiResponse<GetFolderLists> response = apiInstance.GetFolderListsWithHttpInfo(folderId, limit, offset, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetFolderListsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **long** | Id of the folder |  |
| **limit** | **long** | Number of documents per page | [optional] [default to 10] |
| **offset** | **long** | Index of the first document of the page | [optional] [default to 0] |
| **sort** | **string** | Sort the results in the ascending/descending order of record creation | [optional] [default to desc] |

### Return type

[**GetFolderLists**](GetFolderLists.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Folder&#39;s Lists details |  -  |
| **404** | Folder ID not found |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfolders"></a>
# **GetFolders**
> GetFolders GetFolders (long limit, long offset, string sort = null)

Get all folders

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class GetFoldersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new FoldersApi(config);
            var limit = 10L;  // long | Number of documents per page (default to 10)
            var offset = 0L;  // long | Index of the first document of the page (default to 0)
            var sort = "asc";  // string | Sort the results in the ascending/descending order of record creation (optional)  (default to desc)

            try
            {
                // Get all folders
                GetFolders result = apiInstance.GetFolders(limit, offset, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFoldersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all folders
    ApiResponse<GetFolders> response = apiInstance.GetFoldersWithHttpInfo(limit, offset, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetFoldersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **long** | Number of documents per page | [default to 10] |
| **offset** | **long** | Index of the first document of the page | [default to 0] |
| **sort** | **string** | Sort the results in the ascending/descending order of record creation | [optional] [default to desc] |

### Return type

[**GetFolders**](GetFolders.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Folders informations |  -  |
| **400** | bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatefolder"></a>
# **UpdateFolder**
> void UpdateFolder (long folderId, CreateUpdateFolder updateFolder)

Update a folder

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using BrevoDotNet.Model;

namespace Example
{
    public class UpdateFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.sendinblue.com/v3";
            // Configure API key authorization: api-key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new FoldersApi(config);
            var folderId = 789L;  // long | Id of the folder
            var updateFolder = new CreateUpdateFolder(); // CreateUpdateFolder | Name of the folder

            try
            {
                // Update a folder
                apiInstance.UpdateFolder(folderId, updateFolder);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.UpdateFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a folder
    apiInstance.UpdateFolderWithHttpInfo(folderId, updateFolder);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.UpdateFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **long** | Id of the folder |  |
| **updateFolder** | [**CreateUpdateFolder**](CreateUpdateFolder.md) | Name of the folder |  |

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
| **204** | Folder updated |  -  |
| **400** | bad request |  -  |
| **404** | Folder ID not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

