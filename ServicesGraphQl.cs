using System;
using Api.Facebook.GraphQL.Schemas;
using Api.Facebook.Repository;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Facebook
{
    public static class ServicesGraphQl
    {
        public static void AddGraphQl(this IServiceCollection services)
        {
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddScoped<PostSchema>();

            services.AddGraphQL(o => { o.ExposeExceptions = false; })
                .AddGraphTypes(ServiceLifetime.Scoped);
        }
    }

    public static class ServicesRepository
    {
        public static void AddRespository(this IServiceCollection services)
        {
            services.AddSingleton<IPostRepository, PostRepository>();
        }
    }

    public static class GraphQlMiddleWareExtension
    {
        public static IApplicationBuilder UseGraphQL(this IApplicationBuilder app)
        {
            app.UseGraphQL<PostSchema>();
            app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());
            return app;
        }
    }
}
