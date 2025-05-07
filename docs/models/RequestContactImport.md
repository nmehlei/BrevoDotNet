# BrevoDotNet.Model.RequestContactImport

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileUrl** | **string** | Mandatory if fileBody is not defined. URL of the file to be imported (no local file). Possible file formats: .txt, .csv | [optional] 
**FileBody** | **string** | Mandatory if fileUrl is not defined. CSV content to be imported. Use semicolon to separate multiple attributes. Maximum allowed file body size is 10MB . However we recommend a safe limit of around 8 MB to avoid the issues caused due to increase of file body size while parsing. Please use fileUrl instead to import bigger files. | [optional] 
**JsonBody** | [**List&lt;RequestContactImportJsonBodyInner&gt;**](RequestContactImportJsonBodyInner.md) | **Mandatory if fileUrl and fileBody is not defined.** JSON content to be imported. **Maximum allowed json body size is 10MB** . However we recommend a safe limit of around 8 MB to avoid the issues caused due to increase of json body size while parsing. Please use fileUrl instead to import bigger files.  | [optional] 
**ListIds** | **List&lt;long&gt;** | Mandatory if newList is not defined. Ids of the lists in which the contacts shall be imported. For example, [2, 4, 7]. | [optional] 
**NotifyUrl** | **string** | URL that will be called once the import process is finished. For reference, https://help.sendinblue.com/hc/en-us/articles/360007666479 | [optional] 
**NewList** | [**RequestContactImportNewList**](RequestContactImportNewList.md) |  | [optional] 
**EmailBlacklist** | **bool** | To blacklist all the contacts for email | [optional] [default to false]
**AllowExport** | **bool** | To enable allow export. if allow export will be true, we will save import_process_ids [12, 13, 14] in the users metadata | [optional] [default to false]
**DisableNotification** | **bool** | To disable email notification | [optional] [default to false]
**DisableFrontendNotification** | **bool** | To disable frontend notification | [optional] [default to false]
**SmsBlacklist** | **bool** | To blacklist all the contacts for sms | [optional] [default to false]
**UpdateExistingContacts** | **bool** | To facilitate the choice to update the existing contacts | [optional] [default to true]
**EmptyContactsAttributes** | **bool** | To facilitate the choice to erase any attribute of the existing contacts with empty value. emptyContactsAttributes &#x3D; true means the empty fields in your import will erase any attribute that currently contain data in SendinBlue, &amp; emptyContactsAttributes &#x3D; false means the empty fields will not affect your existing data ( only available if &#x60;updateExistingContacts&#x60; set to true ) | [optional] [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

