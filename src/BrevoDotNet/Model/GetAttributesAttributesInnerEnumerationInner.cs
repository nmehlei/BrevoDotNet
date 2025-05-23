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
    /// GetAttributesAttributesInnerEnumerationInner
    /// </summary>
    public partial class GetAttributesAttributesInnerEnumerationInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAttributesAttributesInnerEnumerationInner" /> class.
        /// </summary>
        /// <param name="value">ID of Value of the \&quot;category\&quot; type attribute</param>
        /// <param name="label">Label of the \&quot;category\&quot; type attribute</param>
        [JsonConstructor]
        public GetAttributesAttributesInnerEnumerationInner(long value, string label)
        {
            Value = value;
            Label = label;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// ID of Value of the \&quot;category\&quot; type attribute
        /// </summary>
        /// <value>ID of Value of the \&quot;category\&quot; type attribute</value>
        /* <example>1</example> */
        [JsonPropertyName("value")]
        public long Value { get; set; }

        /// <summary>
        /// Label of the \&quot;category\&quot; type attribute
        /// </summary>
        /// <value>Label of the \&quot;category\&quot; type attribute</value>
        /* <example>Women</example> */
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAttributesAttributesInnerEnumerationInner {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
    /// A Json converter for type <see cref="GetAttributesAttributesInnerEnumerationInner" />
    /// </summary>
    public class GetAttributesAttributesInnerEnumerationInnerJsonConverter : JsonConverter<GetAttributesAttributesInnerEnumerationInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetAttributesAttributesInnerEnumerationInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetAttributesAttributesInnerEnumerationInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> value = default;
            Option<string?> label = default;

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
                        case "value":
                            value = new Option<long?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (long?)null : utf8JsonReader.GetInt64());
                            break;
                        case "label":
                            label = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!value.IsSet)
                throw new ArgumentException("Property is required for class GetAttributesAttributesInnerEnumerationInner.", nameof(value));

            if (!label.IsSet)
                throw new ArgumentException("Property is required for class GetAttributesAttributesInnerEnumerationInner.", nameof(label));

            if (value.IsSet && value.Value == null)
                throw new ArgumentNullException(nameof(value), "Property is not nullable for class GetAttributesAttributesInnerEnumerationInner.");

            if (label.IsSet && label.Value == null)
                throw new ArgumentNullException(nameof(label), "Property is not nullable for class GetAttributesAttributesInnerEnumerationInner.");

            return new GetAttributesAttributesInnerEnumerationInner(value.Value!.Value!, label.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GetAttributesAttributesInnerEnumerationInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAttributesAttributesInnerEnumerationInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetAttributesAttributesInnerEnumerationInner getAttributesAttributesInnerEnumerationInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getAttributesAttributesInnerEnumerationInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetAttributesAttributesInnerEnumerationInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAttributesAttributesInnerEnumerationInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetAttributesAttributesInnerEnumerationInner getAttributesAttributesInnerEnumerationInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getAttributesAttributesInnerEnumerationInner.Label == null)
                throw new ArgumentNullException(nameof(getAttributesAttributesInnerEnumerationInner.Label), "Property is required for class GetAttributesAttributesInnerEnumerationInner.");

            writer.WriteNumber("value", getAttributesAttributesInnerEnumerationInner.Value);

            writer.WriteString("label", getAttributesAttributesInnerEnumerationInner.Label);
        }
    }
}
