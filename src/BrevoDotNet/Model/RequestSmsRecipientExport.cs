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
    /// RequestSmsRecipientExport
    /// </summary>
    public partial class RequestSmsRecipientExport : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestSmsRecipientExport" /> class.
        /// </summary>
        /// <param name="recipientsType">Filter the recipients based on how they interacted with the campaign</param>
        /// <param name="notifyURL">URL that will be called once the export process is finished. For reference, https://help.sendinblue.com/hc/en-us/articles/360007666479</param>
        [JsonConstructor]
        public RequestSmsRecipientExport(RecipientsTypeEnum recipientsType, Option<string?> notifyURL = default)
        {
            RecipientsType = recipientsType;
            NotifyURLOption = notifyURL;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Filter the recipients based on how they interacted with the campaign
        /// </summary>
        /// <value>Filter the recipients based on how they interacted with the campaign</value>
        public enum RecipientsTypeEnum
        {
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            All = 1,

            /// <summary>
            /// Enum Delivered for value: delivered
            /// </summary>
            Delivered = 2,

            /// <summary>
            /// Enum Answered for value: answered
            /// </summary>
            Answered = 3,

            /// <summary>
            /// Enum SoftBounces for value: softBounces
            /// </summary>
            SoftBounces = 4,

            /// <summary>
            /// Enum HardBounces for value: hardBounces
            /// </summary>
            HardBounces = 5,

            /// <summary>
            /// Enum Unsubscribed for value: unsubscribed
            /// </summary>
            Unsubscribed = 6
        }

        /// <summary>
        /// Returns a <see cref="RecipientsTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static RecipientsTypeEnum RecipientsTypeEnumFromString(string value)
        {
            if (value.Equals("all"))
                return RecipientsTypeEnum.All;

            if (value.Equals("delivered"))
                return RecipientsTypeEnum.Delivered;

            if (value.Equals("answered"))
                return RecipientsTypeEnum.Answered;

            if (value.Equals("softBounces"))
                return RecipientsTypeEnum.SoftBounces;

            if (value.Equals("hardBounces"))
                return RecipientsTypeEnum.HardBounces;

            if (value.Equals("unsubscribed"))
                return RecipientsTypeEnum.Unsubscribed;

            throw new NotImplementedException($"Could not convert value to type RecipientsTypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="RecipientsTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RecipientsTypeEnum? RecipientsTypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("all"))
                return RecipientsTypeEnum.All;

            if (value.Equals("delivered"))
                return RecipientsTypeEnum.Delivered;

            if (value.Equals("answered"))
                return RecipientsTypeEnum.Answered;

            if (value.Equals("softBounces"))
                return RecipientsTypeEnum.SoftBounces;

            if (value.Equals("hardBounces"))
                return RecipientsTypeEnum.HardBounces;

            if (value.Equals("unsubscribed"))
                return RecipientsTypeEnum.Unsubscribed;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="RecipientsTypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string RecipientsTypeEnumToJsonValue(RecipientsTypeEnum value)
        {
            if (value == RecipientsTypeEnum.All)
                return "all";

            if (value == RecipientsTypeEnum.Delivered)
                return "delivered";

            if (value == RecipientsTypeEnum.Answered)
                return "answered";

            if (value == RecipientsTypeEnum.SoftBounces)
                return "softBounces";

            if (value == RecipientsTypeEnum.HardBounces)
                return "hardBounces";

            if (value == RecipientsTypeEnum.Unsubscribed)
                return "unsubscribed";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Filter the recipients based on how they interacted with the campaign
        /// </summary>
        /// <value>Filter the recipients based on how they interacted with the campaign</value>
        /* <example>answered</example> */
        [JsonPropertyName("recipientsType")]
        public RecipientsTypeEnum RecipientsType { get; set; }

        /// <summary>
        /// Used to track the state of NotifyURL
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NotifyURLOption { get; private set; }

        /// <summary>
        /// URL that will be called once the export process is finished. For reference, https://help.sendinblue.com/hc/en-us/articles/360007666479
        /// </summary>
        /// <value>URL that will be called once the export process is finished. For reference, https://help.sendinblue.com/hc/en-us/articles/360007666479</value>
        /* <example>http://requestb.in/173lyyx1</example> */
        [JsonPropertyName("notifyURL")]
        public string? NotifyURL { get { return this.NotifyURLOption; } set { this.NotifyURLOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestSmsRecipientExport {\n");
            sb.Append("  RecipientsType: ").Append(RecipientsType).Append("\n");
            sb.Append("  NotifyURL: ").Append(NotifyURL).Append("\n");
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
    /// A Json converter for type <see cref="RequestSmsRecipientExport" />
    /// </summary>
    public class RequestSmsRecipientExportJsonConverter : JsonConverter<RequestSmsRecipientExport>
    {
        /// <summary>
        /// Deserializes json to <see cref="RequestSmsRecipientExport" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override RequestSmsRecipientExport Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<RequestSmsRecipientExport.RecipientsTypeEnum?> recipientsType = default;
            Option<string?> notifyURL = default;

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
                        case "recipientsType":
                            string? recipientsTypeRawValue = utf8JsonReader.GetString();
                            if (recipientsTypeRawValue != null)
                                recipientsType = new Option<RequestSmsRecipientExport.RecipientsTypeEnum?>(RequestSmsRecipientExport.RecipientsTypeEnumFromStringOrDefault(recipientsTypeRawValue));
                            break;
                        case "notifyURL":
                            notifyURL = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!recipientsType.IsSet)
                throw new ArgumentException("Property is required for class RequestSmsRecipientExport.", nameof(recipientsType));

            if (recipientsType.IsSet && recipientsType.Value == null)
                throw new ArgumentNullException(nameof(recipientsType), "Property is not nullable for class RequestSmsRecipientExport.");

            if (notifyURL.IsSet && notifyURL.Value == null)
                throw new ArgumentNullException(nameof(notifyURL), "Property is not nullable for class RequestSmsRecipientExport.");

            return new RequestSmsRecipientExport(recipientsType.Value!.Value!, notifyURL);
        }

        /// <summary>
        /// Serializes a <see cref="RequestSmsRecipientExport" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="requestSmsRecipientExport"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, RequestSmsRecipientExport requestSmsRecipientExport, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, requestSmsRecipientExport, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="RequestSmsRecipientExport" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="requestSmsRecipientExport"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, RequestSmsRecipientExport requestSmsRecipientExport, JsonSerializerOptions jsonSerializerOptions)
        {
            if (requestSmsRecipientExport.NotifyURLOption.IsSet && requestSmsRecipientExport.NotifyURL == null)
                throw new ArgumentNullException(nameof(requestSmsRecipientExport.NotifyURL), "Property is required for class RequestSmsRecipientExport.");

            var recipientsTypeRawValue = RequestSmsRecipientExport.RecipientsTypeEnumToJsonValue(requestSmsRecipientExport.RecipientsType);
            writer.WriteString("recipientsType", recipientsTypeRawValue);
            if (requestSmsRecipientExport.NotifyURLOption.IsSet)
                writer.WriteString("notifyURL", requestSmsRecipientExport.NotifyURL);
        }
    }
}
