using Microsoft.AspNetCore.Builder;
using System;

namespace Api.Extensions
{
    public static class AppBuilderExtension
    {
        public static IApplicationBuilder UseSwagger(this IApplicationBuilder app, string version, string apiName)
        {
            app.UseSwagger()
                .UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint($"/swagger/{version}/swagger.json", $"{apiName} API {version}");
                });

            return app;
        }

    }
}
