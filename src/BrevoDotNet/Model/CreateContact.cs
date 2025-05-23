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
    /// CreateContact
    /// </summary>
    public partial class CreateContact : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContact" /> class.
        /// </summary>
        /// <param name="email">Email address of the user. Mandatory if \&quot;SMS\&quot; field is not passed in \&quot;attributes\&quot; parameter. Mobile Number in \&quot;SMS\&quot; field should be passed with proper country code. For example {\&quot;SMS\&quot;:\&quot;+91xxxxxxxxxx\&quot;} or {\&quot;SMS\&quot;:\&quot;0091xxxxxxxxxx\&quot;}</param>
        /// <param name="attributes">Pass the set of attributes and their values. These attributes must be present in your SendinBlue account. For eg. {\&quot;FNAME\&quot;:\&quot;Elly\&quot;, \&quot;LNAME\&quot;:\&quot;Roger\&quot;}</param>
        /// <param name="emailBlacklisted">Set this field to blacklist the contact for emails (emailBlacklisted &#x3D; true)</param>
        /// <param name="smsBlacklisted">Set this field to blacklist the contact for SMS (smsBlacklisted &#x3D; true)</param>
        /// <param name="listIds">Ids of the lists to add the contact to</param>
        /// <param name="updateEnabled">Facilitate to update the existing contact in the same request (updateEnabled &#x3D; true) (default to false)</param>
        /// <param name="smtpBlacklistSender">transactional email forbidden sender for contact. Use only for email Contact ( only available if updateEnabled &#x3D; true )</param>
        [JsonConstructor]
        public CreateContact(Option<string?> email = default, Option<Object?> attributes = default, Option<bool?> emailBlacklisted = default, Option<bool?> smsBlacklisted = default, Option<List<long>?> listIds = default, Option<bool?> updateEnabled = default, Option<List<string>?> smtpBlacklistSender = default)
        {
            EmailOption = email;
            AttributesOption = attributes;
            EmailBlacklistedOption = emailBlacklisted;
            SmsBlacklistedOption = smsBlacklisted;
            ListIdsOption = listIds;
            UpdateEnabledOption = updateEnabled;
            SmtpBlacklistSenderOption = smtpBlacklistSender;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Email
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> EmailOption { get; private set; }

        /// <summary>
        /// Email address of the user. Mandatory if \&quot;SMS\&quot; field is not passed in \&quot;attributes\&quot; parameter. Mobile Number in \&quot;SMS\&quot; field should be passed with proper country code. For example {\&quot;SMS\&quot;:\&quot;+91xxxxxxxxxx\&quot;} or {\&quot;SMS\&quot;:\&quot;0091xxxxxxxxxx\&quot;}
        /// </summary>
        /// <value>Email address of the user. Mandatory if \&quot;SMS\&quot; field is not passed in \&quot;attributes\&quot; parameter. Mobile Number in \&quot;SMS\&quot; field should be passed with proper country code. For example {\&quot;SMS\&quot;:\&quot;+91xxxxxxxxxx\&quot;} or {\&quot;SMS\&quot;:\&quot;0091xxxxxxxxxx\&quot;}</value>
        /* <example>elly@example.com</example> */
        [JsonPropertyName("email")]
        public string? Email { get { return this.EmailOption; } set { this.EmailOption = new(value); } }

        /// <summary>
        /// Used to track the state of Attributes
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> AttributesOption { get; private set; }

        /// <summary>
        /// Pass the set of attributes and their values. These attributes must be present in your SendinBlue account. For eg. {\&quot;FNAME\&quot;:\&quot;Elly\&quot;, \&quot;LNAME\&quot;:\&quot;Roger\&quot;}
        /// </summary>
        /// <value>Pass the set of attributes and their values. These attributes must be present in your SendinBlue account. For eg. {\&quot;FNAME\&quot;:\&quot;Elly\&quot;, \&quot;LNAME\&quot;:\&quot;Roger\&quot;}</value>
        /* <example>{&quot;FNAME&quot;:&quot;Elly&quot;,&quot;LNAME&quot;:&quot;Roger&quot;}</example> */
        [JsonPropertyName("attributes")]
        public Object? Attributes { get { return this.AttributesOption; } set { this.AttributesOption = new(value); } }

        /// <summary>
        /// Used to track the state of EmailBlacklisted
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> EmailBlacklistedOption { get; private set; }

        /// <summary>
        /// Set this field to blacklist the contact for emails (emailBlacklisted &#x3D; true)
        /// </summary>
        /// <value>Set this field to blacklist the contact for emails (emailBlacklisted &#x3D; true)</value>
        /* <example>false</example> */
        [JsonPropertyName("emailBlacklisted")]
        public bool? EmailBlacklisted { get { return this.EmailBlacklistedOption; } set { this.EmailBlacklistedOption = new(value); } }

        /// <summary>
        /// Used to track the state of SmsBlacklisted
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> SmsBlacklistedOption { get; private set; }

        /// <summary>
        /// Set this field to blacklist the contact for SMS (smsBlacklisted &#x3D; true)
        /// </summary>
        /// <value>Set this field to blacklist the contact for SMS (smsBlacklisted &#x3D; true)</value>
        /* <example>false</example> */
        [JsonPropertyName("smsBlacklisted")]
        public bool? SmsBlacklisted { get { return this.SmsBlacklistedOption; } set { this.SmsBlacklistedOption = new(value); } }

        /// <summary>
        /// Used to track the state of ListIds
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<long>?> ListIdsOption { get; private set; }

        /// <summary>
        /// Ids of the lists to add the contact to
        /// </summary>
        /// <value>Ids of the lists to add the contact to</value>
        [JsonPropertyName("listIds")]
        public List<long>? ListIds { get { return this.ListIdsOption; } set { this.ListIdsOption = new(value); } }

        /// <summary>
        /// Used to track the state of UpdateEnabled
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> UpdateEnabledOption { get; private set; }

        /// <summary>
        /// Facilitate to update the existing contact in the same request (updateEnabled &#x3D; true)
        /// </summary>
        /// <value>Facilitate to update the existing contact in the same request (updateEnabled &#x3D; true)</value>
        /* <example>false</example> */
        [JsonPropertyName("updateEnabled")]
        public bool? UpdateEnabled { get { return this.UpdateEnabledOption; } set { this.UpdateEnabledOption = new(value); } }

        /// <summary>
        /// Used to track the state of SmtpBlacklistSender
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> SmtpBlacklistSenderOption { get; private set; }

        /// <summary>
        /// transactional email forbidden sender for contact. Use only for email Contact ( only available if updateEnabled &#x3D; true )
        /// </summary>
        /// <value>transactional email forbidden sender for contact. Use only for email Contact ( only available if updateEnabled &#x3D; true )</value>
        [JsonPropertyName("smtpBlacklistSender")]
        public List<string>? SmtpBlacklistSender { get { return this.SmtpBlacklistSenderOption; } set { this.SmtpBlacklistSenderOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateContact {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  EmailBlacklisted: ").Append(EmailBlacklisted).Append("\n");
            sb.Append("  SmsBlacklisted: ").Append(SmsBlacklisted).Append("\n");
            sb.Append("  ListIds: ").Append(ListIds).Append("\n");
            sb.Append("  UpdateEnabled: ").Append(UpdateEnabled).Append("\n");
            sb.Append("  SmtpBlacklistSender: ").Append(SmtpBlacklistSender).Append("\n");
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
    /// A Json converter for type <see cref="CreateContact" />
    /// </summary>
    public class CreateContactJsonConverter : JsonConverter<CreateContact>
    {
        /// <summary>
        /// Deserializes json to <see cref="CreateContact" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateContact Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> email = default;
            Option<Object?> attributes = default;
            Option<bool?> emailBlacklisted = default;
            Option<bool?> smsBlacklisted = default;
            Option<List<long>?> listIds = default;
            Option<bool?> updateEnabled = default;
            Option<List<string>?> smtpBlacklistSender = default;

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
                        case "email":
                            email = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "attributes":
                            attributes = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "emailBlacklisted":
                            emailBlacklisted = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "smsBlacklisted":
                            smsBlacklisted = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "listIds":
                            listIds = new Option<List<long>?>(JsonSerializer.Deserialize<List<long>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "updateEnabled":
                            updateEnabled = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "smtpBlacklistSender":
                            smtpBlacklistSender = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (email.IsSet && email.Value == null)
                throw new ArgumentNullException(nameof(email), "Property is not nullable for class CreateContact.");

            if (attributes.IsSet && attributes.Value == null)
                throw new ArgumentNullException(nameof(attributes), "Property is not nullable for class CreateContact.");

            if (emailBlacklisted.IsSet && emailBlacklisted.Value == null)
                throw new ArgumentNullException(nameof(emailBlacklisted), "Property is not nullable for class CreateContact.");

            if (smsBlacklisted.IsSet && smsBlacklisted.Value == null)
                throw new ArgumentNullException(nameof(smsBlacklisted), "Property is not nullable for class CreateContact.");

            if (listIds.IsSet && listIds.Value == null)
                throw new ArgumentNullException(nameof(listIds), "Property is not nullable for class CreateContact.");

            if (updateEnabled.IsSet && updateEnabled.Value == null)
                throw new ArgumentNullException(nameof(updateEnabled), "Property is not nullable for class CreateContact.");

            if (smtpBlacklistSender.IsSet && smtpBlacklistSender.Value == null)
                throw new ArgumentNullException(nameof(smtpBlacklistSender), "Property is not nullable for class CreateContact.");

            return new CreateContact(email, attributes, emailBlacklisted, smsBlacklisted, listIds, updateEnabled, smtpBlacklistSender);
        }

        /// <summary>
        /// Serializes a <see cref="CreateContact" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createContact"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateContact createContact, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, createContact, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateContact" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createContact"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CreateContact createContact, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createContact.EmailOption.IsSet && createContact.Email == null)
                throw new ArgumentNullException(nameof(createContact.Email), "Property is required for class CreateContact.");

            if (createContact.AttributesOption.IsSet && createContact.Attributes == null)
                throw new ArgumentNullException(nameof(createContact.Attributes), "Property is required for class CreateContact.");

            if (createContact.ListIdsOption.IsSet && createContact.ListIds == null)
                throw new ArgumentNullException(nameof(createContact.ListIds), "Property is required for class CreateContact.");

            if (createContact.SmtpBlacklistSenderOption.IsSet && createContact.SmtpBlacklistSender == null)
                throw new ArgumentNullException(nameof(createContact.SmtpBlacklistSender), "Property is required for class CreateContact.");

            if (createContact.EmailOption.IsSet)
                writer.WriteString("email", createContact.Email);

            if (createContact.AttributesOption.IsSet)
            {
                writer.WritePropertyName("attributes");
                JsonSerializer.Serialize(writer, createContact.Attributes, jsonSerializerOptions);
            }
            if (createContact.EmailBlacklistedOption.IsSet)
                writer.WriteBoolean("emailBlacklisted", createContact.EmailBlacklistedOption.Value!.Value);

            if (createContact.SmsBlacklistedOption.IsSet)
                writer.WriteBoolean("smsBlacklisted", createContact.SmsBlacklistedOption.Value!.Value);

            if (createContact.ListIdsOption.IsSet)
            {
                writer.WritePropertyName("listIds");
                JsonSerializer.Serialize(writer, createContact.ListIds, jsonSerializerOptions);
            }
            if (createContact.UpdateEnabledOption.IsSet)
                writer.WriteBoolean("updateEnabled", createContact.UpdateEnabledOption.Value!.Value);

            if (createContact.SmtpBlacklistSenderOption.IsSet)
            {
                writer.WritePropertyName("smtpBlacklistSender");
                JsonSerializer.Serialize(writer, createContact.SmtpBlacklistSender, jsonSerializerOptions);
            }
        }
    }
}
