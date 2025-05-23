# BrevoDotNet.Model.SendSmtpEmail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**To** | [**List&lt;SendSmtpEmailToInner&gt;**](SendSmtpEmailToInner.md) | List of email addresses and names (optional) of the recipients. For example, [{\&quot;name\&quot;:\&quot;Jimmy\&quot;, \&quot;email\&quot;:\&quot;jimmy98@example.com\&quot;}, {\&quot;name\&quot;:\&quot;Joe\&quot;, \&quot;email\&quot;:\&quot;joe@example.com\&quot;}] | 
**Sender** | [**SendSmtpEmailSender**](SendSmtpEmailSender.md) |  | [optional] 
**Bcc** | [**List&lt;SendSmtpEmailBccInner&gt;**](SendSmtpEmailBccInner.md) | List of email addresses and names (optional) of the recipients in bcc | [optional] 
**Cc** | [**List&lt;SendSmtpEmailCcInner&gt;**](SendSmtpEmailCcInner.md) | List of email addresses and names (optional) of the recipients in cc | [optional] 
**HtmlContent** | **string** | HTML body of the message ( Mandatory if &#39;templateId&#39; is not passed, ignored if &#39;templateId&#39; is passed ) | [optional] 
**TextContent** | **string** | Plain Text body of the message ( Ignored if &#39;templateId&#39; is passed ) | [optional] 
**Subject** | **string** | Subject of the message. Mandatory if &#39;templateId&#39; is not passed | [optional] 
**ReplyTo** | [**SendSmtpEmailReplyTo**](SendSmtpEmailReplyTo.md) |  | [optional] 
**Attachment** | [**List&lt;SendSmtpEmailAttachmentInner&gt;**](SendSmtpEmailAttachmentInner.md) | Pass the absolute URL (no local file) or the base64 content of the attachment along with the attachment name (Mandatory if attachment content is passed). For example, &#x60;[{\&quot;url\&quot;:\&quot;https://attachment.domain.com/myAttachmentFromUrl.jpg\&quot;, \&quot;name\&quot;:\&quot;myAttachmentFromUrl.jpg\&quot;}, {\&quot;content\&quot;:\&quot;base64 example content\&quot;, \&quot;name\&quot;:\&quot;myAttachmentFromBase64.jpg\&quot;}]&#x60;. Allowed extensions for attachment file: xlsx, xls, ods, docx, docm, doc, csv, pdf, txt, gif, jpg, jpeg, png, tif, tiff, rtf, bmp, cgm, css, shtml, html, htm, zip, xml, ppt, pptx, tar, ez, ics, mobi, msg, pub, eps, odt, mp3, m4a, m4v, wma, ogg, flac, wav, aif, aifc, aiff, mp4, mov, avi, mkv, mpeg, mpg and wmv ( If &#39;templateId&#39; is passed and is in New Template Language format then both attachment url and content are accepted. If template is in Old template Language format, then &#39;attachment&#39; is ignored ) | [optional] 
**Headers** | **Object** | Pass the set of custom headers (not the standard headers) that shall be sent along the mail headers in the original email. &#39;sender.ip&#39; header can be set (only for dedicated ip users) to mention the IP to be used for sending transactional emails. Headers are allowed in &#x60;This-Case-Only&#x60; (i.e. words separated by hyphen with first letter of each word in capital letter), they will be converted to such case styling if not in this format in the request payload. For example, &#x60;{\&quot;sender.ip\&quot;:\&quot;1.2.3.4\&quot;, \&quot;X-Mailin-custom\&quot;:\&quot;some_custom_header\&quot;, \&quot;idempotencyKey\&quot;:\&quot;abc-123\&quot;}&#x60;. | [optional] 
**TemplateId** | **long** | Id of the template | [optional] 
**Params** | **Object** | Pass the set of attributes to customize the template. For example, {\&quot;FNAME\&quot;:\&quot;Joe\&quot;, \&quot;LNAME\&quot;:\&quot;Doe\&quot;}. It&#39;s considered only if template is in New Template Language format. | [optional] 
**Tags** | **List&lt;string&gt;** | Tag your emails to find them more easily | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

