using System;
using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Inspe.Common;
using Inspe.Common.Dispatchers;
using Inspe.Common.Mvc;
using Inspe.Common.RabbitMq;
using Inspe.Common.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace STM.Api
{
    public class Startup
    {
        public IContainer Container { get; private set; }
        public IConfiguration Configuration { get; }
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddCustomMvc();
            services.AddSwaggerDocs();
            services.AddOpenTracing();
            
            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterAssemblyTypes(Assembly.GetEntryAssembly())
                .AsImplementedInterfaces();
            builder.AddRabbitMq();
            builder.AddDispatchers();
            
            Container = builder.Build();

            return new AutofacServiceProvider(Container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, 
            IStartupInitializer startupInitializer, IApplicationLifetime applicationLifetime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwaggerDocs();
            app.UseHttpsRedirection();
            app.UseErrorHandler();
            app.UseMvc();
            app.UseRabbitMq();
            
            applicationLifetime.ApplicationStopped.Register(() => 
            {
                Container.Dispose(); 
            });
            startupInitializer.InitializeAsync();
        }
    }
}
