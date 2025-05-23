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
    /// Reason for blocking / unsubscribing
    /// </summary>
    public partial class GetTransacBlockedContactsContactsInnerReason : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransacBlockedContactsContactsInnerReason" /> class.
        /// </summary>
        /// <param name="code">Reason code for blocking / unsubscribing (This code is safe for comparison)</param>
        /// <param name="message">Reason for blocking / unsubscribing (This string is not safe for comparison)</param>
        [JsonConstructor]
        public GetTransacBlockedContactsContactsInnerReason(Option<CodeEnum?> code = default, Option<string?> message = default)
        {
            CodeOption = code;
            MessageOption = message;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Reason code for blocking / unsubscribing (This code is safe for comparison)
        /// </summary>
        /// <value>Reason code for blocking / unsubscribing (This code is safe for comparison)</value>
        public enum CodeEnum
        {
            /// <summary>
            /// Enum UnsubscribedViaMA for value: unsubscribedViaMA
            /// </summary>
            UnsubscribedViaMA = 1,

            /// <summary>
            /// Enum UnsubscribedViaEmail for value: unsubscribedViaEmail
            /// </summary>
            UnsubscribedViaEmail = 2,

            /// <summary>
            /// Enum AdminBlocked for value: adminBlocked
            /// </summary>
            AdminBlocked = 3,

            /// <summary>
            /// Enum UnsubscribedViaApi for value: unsubscribedViaApi
            /// </summary>
            UnsubscribedViaApi = 4,

            /// <summary>
            /// Enum HardBounce for value: hardBounce
            /// </summary>
            HardBounce = 5,

            /// <summary>
            /// Enum ContactFlaggedAsSpam for value: contactFlaggedAsSpam
            /// </summary>
            ContactFlaggedAsSpam = 6
        }

        /// <summary>
        /// Returns a <see cref="CodeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static CodeEnum CodeEnumFromString(string value)
        {
            if (value.Equals("unsubscribedViaMA"))
                return CodeEnum.UnsubscribedViaMA;

            if (value.Equals("unsubscribedViaEmail"))
                return CodeEnum.UnsubscribedViaEmail;

            if (value.Equals("adminBlocked"))
                return CodeEnum.AdminBlocked;

            if (value.Equals("unsubscribedViaApi"))
                return CodeEnum.UnsubscribedViaApi;

            if (value.Equals("hardBounce"))
                return CodeEnum.HardBounce;

            if (value.Equals("contactFlaggedAsSpam"))
                return CodeEnum.ContactFlaggedAsSpam;

            throw new NotImplementedException($"Could not convert value to type CodeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="CodeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CodeEnum? CodeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("unsubscribedViaMA"))
                return CodeEnum.UnsubscribedViaMA;

            if (value.Equals("unsubscribedViaEmail"))
                return CodeEnum.UnsubscribedViaEmail;

            if (value.Equals("adminBlocked"))
                return CodeEnum.AdminBlocked;

            if (value.Equals("unsubscribedViaApi"))
                return CodeEnum.UnsubscribedViaApi;

            if (value.Equals("hardBounce"))
                return CodeEnum.HardBounce;

            if (value.Equals("contactFlaggedAsSpam"))
                return CodeEnum.ContactFlaggedAsSpam;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="CodeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string CodeEnumToJsonValue(CodeEnum? value)
        {
            if (value == CodeEnum.UnsubscribedViaMA)
                return "unsubscribedViaMA";

            if (value == CodeEnum.UnsubscribedViaEmail)
                return "unsubscribedViaEmail";

            if (value == CodeEnum.AdminBlocked)
                return "adminBlocked";

            if (value == CodeEnum.UnsubscribedViaApi)
                return "unsubscribedViaApi";

            if (value == CodeEnum.HardBounce)
                return "hardBounce";

            if (value == CodeEnum.ContactFlaggedAsSpam)
                return "contactFlaggedAsSpam";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of Code
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<CodeEnum?> CodeOption { get; private set; }

        /// <summary>
        /// Reason code for blocking / unsubscribing (This code is safe for comparison)
        /// </summary>
        /// <value>Reason code for blocking / unsubscribing (This code is safe for comparison)</value>
        /* <example>AdminBlocked</example> */
        [JsonPropertyName("code")]
        public CodeEnum? Code { get { return this.CodeOption; } set { this.CodeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Message
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MessageOption { get; private set; }

        /// <summary>
        /// Reason for blocking / unsubscribing (This string is not safe for comparison)
        /// </summary>
        /// <value>Reason for blocking / unsubscribing (This string is not safe for comparison)</value>
        /* <example>Admin blocked</example> */
        [JsonPropertyName("message")]
        public string? Message { get { return this.MessageOption; } set { this.MessageOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransacBlockedContactsContactsInnerReason {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
    /// A Json converter for type <see cref="GetTransacBlockedContactsContactsInnerReason" />
    /// </summary>
    public class GetTransacBlockedContactsContactsInnerReasonJsonConverter : JsonConverter<GetTransacBlockedContactsContactsInnerReason>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetTransacBlockedContactsContactsInnerReason" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetTransacBlockedContactsContactsInnerReason Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<GetTransacBlockedContactsContactsInnerReason.CodeEnum?> code = default;
            Option<string?> message = default;

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
                        case "code":
                            string? codeRawValue = utf8JsonReader.GetString();
                            if (codeRawValue != null)
                                code = new Option<GetTransacBlockedContactsContactsInnerReason.CodeEnum?>(GetTransacBlockedContactsContactsInnerReason.CodeEnumFromStringOrDefault(codeRawValue));
                            break;
                        case "message":
                            message = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (code.IsSet && code.Value == null)
                throw new ArgumentNullException(nameof(code), "Property is not nullable for class GetTransacBlockedContactsContactsInnerReason.");

            if (message.IsSet && message.Value == null)
                throw new ArgumentNullException(nameof(message), "Property is not nullable for class GetTransacBlockedContactsContactsInnerReason.");

            return new GetTransacBlockedContactsContactsInnerReason(code, message);
        }

        /// <summary>
        /// Serializes a <see cref="GetTransacBlockedContactsContactsInnerReason" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransacBlockedContactsContactsInnerReason"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetTransacBlockedContactsContactsInnerReason getTransacBlockedContactsContactsInnerReason, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getTransacBlockedContactsContactsInnerReason, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetTransacBlockedContactsContactsInnerReason" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransacBlockedContactsContactsInnerReason"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetTransacBlockedContactsContactsInnerReason getTransacBlockedContactsContactsInnerReason, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getTransacBlockedContactsContactsInnerReason.MessageOption.IsSet && getTransacBlockedContactsContactsInnerReason.Message == null)
                throw new ArgumentNullException(nameof(getTransacBlockedContactsContactsInnerReason.Message), "Property is required for class GetTransacBlockedContactsContactsInnerReason.");

            var codeRawValue = GetTransacBlockedContactsContactsInnerReason.CodeEnumToJsonValue(getTransacBlockedContactsContactsInnerReason.CodeOption.Value!.Value);
            writer.WriteString("code", codeRawValue);
            if (getTransacBlockedContactsContactsInnerReason.MessageOption.IsSet)
                writer.WriteString("message", getTransacBlockedContactsContactsInnerReason.Message);
        }
    }
}
