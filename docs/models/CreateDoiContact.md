# BrevoDotNet.Model.CreateDoiContact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | Email address where the confirmation email will be sent. This email address will be the identifier for all other contact attributes. | 
**IncludeListIds** | **List&lt;long&gt;** | Lists under user account where contact should be added | 
**TemplateId** | **long** | Id of the Double opt-in (DOI) template | 
**RedirectionUrl** | **string** | URL of the web page that user will be redirected to after clicking on the double opt in URL. When editing your DOI template you can reference this URL by using the tag {{ params.DOIurl }}. | 
**Attributes** | **Object** | Pass the set of attributes and their values. These attributes must be present in your SendinBlue account. For eg. {&#39;FNAME&#39;:&#39;Elly&#39;, &#39;LNAME&#39;:&#39;Roger&#39;} | [optional] 
**ExcludeListIds** | **List&lt;long&gt;** | Lists under user account where contact should not be added | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

