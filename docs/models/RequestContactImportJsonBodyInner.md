# BrevoDotNet.Model.RequestContactImportJsonBodyInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** |  | [optional] 
**Attributes** | **Dictionary&lt;string, Object&gt;** | List of attributes to be imported. Example for all attribute types parsing. - For text type attribute \&quot;attributes\&quot;: {\&quot;FNAME\&quot; : \&quot;John\&quot;} - For date type attribute \&quot;attributes\&quot;: {\&quot;BIRTHDAY\&quot; : \&quot;1989-11-02\&quot;} - For Number type attribute \&quot;attributes\&quot;: {\&quot;AGE\&quot; : 26} - For boolean type attribute \&quot;attributes\&quot;: {\&quot;IS_MARRIED\&quot; : \&quot;yes\&quot;} // no if false. - For category type attribute \&quot;attributes\&quot;: {\&quot;COUNTRY\&quot; : \&quot;DE\&quot;} - For multiselect type attribute \&quot;attributes\&quot;: {\&quot;PREFERED_COLOR\&quot; : [\&quot;BLACK\&quot;, \&quot;WHITE\&quot;]}  - For user type attribute \&quot;attributes\&quot;: {\&quot;OWNER\&quot; : \&quot;test@brevo.com\&quot;}  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

