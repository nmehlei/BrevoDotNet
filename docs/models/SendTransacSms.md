# BrevoDotNet.Model.SendTransacSms

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sender** | **string** | Name of the sender. **The number of characters is limited to 11 for alphanumeric characters and 15 for numeric characters** | 
**Recipient** | **string** | Mobile number to send SMS with the country code | 
**Content** | **string** | Content of the message. If more than 160 characters long, will be sent as multiple text messages | 
**Type** | **string** | Type of the SMS. Marketing SMS messages are those sent typically with marketing content. Transactional SMS messages are sent to individuals and are triggered in response to some action, such as a sign-up, purchase, etc. | [optional] [default to TypeEnum.Transactional]
**Tag** | **string** | Tag of the message | [optional] 
**WebUrl** | **string** | Webhook to call for each event triggered by the message (delivered etc.) | [optional] 
**OrganisationPrefix** | **string** | A recognizable prefix will ensure your audience knows who you are.**Mandatory for U.S. Carriers**.This will be added as your Brand Name before the message content and will be included in content,**Prefer to verify maximum length of 160 characters including this prefix to avoid multiple sending of same sms**. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

