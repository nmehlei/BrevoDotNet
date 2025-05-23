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
    /// UpdateList
    /// </summary>
    public partial class UpdateList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateList" /> class.
        /// </summary>
        /// <param name="name">Name of the list. Either of the two parameters (name, folderId) can be updated at a time.</param>
        /// <param name="folderId">Id of the folder in which the list is to be moved. Either of the two parameters (name, folderId) can be updated at a time.</param>
        [JsonConstructor]
        public UpdateList(Option<string?> name = default, Option<long?> folderId = default)
        {
            NameOption = name;
            FolderIdOption = folderId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// Name of the list. Either of the two parameters (name, folderId) can be updated at a time.
        /// </summary>
        /// <value>Name of the list. Either of the two parameters (name, folderId) can be updated at a time.</value>
        /* <example>Magento Customer - ES</example> */
        [JsonPropertyName("name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new(value); } }

        /// <summary>
        /// Used to track the state of FolderId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> FolderIdOption { get; private set; }

        /// <summary>
        /// Id of the folder in which the list is to be moved. Either of the two parameters (name, folderId) can be updated at a time.
        /// </summary>
        /// <value>Id of the folder in which the list is to be moved. Either of the two parameters (name, folderId) can be updated at a time.</value>
        /* <example>2</example> */
        [JsonPropertyName("folderId")]
        public long? FolderId { get { return this.FolderIdOption; } set { this.FolderIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateList {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
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
    /// A Json converter for type <see cref="UpdateList" />
    /// </summary>
    public class UpdateListJsonConverter : JsonConverter<UpdateList>
    {
        /// <summary>
        /// Deserializes json to <see cref="UpdateList" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UpdateList Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<long?> folderId = default;

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
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "folderId":
                            folderId = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class UpdateList.");

            if (folderId.IsSet && folderId.Value == null)
                throw new ArgumentNullException(nameof(folderId), "Property is not nullable for class UpdateList.");

            return new UpdateList(name, folderId);
        }

        /// <summary>
        /// Serializes a <see cref="UpdateList" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="updateList"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UpdateList updateList, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, updateList, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UpdateList" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="updateList"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UpdateList updateList, JsonSerializerOptions jsonSerializerOptions)
        {
            if (updateList.NameOption.IsSet && updateList.Name == null)
                throw new ArgumentNullException(nameof(updateList.Name), "Property is required for class UpdateList.");

            if (updateList.NameOption.IsSet)
                writer.WriteString("name", updateList.Name);

            if (updateList.FolderIdOption.IsSet)
                writer.WriteNumber("folderId", updateList.FolderIdOption.Value!.Value);
        }
    }
}
