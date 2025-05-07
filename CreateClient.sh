docker run --rm -v "$(pwd):/local" openapitools/openapi-generator-cli generate \
    -i https://api.brevo.com/v3/swagger_definition.yml \
    -g csharp \
    -o /local/src/BrevoDotNet.Client \
    -p packageName=BrevoDotNet.Client \
    -c /local/generation-config.json