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
    /// CreateSmsCampaign
    /// </summary>
    public partial class CreateSmsCampaign : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSmsCampaign" /> class.
        /// </summary>
        /// <param name="name">Name of the campaign</param>
        /// <param name="sender">Name of the sender. **The number of characters is limited to 11 for alphanumeric characters and 15 for numeric characters**</param>
        /// <param name="content">Content of the message. The maximum characters used per SMS is 160, if used more than that, it will be counted as more than one SMS</param>
        /// <param name="recipients">recipients</param>
        /// <param name="scheduledAt">UTC date-time on which the campaign has to run (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result.</param>
        [JsonConstructor]
        public CreateSmsCampaign(string name, string sender, string content, Option<CreateSmsCampaignRecipients?> recipients = default, Option<DateTime?> scheduledAt = default)
        {
            Name = name;
            Sender = sender;
            Content = content;
            RecipientsOption = recipients;
            ScheduledAtOption = scheduledAt;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Name of the campaign
        /// </summary>
        /// <value>Name of the campaign</value>
        /* <example>Spring Promo Code</example> */
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Name of the sender. **The number of characters is limited to 11 for alphanumeric characters and 15 for numeric characters**
        /// </summary>
        /// <value>Name of the sender. **The number of characters is limited to 11 for alphanumeric characters and 15 for numeric characters**</value>
        /* <example>MyShop</example> */
        [JsonPropertyName("sender")]
        public string Sender { get; set; }

        /// <summary>
        /// Content of the message. The maximum characters used per SMS is 160, if used more than that, it will be counted as more than one SMS
        /// </summary>
        /// <value>Content of the message. The maximum characters used per SMS is 160, if used more than that, it will be counted as more than one SMS</value>
        /* <example>Get a discount by visiting our NY store and saying : Happy Spring !</example> */
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// Used to track the state of Recipients
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<CreateSmsCampaignRecipients?> RecipientsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Recipients
        /// </summary>
        [JsonPropertyName("recipients")]
        public CreateSmsCampaignRecipients? Recipients { get { return this.RecipientsOption; } set { this.RecipientsOption = new(value); } }

        /// <summary>
        /// Used to track the state of ScheduledAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> ScheduledAtOption { get; private set; }

        /// <summary>
        /// UTC date-time on which the campaign has to run (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result.
        /// </summary>
        /// <value>UTC date-time on which the campaign has to run (YYYY-MM-DDTHH:mm:ss.SSSZ). Prefer to pass your timezone in date-time format for accurate result.</value>
        /* <example>2017-05-05T12:30+02:00</example> */
        [JsonPropertyName("scheduledAt")]
        public DateTime? ScheduledAt { get { return this.ScheduledAtOption; } set { this.ScheduledAtOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSmsCampaign {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
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
            // Sender (string) maxLength
            if (this.Sender != null && this.Sender.Length > 15)
            {
                yield return new ValidationResult("Invalid value for Sender, length must be less than 15.", new [] { "Sender" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="CreateSmsCampaign" />
    /// </summary>
    public class CreateSmsCampaignJsonConverter : JsonConverter<CreateSmsCampaign>
    {
        /// <summary>
        /// The format to use to serialize ScheduledAt
        /// </summary>
        public static string ScheduledAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="CreateSmsCampaign" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateSmsCampaign Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<string?> sender = default;
            Option<string?> content = default;
            Option<CreateSmsCampaignRecipients?> recipients = default;
            Option<DateTime?> scheduledAt = default;

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
                        case "sender":
                            sender = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "content":
                            content = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "recipients":
                            recipients = new Option<CreateSmsCampaignRecipients?>(JsonSerializer.Deserialize<CreateSmsCampaignRecipients>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "scheduledAt":
                            scheduledAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class CreateSmsCampaign.", nameof(name));

            if (!sender.IsSet)
                throw new ArgumentException("Property is required for class CreateSmsCampaign.", nameof(sender));

            if (!content.IsSet)
                throw new ArgumentException("Property is required for class CreateSmsCampaign.", nameof(content));

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class CreateSmsCampaign.");

            if (sender.IsSet && sender.Value == null)
                throw new ArgumentNullException(nameof(sender), "Property is not nullable for class CreateSmsCampaign.");

            if (content.IsSet && content.Value == null)
                throw new ArgumentNullException(nameof(content), "Property is not nullable for class CreateSmsCampaign.");

            if (recipients.IsSet && recipients.Value == null)
                throw new ArgumentNullException(nameof(recipients), "Property is not nullable for class CreateSmsCampaign.");

            if (scheduledAt.IsSet && scheduledAt.Value == null)
                throw new ArgumentNullException(nameof(scheduledAt), "Property is not nullable for class CreateSmsCampaign.");

            return new CreateSmsCampaign(name.Value!, sender.Value!, content.Value!, recipients, scheduledAt);
        }

        /// <summary>
        /// Serializes a <see cref="CreateSmsCampaign" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createSmsCampaign"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateSmsCampaign createSmsCampaign, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, createSmsCampaign, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateSmsCampaign" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createSmsCampaign"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CreateSmsCampaign createSmsCampaign, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createSmsCampaign.Name == null)
                throw new ArgumentNullException(nameof(createSmsCampaign.Name), "Property is required for class CreateSmsCampaign.");

            if (createSmsCampaign.Sender == null)
                throw new ArgumentNullException(nameof(createSmsCampaign.Sender), "Property is required for class CreateSmsCampaign.");

            if (createSmsCampaign.Content == null)
                throw new ArgumentNullException(nameof(createSmsCampaign.Content), "Property is required for class CreateSmsCampaign.");

            if (createSmsCampaign.RecipientsOption.IsSet && createSmsCampaign.Recipients == null)
                throw new ArgumentNullException(nameof(createSmsCampaign.Recipients), "Property is required for class CreateSmsCampaign.");

            writer.WriteString("name", createSmsCampaign.Name);

            writer.WriteString("sender", createSmsCampaign.Sender);

            writer.WriteString("content", createSmsCampaign.Content);

            if (createSmsCampaign.RecipientsOption.IsSet)
            {
                writer.WritePropertyName("recipients");
                JsonSerializer.Serialize(writer, createSmsCampaign.Recipients, jsonSerializerOptions);
            }
            if (createSmsCampaign.ScheduledAtOption.IsSet)
                writer.WriteString("scheduledAt", createSmsCampaign.ScheduledAtOption.Value!.Value.ToString(ScheduledAtFormat));
        }
    }
}
