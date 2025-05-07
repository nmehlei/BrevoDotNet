# BrevoDotNet.Model.GetContactDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | ID of the contact for which you requested the details | 
**EmailBlacklisted** | **bool** | Blacklist status for email campaigns (true&#x3D;blacklisted, false&#x3D;not blacklisted) | 
**SmsBlacklisted** | **bool** | Blacklist status for SMS campaigns (true&#x3D;blacklisted, false&#x3D;not blacklisted) | 
**CreatedAt** | **DateTime** | Creation UTC date-time of the contact (YYYY-MM-DDTHH:mm:ss.SSSZ) | 
**ModifiedAt** | **DateTime** | Last modification UTC date-time of the contact (YYYY-MM-DDTHH:mm:ss.SSSZ) | 
**ListIds** | **List&lt;long&gt;** |  | 
**Attributes** | **Object** | Set of attributes of the contact | 
**Email** | **string** | Email address of the contact for which you requested the details | [optional] 
**ListUnsubscribed** | **List&lt;long&gt;** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

