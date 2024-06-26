using System.Reflection;
using RestoRite_BusinessAccessLayer.IServices;
using RestoRite_BusinessAccessLayer.Profiles;
using RestoRite_Common.Constants;
using RestoRite_DataAccessLayer.Data;
using RestoRite_DataAccessLayer.IRepositories;
using RestoRite_DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace RestoRite_Api.Extensions
{
    public static class ApplicationBuilderConfiguration
    {
        public static void RegisterDatabaseConnection(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString(SystemConstants.DEFAULT_CONNECTION));
            });
        }

        public static void RegisterUnitOfWork(this IServiceCollection services) => services.AddScoped<IUnitOfWork, UnitOfWork>();

        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
        }

        public static void SetRequestBodySize(this IServiceCollection services)
        {
            services.Configure<IISServerOptions>(options =>
            {
                options.MaxRequestBodySize = int.MaxValue;
            });
        }

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            IEnumerable<Type> implementationTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IBaseService<>)));

            foreach (Type implementationType in implementationTypes)
            {
                Type[] implementedInterfaces = implementationType.GetInterfaces();
                foreach (Type implementedInterface in implementedInterfaces)
                {
                    if (implementedInterface.IsGenericType)
                    {
                        Type openGenericInterface = implementedInterface.GetGenericTypeDefinition();
                        if (openGenericInterface == typeof(IBaseService<>))
                        {
                            services.AddScoped(implementedInterface, implementationType);
                        }
                    }
                }
            }

            services.Scan(scan =>
            {
                scan.FromAssembliesOf(typeof(IBaseService<>))
                    .AddClasses()
                    .AsImplementedInterfaces()
                    .WithScopedLifetime();
            });

            services.AddHttpContextAccessor();
        }
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(SystemConstants.CORS_POLICY,
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                  );
            });
        }
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "RestoRite v1",
                    Version = "v1"
                });
            });
        }
    }
}