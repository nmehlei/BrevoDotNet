# BrevoDotNet.Model.UpdateSmtpTemplateSender
Sender details including id or email and name (optional). Only one of either Sender's email or Sender's ID shall be passed in one request at a time. For example `{\"name\":\"xyz\", \"email\":\"example@abc.com\"}` , `{\"name\":\"xyz\", \"id\":123}`

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the sender | [optional] 
**Email** | **string** | Email of the sender | [optional] 
**Id** | **long** | Select the sender for the template on the basis of sender id. In order to select a sender with specific pool of IP’s, dedicated ip users shall pass id (instead of email). | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

