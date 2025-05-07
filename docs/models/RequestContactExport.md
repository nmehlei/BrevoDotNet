# BrevoDotNet.Model.RequestContactExport

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExportAttributes** | **List&lt;string&gt;** | List of all the attributes that you want to export. These attributes must be present in your contact database. For example, [&#39;fname&#39;, &#39;lname&#39;, &#39;email&#39;, &#39;CONTACT ID&#39;]. | [optional] 
**ContactFilter** | **Object** | This attribute has been deprecated and will be removed by January 1st, 2021. Only one of the two filter options (contactFilter or customContactFilter) can be passed in the request. Set the filter for the contacts to be exported. For example, {\&quot;blacklisted\&quot;:true} will export all the blacklisted contacts.  | [optional] 
**CustomContactFilter** | [**RequestContactExportCustomContactFilter**](RequestContactExportCustomContactFilter.md) |  | [optional] 
**NotifyUrl** | **string** | Webhook that will be called once the export process is finished. For reference, https://help.sendinblue.com/hc/en-us/articles/360007666479 | [optional] 
**SkipFilesMerge** | **bool** | To stop merging the file into single file | [optional] [default to false]
**DisableNotification** | **bool** | To disable email notification | [optional] [default to false]
**DisableFrontendNotification** | **bool** | To disable frontend notification | [optional] [default to false]
**ExportMandatoryAttributes** | **bool** | To export mandatory attributes like EMAIL, ADDED_TIME, MODIFIED_TIME | [optional] [default to true]
**ExportSubscriptionStatus** | **List&lt;string&gt;** | Export subscription status of contacts for email &amp; sms marketting. Pass email_marketing to obtain the marketing email subscription status &amp; sms_marketing to retrieve the marketing SMS status of the contact. | [optional] 
**ExportMetadata** | **List&lt;string&gt;** | Export metadata of contacts such as _listIds, ADDED_TIME, MODIFIED_TIME. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

