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
    /// GetContactCampaignStatsUnsubscriptions
    /// </summary>
    public partial class GetContactCampaignStatsUnsubscriptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactCampaignStatsUnsubscriptions" /> class.
        /// </summary>
        /// <param name="userUnsubscription">Contact has unsubscribed via the unsubscription link in the email</param>
        /// <param name="adminUnsubscription">Contact has been unsubscribed from the administrator</param>
        [JsonConstructor]
        public GetContactCampaignStatsUnsubscriptions(List<GetExtendedContactDetailsAllOfStatisticsUnsubscriptionsUserUnsubscription> userUnsubscription, List<GetExtendedContactDetailsAllOfStatisticsUnsubscriptionsAdminUnsubscription> adminUnsubscription)
        {
            UserUnsubscription = userUnsubscription;
            AdminUnsubscription = adminUnsubscription;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Contact has unsubscribed via the unsubscription link in the email
        /// </summary>
        /// <value>Contact has unsubscribed via the unsubscription link in the email</value>
        [JsonPropertyName("userUnsubscription")]
        public List<GetExtendedContactDetailsAllOfStatisticsUnsubscriptionsUserUnsubscription> UserUnsubscription { get; set; }

        /// <summary>
        /// Contact has been unsubscribed from the administrator
        /// </summary>
        /// <value>Contact has been unsubscribed from the administrator</value>
        [JsonPropertyName("adminUnsubscription")]
        public List<GetExtendedContactDetailsAllOfStatisticsUnsubscriptionsAdminUnsubscription> AdminUnsubscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetContactCampaignStatsUnsubscriptions {\n");
            sb.Append("  UserUnsubscription: ").Append(UserUnsubscription).Append("\n");
            sb.Append("  AdminUnsubscription: ").Append(AdminUnsubscription).Append("\n");
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
    /// A Json converter for type <see cref="GetContactCampaignStatsUnsubscriptions" />
    /// </summary>
    public class GetContactCampaignStatsUnsubscriptionsJsonConverter : JsonConverter<GetContactCampaignStatsUnsubscriptions>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetContactCampaignStatsUnsubscriptions" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetContactCampaignStatsUnsubscriptions Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<GetExtendedContactDetailsAllOfStatisticsUnsubscriptionsUserUnsubscription>?> userUnsubscription = default;
            Option<List<GetExtendedContactDetailsAllOfStatisticsUnsubscriptionsAdminUnsubscription>?> adminUnsubscription = default;

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
                        case "userUnsubscription":
                            userUnsubscription = new Option<List<GetExtendedContactDetailsAllOfStatisticsUnsubscriptionsUserUnsubscription>?>(JsonSerializer.Deserialize<List<GetExtendedContactDetailsAllOfStatisticsUnsubscriptionsUserUnsubscription>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "adminUnsubscription":
                            adminUnsubscription = new Option<List<GetExtendedContactDetailsAllOfStatisticsUnsubscriptionsAdminUnsubscription>?>(JsonSerializer.Deserialize<List<GetExtendedContactDetailsAllOfStatisticsUnsubscriptionsAdminUnsubscription>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!userUnsubscription.IsSet)
                throw new ArgumentException("Property is required for class GetContactCampaignStatsUnsubscriptions.", nameof(userUnsubscription));

            if (!adminUnsubscription.IsSet)
                throw new ArgumentException("Property is required for class GetContactCampaignStatsUnsubscriptions.", nameof(adminUnsubscription));

            if (userUnsubscription.IsSet && userUnsubscription.Value == null)
                throw new ArgumentNullException(nameof(userUnsubscription), "Property is not nullable for class GetContactCampaignStatsUnsubscriptions.");

            if (adminUnsubscription.IsSet && adminUnsubscription.Value == null)
                throw new ArgumentNullException(nameof(adminUnsubscription), "Property is not nullable for class GetContactCampaignStatsUnsubscriptions.");

            return new GetContactCampaignStatsUnsubscriptions(userUnsubscription.Value!, adminUnsubscription.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GetContactCampaignStatsUnsubscriptions" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getContactCampaignStatsUnsubscriptions"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetContactCampaignStatsUnsubscriptions getContactCampaignStatsUnsubscriptions, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getContactCampaignStatsUnsubscriptions, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetContactCampaignStatsUnsubscriptions" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getContactCampaignStatsUnsubscriptions"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetContactCampaignStatsUnsubscriptions getContactCampaignStatsUnsubscriptions, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getContactCampaignStatsUnsubscriptions.UserUnsubscription == null)
                throw new ArgumentNullException(nameof(getContactCampaignStatsUnsubscriptions.UserUnsubscription), "Property is required for class GetContactCampaignStatsUnsubscriptions.");

            if (getContactCampaignStatsUnsubscriptions.AdminUnsubscription == null)
                throw new ArgumentNullException(nameof(getContactCampaignStatsUnsubscriptions.AdminUnsubscription), "Property is required for class GetContactCampaignStatsUnsubscriptions.");

            writer.WritePropertyName("userUnsubscription");
            JsonSerializer.Serialize(writer, getContactCampaignStatsUnsubscriptions.UserUnsubscription, jsonSerializerOptions);
            writer.WritePropertyName("adminUnsubscription");
            JsonSerializer.Serialize(writer, getContactCampaignStatsUnsubscriptions.AdminUnsubscription, jsonSerializerOptions);
        }
    }
}
