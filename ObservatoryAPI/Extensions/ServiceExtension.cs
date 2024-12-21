using ObservatoryAPI.DataAccess.Repository.Interfaces;
using ObservatoryAPI.DataAccess.Repository;
using ObservatoryAPI.BLL.Services.Interfaces;
using ObservatoryAPI.BLL.Services;
using Microsoft.OpenApi.Models;

namespace ObservatoryAPI.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IEquipmentRepository, EquipmentRepository>();
        services.AddScoped<IObservationOrderRepository, ObservationOrderRepository>();
        services.AddScoped<IObservationRepository, ObservationRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ISpaceObjectRepository, SpaceObjectRepository>();
        services.AddScoped<IResearchRepository, ResearchRepository>();
        return services;
    }
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IEquipmentService, EquipmentService>();
        services.AddScoped<IObservationOrderService, ObservationOrderService>();
        services.AddScoped<IObservationService, ObservationService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ISpaceObjectService, SpaceObjectService>();
        services.AddScoped<IResearchService, ResearchService>();
        return services;
    }
    public static IServiceCollection AddSwaggerAuthenticationUi(this IServiceCollection services)
    {
        services.AddSwaggerGen(swagger =>
        {
            //This is to generate the Default UI of Swagger Documentation
            swagger.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "JWT Token Authentication API",
                Description = ".NET 8 Web API"
            });
            // To Enable authorization using Swagger (JWT)
            swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
            });
            swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
            });
        });

        return services;
    }
}
