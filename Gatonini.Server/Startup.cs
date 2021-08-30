using Gatonini.Server.Extensions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Gatonini.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var GoogleClient_Id = Configuration.GetSection("ConfigSettings")["GoogleClient_Id"].ToString();
            var GoogleClient_Secret = Configuration.GetSection("ConfigSettings")["GoogleClient_Secret"].ToString();
            var FacebookClient_Id = Configuration.GetSection("ConfigSettings")["FacebookClient_Id"].ToString();
            var FacebookClient_Secret = Configuration.GetSection("ConfigSettings")["FacebookClient_Secret"].ToString();
            services.ConfigureSqlContext(Configuration);
            services.ConfigureRepositoryWrapper(Configuration);
            services.AddAuthentication()
            .AddCookie("Cook")
            //.AddGoogle(config =>
            //{
            //    config.SignInScheme = "Cook";
            //    config.ClientId = GoogleClient_Id;
            //    config.ClientSecret = GoogleClient_Secret;
            //    config.SaveTokens = true;

            //    config.ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "UserId");
            //    config.ClaimActions.MapJsonKey(ClaimTypes.Email, "EmailAddress", ClaimValueTypes.Email);
            //    config.ClaimActions.MapJsonKey(ClaimTypes.Surname, "Surname");
            //    config.ClaimActions.MapJsonKey(ClaimTypes.GivenName, "GivenName");
            //    config.Scope.Add("profile");
            //    config.Events.OnCreatingTicket = (context) =>
            //    {
            //        var picture = context.User.GetProperty("picture").GetString();
            //        context.Identity.AddClaim(new Claim("picture", picture));

            //        return Task.CompletedTask;
            //    };
            //})
            .AddFacebook(config =>
            {
                config.SignInScheme = "Cook";
                config.ClientId = FacebookClient_Id;
                config.ClientSecret = FacebookClient_Secret;
                config.SaveTokens = true;
                config.ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "UserId");
                config.ClaimActions.MapJsonKey(ClaimTypes.Email, "EmailAddress", ClaimValueTypes.Email);
                config.ClaimActions.MapJsonKey(ClaimTypes.Surname, "Surname");
                config.ClaimActions.MapJsonKey(ClaimTypes.GivenName, "GivenName");
            });
            services.AddRazorPages()
            .AddNewtonsoftJson();
            services.AddControllers().AddNewtonsoftJson();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Gatonini.Server", Version = "v1" });
            });

            var jwtsection = Configuration.GetSection("MySettings");
            services.Configure<ConfigSettings>(jwtsection);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gatonini.Server v1"));
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
