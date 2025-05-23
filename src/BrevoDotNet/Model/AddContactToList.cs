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
    /// AddContactToList
    /// </summary>
    public partial class AddContactToList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddContactToList" /> class.
        /// </summary>
        /// <param name="emails">Emails to add to a list. You can pass a maximum of 150 emails for addition in one request. If you need to add the emails in bulk, please prefer /contacts/import api.</param>
        [JsonConstructor]
        public AddContactToList(Option<List<string>?> emails = default)
        {
            EmailsOption = emails;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Emails
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> EmailsOption { get; private set; }

        /// <summary>
        /// Emails to add to a list. You can pass a maximum of 150 emails for addition in one request. If you need to add the emails in bulk, please prefer /contacts/import api.
        /// </summary>
        /// <value>Emails to add to a list. You can pass a maximum of 150 emails for addition in one request. If you need to add the emails in bulk, please prefer /contacts/import api.</value>
        [JsonPropertyName("emails")]
        public List<string>? Emails { get { return this.EmailsOption; } set { this.EmailsOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddContactToList {\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
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
    /// A Json converter for type <see cref="AddContactToList" />
    /// </summary>
    public class AddContactToListJsonConverter : JsonConverter<AddContactToList>
    {
        /// <summary>
        /// Deserializes json to <see cref="AddContactToList" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AddContactToList Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<string>?> emails = default;

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
                        case "emails":
                            emails = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (emails.IsSet && emails.Value == null)
                throw new ArgumentNullException(nameof(emails), "Property is not nullable for class AddContactToList.");

            return new AddContactToList(emails);
        }

        /// <summary>
        /// Serializes a <see cref="AddContactToList" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="addContactToList"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AddContactToList addContactToList, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, addContactToList, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AddContactToList" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="addContactToList"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AddContactToList addContactToList, JsonSerializerOptions jsonSerializerOptions)
        {
            if (addContactToList.EmailsOption.IsSet && addContactToList.Emails == null)
                throw new ArgumentNullException(nameof(addContactToList.Emails), "Property is required for class AddContactToList.");

            if (addContactToList.EmailsOption.IsSet)
            {
                writer.WritePropertyName("emails");
                JsonSerializer.Serialize(writer, addContactToList.Emails, jsonSerializerOptions);
            }
        }
    }
}
