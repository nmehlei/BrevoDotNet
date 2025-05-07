docker run --rm -v "$(pwd):/local" openapitools/openapi-generator-cli generate \
    -i https://api.brevo.com/v3/swagger_definition.yml \
    -g csharp \
    -o /local/ \
    -p packageName=BrevoDotNet \
    -c /local/generation-config.json \
    --ignore-file-override=/local/.openapi-generator-ignore