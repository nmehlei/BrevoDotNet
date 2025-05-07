# BrevoDotNet.Model.GetExtendedCampaignStats

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GlobalStats** | [**GetCampaignStats**](GetCampaignStats.md) | Overall statistics of the campaign | 
**CampaignStats** | [**List&lt;GetCampaignStats&gt;**](GetCampaignStats.md) | List-wise statistics of the campaign. | 
**MirrorClick** | **long** | Number of clicks on mirror link | 
**Remaining** | **long** | Number of remaning emails to send | 
**LinksStats** | **Object** | Statistics about the number of clicks for the links | 
**StatsByDomain** | [**Dictionary&lt;string, GetCampaignStats&gt;**](GetCampaignStats.md) |  | 
**StatsByDevice** | [**GetStatsByDevice**](GetStatsByDevice.md) |  | 
**StatsByBrowser** | [**Dictionary&lt;string, GetDeviceBrowserStats&gt;**](GetDeviceBrowserStats.md) |  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

