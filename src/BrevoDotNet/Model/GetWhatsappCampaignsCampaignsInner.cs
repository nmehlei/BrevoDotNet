// <auto-generated>
/*
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  |   | 406  | Error. Not Acceptable  | 
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: contact@sendinblue.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using BrevoDotNet.Client;

namespace BrevoDotNet.Model
{
    /// <summary>
    /// GetWhatsappCampaignsCampaignsInner
    /// </summary>
    public partial class GetWhatsappCampaignsCampaignsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWhatsappCampaignsCampaignsInner" /> class.
        /// </summary>
        /// <param name="id">ID of the WhatsApp Campaign</param>
        /// <param name="campaignName">Name of the WhatsApp Campaign</param>
        /// <param name="templateId">Id of the WhatsApp template</param>
        /// <param name="campaignStatus">Status of the WhatsApp Campaign</param>
        /// <param name="scheduledAt">UTC date-time on which WhatsApp campaign is scheduled. Should be in YYYY-MM-DDTHH:mm:ss.SSSZ format</param>
        /// <param name="createdAt">Creation UTC date-time of the WhatsApp campaign (YYYY-MM-DDTHH:mm:ss.SSSZ)</param>
        /// <param name="modifiedAt">UTC date-time of last modification of the whatsApp template (YYYY-MM-DDTHH:mm:ss.SSSZ)</param>
        /// <param name="errorReason">Error reason in the campaign creation</param>
        /// <param name="invalidatedContacts">Count of invalidated contacts</param>
        /// <param name="readPercentage">Read percentage of the the WhatsApp campaign created</param>
        /// <param name="stats">stats</param>
        [JsonConstructor]
        public GetWhatsappCampaignsCampaignsInner(long id, string campaignName, string templateId, CampaignStatusEnum campaignStatus, string scheduledAt, string createdAt, string modifiedAt, Option<string?> errorReason = default, Option<long?> invalidatedContacts = default, Option<float?> readPercentage = default, Option<WhatsappCampStats?> stats = default)
        {
            Id = id;
            CampaignName = campaignName;
            TemplateId = templateId;
            CampaignStatus = campaignStatus;
            ScheduledAt = scheduledAt;
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            ErrorReasonOption = errorReason;
            InvalidatedContactsOption = invalidatedContacts;
            ReadPercentageOption = readPercentage;
            StatsOption = stats;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Status of the WhatsApp Campaign
        /// </summary>
        /// <value>Status of the WhatsApp Campaign</value>
        public enum CampaignStatusEnum
        {
            /// <summary>
            /// Enum Draft for value: draft
            /// </summary>
            Draft = 1,

            /// <summary>
            /// Enum Scheduled for value: scheduled
            /// </summary>
            Scheduled = 2,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            Pending = 3,

            /// <summary>
            /// Enum Approved for value: approved
            /// </summary>
            Approved = 4,

            /// <summary>
            /// Enum Running for value: running
            /// </summary>
            Running = 5,

            /// <summary>
            /// Enum Suspended for value: suspended
            /// </summary>
            Suspended = 6,

            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            Rejected = 7,

            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            Sent = 8
        }

        /// <summary>
        /// Returns a <see cref="CampaignStatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static CampaignStatusEnum CampaignStatusEnumFromString(string value)
        {
            if (value.Equals("draft"))
                return CampaignStatusEnum.Draft;

            if (value.Equals("scheduled"))
                return CampaignStatusEnum.Scheduled;

            if (value.Equals("pending"))
                return CampaignStatusEnum.Pending;

            if (value.Equals("approved"))
                return CampaignStatusEnum.Approved;

            if (value.Equals("running"))
                return CampaignStatusEnum.Running;

            if (value.Equals("suspended"))
                return CampaignStatusEnum.Suspended;

            if (value.Equals("rejected"))
                return CampaignStatusEnum.Rejected;

            if (value.Equals("sent"))
                return CampaignStatusEnum.Sent;

            throw new NotImplementedException($"Could not convert value to type CampaignStatusEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="CampaignStatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CampaignStatusEnum? CampaignStatusEnumFromStringOrDefault(string value)
        {
            if (value.Equals("draft"))
                return CampaignStatusEnum.Draft;

            if (value.Equals("scheduled"))
                return CampaignStatusEnum.Scheduled;

            if (value.Equals("pending"))
                return CampaignStatusEnum.Pending;

            if (value.Equals("approved"))
                return CampaignStatusEnum.Approved;

            if (value.Equals("running"))
                return CampaignStatusEnum.Running;

            if (value.Equals("suspended"))
                return CampaignStatusEnum.Suspended;

            if (value.Equals("rejected"))
                return CampaignStatusEnum.Rejected;

            if (value.Equals("sent"))
                return CampaignStatusEnum.Sent;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="CampaignStatusEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string CampaignStatusEnumToJsonValue(CampaignStatusEnum value)
        {
            if (value == CampaignStatusEnum.Draft)
                return "draft";

            if (value == CampaignStatusEnum.Scheduled)
                return "scheduled";

            if (value == CampaignStatusEnum.Pending)
                return "pending";

            if (value == CampaignStatusEnum.Approved)
                return "approved";

            if (value == CampaignStatusEnum.Running)
                return "running";

            if (value == CampaignStatusEnum.Suspended)
                return "suspended";

            if (value == CampaignStatusEnum.Rejected)
                return "rejected";

            if (value == CampaignStatusEnum.Sent)
                return "sent";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Status of the WhatsApp Campaign
        /// </summary>
        /// <value>Status of the WhatsApp Campaign</value>
        /* <example>draft</example> */
        [JsonPropertyName("campaignStatus")]
        public CampaignStatusEnum CampaignStatus { get; set; }

        /// <summary>
        /// ID of the WhatsApp Campaign
        /// </summary>
        /// <value>ID of the WhatsApp Campaign</value>
        /* <example>1672035851100690</example> */
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Name of the WhatsApp Campaign
        /// </summary>
        /// <value>Name of the WhatsApp Campaign</value>
        /* <example>Test Campaign</example> */
        [JsonPropertyName("campaignName")]
        public string CampaignName { get; set; }

        /// <summary>
        /// Id of the WhatsApp template
        /// </summary>
        /// <value>Id of the WhatsApp template</value>
        /* <example>637660278078655</example> */
        [JsonPropertyName("templateId")]
        public string TemplateId { get; set; }

        /// <summary>
        /// UTC date-time on which WhatsApp campaign is scheduled. Should be in YYYY-MM-DDTHH:mm:ss.SSSZ format
        /// </summary>
        /// <value>UTC date-time on which WhatsApp campaign is scheduled. Should be in YYYY-MM-DDTHH:mm:ss.SSSZ format</value>
        /* <example>2017-06-01T12:30:00Z</example> */
        [JsonPropertyName("scheduledAt")]
        public string ScheduledAt { get; set; }

        /// <summary>
        /// Creation UTC date-time of the WhatsApp campaign (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>Creation UTC date-time of the WhatsApp campaign (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        /* <example>2017-06-01T12:30:00Z</example> */
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// UTC date-time of last modification of the whatsApp template (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>UTC date-time of last modification of the whatsApp template (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        /* <example>2017-05-01T12:30:00Z</example> */
        [JsonPropertyName("modifiedAt")]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// Used to track the state of ErrorReason
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ErrorReasonOption { get; private set; }

        /// <summary>
        /// Error reason in the campaign creation
        /// </summary>
        /// <value>Error reason in the campaign creation</value>
        /* <example>NONE</example> */
        [JsonPropertyName("errorReason")]
        public string? ErrorReason { get { return this.ErrorReasonOption; } set { this.ErrorReasonOption = new(value); } }

        /// <summary>
        /// Used to track the state of InvalidatedContacts
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> InvalidatedContactsOption { get; private set; }

        /// <summary>
        /// Count of invalidated contacts
        /// </summary>
        /// <value>Count of invalidated contacts</value>
        /* <example>0</example> */
        [JsonPropertyName("invalidatedContacts")]
        public long? InvalidatedContacts { get { return this.InvalidatedContactsOption; } set { this.InvalidatedContactsOption = new(value); } }

        /// <summary>
        /// Used to track the state of ReadPercentage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<float?> ReadPercentageOption { get; private set; }

        /// <summary>
        /// Read percentage of the the WhatsApp campaign created
        /// </summary>
        /// <value>Read percentage of the the WhatsApp campaign created</value>
        /* <example>28.57</example> */
        [JsonPropertyName("readPercentage")]
        public float? ReadPercentage { get { return this.ReadPercentageOption; } set { this.ReadPercentageOption = new(value); } }

        /// <summary>
        /// Used to track the state of Stats
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<WhatsappCampStats?> StatsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [JsonPropertyName("stats")]
        public WhatsappCampStats? Stats { get { return this.StatsOption; } set { this.StatsOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetWhatsappCampaignsCampaignsInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CampaignName: ").Append(CampaignName).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  CampaignStatus: ").Append(CampaignStatus).Append("\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  ErrorReason: ").Append(ErrorReason).Append("\n");
            sb.Append("  InvalidatedContacts: ").Append(InvalidatedContacts).Append("\n");
            sb.Append("  ReadPercentage: ").Append(ReadPercentage).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="GetWhatsappCampaignsCampaignsInner" />
    /// </summary>
    public class GetWhatsappCampaignsCampaignsInnerJsonConverter : JsonConverter<GetWhatsappCampaignsCampaignsInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetWhatsappCampaignsCampaignsInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetWhatsappCampaignsCampaignsInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> id = default;
            Option<string?> campaignName = default;
            Option<string?> templateId = default;
            Option<GetWhatsappCampaignsCampaignsInner.CampaignStatusEnum?> campaignStatus = default;
            Option<string?> scheduledAt = default;
            Option<string?> createdAt = default;
            Option<string?> modifiedAt = default;
            Option<string?> errorReason = default;
            Option<long?> invalidatedContacts = default;
            Option<float?> readPercentage = default;
            Option<WhatsappCampStats?> stats = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "id":
                            id = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "campaignName":
                            campaignName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "templateId":
                            templateId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "campaignStatus":
                            string? campaignStatusRawValue = utf8JsonReader.GetString();
                            if (campaignStatusRawValue != null)
                                campaignStatus = new Option<GetWhatsappCampaignsCampaignsInner.CampaignStatusEnum?>(GetWhatsappCampaignsCampaignsInner.CampaignStatusEnumFromStringOrDefault(campaignStatusRawValue));
                            break;
                        case "scheduledAt":
                            scheduledAt = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "createdAt":
                            createdAt = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "modifiedAt":
                            modifiedAt = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "errorReason":
                            errorReason = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "invalidatedContacts":
                            invalidatedContacts = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "readPercentage":
                            readPercentage = new Option<float?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (float?)null : (float)utf8JsonReader.GetDouble());
                            break;
                        case "stats":
                            stats = new Option<WhatsappCampStats?>(JsonSerializer.Deserialize<WhatsappCampStats>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class GetWhatsappCampaignsCampaignsInner.", nameof(id));

            if (!campaignName.IsSet)
                throw new ArgumentException("Property is required for class GetWhatsappCampaignsCampaignsInner.", nameof(campaignName));

            if (!templateId.IsSet)
                throw new ArgumentException("Property is required for class GetWhatsappCampaignsCampaignsInner.", nameof(templateId));

            if (!campaignStatus.IsSet)
                throw new ArgumentException("Property is required for class GetWhatsappCampaignsCampaignsInner.", nameof(campaignStatus));

            if (!scheduledAt.IsSet)
                throw new ArgumentException("Property is required for class GetWhatsappCampaignsCampaignsInner.", nameof(scheduledAt));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class GetWhatsappCampaignsCampaignsInner.", nameof(createdAt));

            if (!modifiedAt.IsSet)
                throw new ArgumentException("Property is required for class GetWhatsappCampaignsCampaignsInner.", nameof(modifiedAt));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GetWhatsappCampaignsCampaignsInner.");

            if (campaignName.IsSet && campaignName.Value == null)
                throw new ArgumentNullException(nameof(campaignName), "Property is not nullable for class GetWhatsappCampaignsCampaignsInner.");

            if (templateId.IsSet && templateId.Value == null)
                throw new ArgumentNullException(nameof(templateId), "Property is not nullable for class GetWhatsappCampaignsCampaignsInner.");

            if (campaignStatus.IsSet && campaignStatus.Value == null)
                throw new ArgumentNullException(nameof(campaignStatus), "Property is not nullable for class GetWhatsappCampaignsCampaignsInner.");

            if (scheduledAt.IsSet && scheduledAt.Value == null)
                throw new ArgumentNullException(nameof(scheduledAt), "Property is not nullable for class GetWhatsappCampaignsCampaignsInner.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class GetWhatsappCampaignsCampaignsInner.");

            if (modifiedAt.IsSet && modifiedAt.Value == null)
                throw new ArgumentNullException(nameof(modifiedAt), "Property is not nullable for class GetWhatsappCampaignsCampaignsInner.");

            if (errorReason.IsSet && errorReason.Value == null)
                throw new ArgumentNullException(nameof(errorReason), "Property is not nullable for class GetWhatsappCampaignsCampaignsInner.");

            if (invalidatedContacts.IsSet && invalidatedContacts.Value == null)
                throw new ArgumentNullException(nameof(invalidatedContacts), "Property is not nullable for class GetWhatsappCampaignsCampaignsInner.");

            if (readPercentage.IsSet && readPercentage.Value == null)
                throw new ArgumentNullException(nameof(readPercentage), "Property is not nullable for class GetWhatsappCampaignsCampaignsInner.");

            if (stats.IsSet && stats.Value == null)
                throw new ArgumentNullException(nameof(stats), "Property is not nullable for class GetWhatsappCampaignsCampaignsInner.");

            return new GetWhatsappCampaignsCampaignsInner(id.Value!.Value!, campaignName.Value!, templateId.Value!, campaignStatus.Value!.Value!, scheduledAt.Value!, createdAt.Value!, modifiedAt.Value!, errorReason, invalidatedContacts, readPercentage, stats);
        }

        /// <summary>
        /// Serializes a <see cref="GetWhatsappCampaignsCampaignsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getWhatsappCampaignsCampaignsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetWhatsappCampaignsCampaignsInner getWhatsappCampaignsCampaignsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getWhatsappCampaignsCampaignsInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetWhatsappCampaignsCampaignsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getWhatsappCampaignsCampaignsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetWhatsappCampaignsCampaignsInner getWhatsappCampaignsCampaignsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getWhatsappCampaignsCampaignsInner.CampaignName == null)
                throw new ArgumentNullException(nameof(getWhatsappCampaignsCampaignsInner.CampaignName), "Property is required for class GetWhatsappCampaignsCampaignsInner.");

            if (getWhatsappCampaignsCampaignsInner.TemplateId == null)
                throw new ArgumentNullException(nameof(getWhatsappCampaignsCampaignsInner.TemplateId), "Property is required for class GetWhatsappCampaignsCampaignsInner.");

            if (getWhatsappCampaignsCampaignsInner.ScheduledAt == null)
                throw new ArgumentNullException(nameof(getWhatsappCampaignsCampaignsInner.ScheduledAt), "Property is required for class GetWhatsappCampaignsCampaignsInner.");

            if (getWhatsappCampaignsCampaignsInner.CreatedAt == null)
                throw new ArgumentNullException(nameof(getWhatsappCampaignsCampaignsInner.CreatedAt), "Property is required for class GetWhatsappCampaignsCampaignsInner.");

            if (getWhatsappCampaignsCampaignsInner.ModifiedAt == null)
                throw new ArgumentNullException(nameof(getWhatsappCampaignsCampaignsInner.ModifiedAt), "Property is required for class GetWhatsappCampaignsCampaignsInner.");

            if (getWhatsappCampaignsCampaignsInner.ErrorReasonOption.IsSet && getWhatsappCampaignsCampaignsInner.ErrorReason == null)
                throw new ArgumentNullException(nameof(getWhatsappCampaignsCampaignsInner.ErrorReason), "Property is required for class GetWhatsappCampaignsCampaignsInner.");

            if (getWhatsappCampaignsCampaignsInner.StatsOption.IsSet && getWhatsappCampaignsCampaignsInner.Stats == null)
                throw new ArgumentNullException(nameof(getWhatsappCampaignsCampaignsInner.Stats), "Property is required for class GetWhatsappCampaignsCampaignsInner.");

            writer.WriteNumber("id", getWhatsappCampaignsCampaignsInner.Id);

            writer.WriteString("campaignName", getWhatsappCampaignsCampaignsInner.CampaignName);

            writer.WriteString("templateId", getWhatsappCampaignsCampaignsInner.TemplateId);

            var campaignStatusRawValue = GetWhatsappCampaignsCampaignsInner.CampaignStatusEnumToJsonValue(getWhatsappCampaignsCampaignsInner.CampaignStatus);
            writer.WriteString("campaignStatus", campaignStatusRawValue);
            writer.WriteString("scheduledAt", getWhatsappCampaignsCampaignsInner.ScheduledAt);

            writer.WriteString("createdAt", getWhatsappCampaignsCampaignsInner.CreatedAt);

            writer.WriteString("modifiedAt", getWhatsappCampaignsCampaignsInner.ModifiedAt);

            if (getWhatsappCampaignsCampaignsInner.ErrorReasonOption.IsSet)
                writer.WriteString("errorReason", getWhatsappCampaignsCampaignsInner.ErrorReason);

            if (getWhatsappCampaignsCampaignsInner.InvalidatedContactsOption.IsSet)
                writer.WriteNumber("invalidatedContacts", getWhatsappCampaignsCampaignsInner.InvalidatedContactsOption.Value!.Value);

            if (getWhatsappCampaignsCampaignsInner.ReadPercentageOption.IsSet)
                writer.WriteNumber("readPercentage", getWhatsappCampaignsCampaignsInner.ReadPercentageOption.Value!.Value);

            if (getWhatsappCampaignsCampaignsInner.StatsOption.IsSet)
            {
                writer.WritePropertyName("stats");
                JsonSerializer.Serialize(writer, getWhatsappCampaignsCampaignsInner.Stats, jsonSerializerOptions);
            }
        }
    }
}
