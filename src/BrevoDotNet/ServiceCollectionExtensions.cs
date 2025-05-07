using System.Text.Json;
using BrevoDotNet.Api;
using BrevoDotNet.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using static BrevoDotNet.Client.ClientUtils;

namespace BrevoDotNet
{
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBrevo(this IServiceCollection services, IConfiguration configuration, string apiKey)
    {
        services.AddSingleton<JsonSerializerOptionsProvider>(provider =>
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,
                // ... other config
            };
            return new JsonSerializerOptionsProvider(options);
        });

        services.AddHttpClient();

        services.AddTransient<SMTPApiEvents>();

        services.AddSingleton<TokenProvider<ApiKeyToken>, RateLimitProvider<ApiKeyToken>>(
            x =>
            {
                var apiKeyToken = new ApiKeyToken(apiKey, ApiKeyHeader.Api_key);
                return new RateLimitProvider<ApiKeyToken>(new TokenContainer<ApiKeyToken>(new [] { apiKeyToken }));
            });

        services.AddTransient<SMTPApi>();

        return services;
    }
}
}