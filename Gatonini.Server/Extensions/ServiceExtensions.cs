using Contracts;
using Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using AutoMapper;
using Gatonini.Server;

namespace Gatonini.Server.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(configuration.GetConnectionString("DbConnection")));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services, IConfiguration config)
        {
            var key = config.GetSection("ConfigSettings")["Key"].ToString();
            var hostName = config.GetSection("ConfigSettings")["HostName"].ToString();
            services.AddAuthentication(opt => {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = hostName,
                    ValidAudience = hostName,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
                };
            });

            //services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.Configure<ConfigSettings>(config.GetSection("ConfigSettings"));
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IConfigSettings, ConfigSettings>();
            services.AddScoped<IFacebook, FacebookService>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            services.AddScoped(typeof(IGenericRepository<,,>), typeof(GenericRepository<,,>));
            services.AddScoped(typeof(IGenericRepository<,,,>), typeof(GenericRepository<,,,>));
            services.AddScoped(typeof(IGenericRepository<,,,,>), typeof(GenericRepository<,,,,>));
            services.AddScoped(typeof(IGenericRepository<,,,,,>), typeof(GenericRepository<,,,,,>));
            services.AddScoped(typeof(IGenericRepository<,,,,,,>), typeof(GenericRepository<,,,,,,>));
            services.AddScoped(typeof(IGenericRepository<,,,,,,,>), typeof(GenericRepository<,,,,,,,>));
            services.AddScoped(typeof(IGenericRepository<,,,,,,,,>), typeof(GenericRepository<,,,,,,,,>));
            services.AddScoped(typeof(IGenericRepository<,,,,,,,,,>), typeof(GenericRepository<,,,,,,,,,>));
            services.AddScoped(typeof(IGenericRepository<,,,,,,,,,,>), typeof(GenericRepository<,,,,,,,,,,>));
            services.AddScoped(typeof(IGenericRepository<,,,,,,,,,,,>), typeof(GenericRepository<,,,,,,,,,,,>));
            services.AddScoped(typeof(IGenericController<>), typeof(GenericController<>));
            services.AddScoped(typeof(IGenericController<,>), typeof(GenericController<,>));
            services.AddScoped(typeof(IGenericController<,,>), typeof(GenericController<,,>));
            services.AddScoped(typeof(IGenericController<,,,>), typeof(GenericController<,,,>));
            services.AddScoped(typeof(IGenericController<,,,,>), typeof(GenericController<,,,,>));
            services.AddScoped(typeof(IGenericController<,,,,,>), typeof(GenericController<,,,,,>));
            services.AddScoped(typeof(IGenericController<,,,,,,>), typeof(GenericController<,,,,,,>));
            services.AddScoped(typeof(IGenericController<,,,,,,,>), typeof(GenericController<,,,,,,,>));
            services.AddScoped(typeof(IGenericController<,,,,,,,,>), typeof(GenericController<,,,,,,,,>));
            services.AddScoped(typeof(IGenericController<,,,,,,,,,>), typeof(GenericController<,,,,,,,,,>));
            services.AddScoped(typeof(IGenericController<,,,,,,,,,,>), typeof(GenericController<,,,,,,,,,,>));
            services.AddScoped(typeof(IGenericController<,,,,,,,,,,,>), typeof(GenericController<,,,,,,,,,,,>));
            services.AddScoped(typeof(IGenericRepositoryWrapper<>), typeof(GenericRepositoryWrapper<>));
            services.AddScoped(typeof(IGenericRepositoryWrapper<,>), typeof(GenericRepositoryWrapper<,>));
            services.AddScoped(typeof(IGenericRepositoryWrapper<,,>), typeof(GenericRepositoryWrapper<,,>));
            services.AddScoped(typeof(IGenericRepositoryWrapper<,,,>), typeof(GenericRepositoryWrapper<,,,>));
            services.AddScoped(typeof(IGenericRepositoryWrapper<,,,,>), typeof(GenericRepositoryWrapper<,,,,>));
            services.AddScoped(typeof(IGenericRepositoryWrapper<,,,,,>), typeof(GenericRepositoryWrapper<,,,,,>));
            services.AddScoped(typeof(IGenericRepositoryWrapper<,,,,,,>), typeof(GenericRepositoryWrapper<,,,,,,>));
            services.AddScoped(typeof(IGenericRepositoryWrapper<,,,,,,,>), typeof(GenericRepositoryWrapper<,,,,,,,>));
            services.AddScoped(typeof(IGenericRepositoryWrapper<,,,,,,,,>), typeof(GenericRepositoryWrapper<,,,,,,,,>));
            services.AddScoped(typeof(IGenericRepositoryWrapper<,,,,,,,,,>), typeof(GenericRepositoryWrapper<,,,,,,,,,>));
            services.AddScoped(typeof(IGenericRepositoryWrapper<,,,,,,,,,,>), typeof(GenericRepositoryWrapper<,,,,,,,,,,>));
            services.AddScoped(typeof(IGenericRepositoryWrapper<,,,,,,,,,,,>), typeof(GenericRepositoryWrapper<,,,,,,,,,,,>));

        }

        public static void ConfigureAuthentication(this IServiceCollection services)
        {
            
        }
    }
}
