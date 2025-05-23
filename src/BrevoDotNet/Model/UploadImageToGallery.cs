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
    /// UploadImageToGallery
    /// </summary>
    public partial class UploadImageToGallery : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadImageToGallery" /> class.
        /// </summary>
        /// <param name="imageUrl">The absolute url of the image (no local file). Maximum allowed size for image is 2MB. Allowed extensions for images are - jpeg, jpg, png, bmp, gif.</param>
        /// <param name="name">Name of the image.</param>
        [JsonConstructor]
        public UploadImageToGallery(string imageUrl, Option<string?> name = default)
        {
            ImageUrl = imageUrl;
            NameOption = name;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The absolute url of the image (no local file). Maximum allowed size for image is 2MB. Allowed extensions for images are - jpeg, jpg, png, bmp, gif.
        /// </summary>
        /// <value>The absolute url of the image (no local file). Maximum allowed size for image is 2MB. Allowed extensions for images are - jpeg, jpg, png, bmp, gif.</value>
        /* <example>https://somedomain.com/image1.jpg</example> */
        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// Name of the image.
        /// </summary>
        /// <value>Name of the image.</value>
        /* <example>nature.jpg</example> */
        [JsonPropertyName("name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UploadImageToGallery {\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
    /// A Json converter for type <see cref="UploadImageToGallery" />
    /// </summary>
    public class UploadImageToGalleryJsonConverter : JsonConverter<UploadImageToGallery>
    {
        /// <summary>
        /// Deserializes json to <see cref="UploadImageToGallery" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UploadImageToGallery Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> imageUrl = default;
            Option<string?> name = default;

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
                        case "imageUrl":
                            imageUrl = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!imageUrl.IsSet)
                throw new ArgumentException("Property is required for class UploadImageToGallery.", nameof(imageUrl));

            if (imageUrl.IsSet && imageUrl.Value == null)
                throw new ArgumentNullException(nameof(imageUrl), "Property is not nullable for class UploadImageToGallery.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class UploadImageToGallery.");

            return new UploadImageToGallery(imageUrl.Value!, name);
        }

        /// <summary>
        /// Serializes a <see cref="UploadImageToGallery" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="uploadImageToGallery"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UploadImageToGallery uploadImageToGallery, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, uploadImageToGallery, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UploadImageToGallery" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="uploadImageToGallery"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UploadImageToGallery uploadImageToGallery, JsonSerializerOptions jsonSerializerOptions)
        {
            if (uploadImageToGallery.ImageUrl == null)
                throw new ArgumentNullException(nameof(uploadImageToGallery.ImageUrl), "Property is required for class UploadImageToGallery.");

            if (uploadImageToGallery.NameOption.IsSet && uploadImageToGallery.Name == null)
                throw new ArgumentNullException(nameof(uploadImageToGallery.Name), "Property is required for class UploadImageToGallery.");

            writer.WriteString("imageUrl", uploadImageToGallery.ImageUrl);

            if (uploadImageToGallery.NameOption.IsSet)
                writer.WriteString("name", uploadImageToGallery.Name);
        }
    }
}
