using HR.Management.Application.Profiles;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HR.Management.Application
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            // the common way to configure AutoMapper
            //services.AddAutoMapper(typeof(MappingProfile));
            //A good way to configure AutoMapper not too known.
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // to help us to implement CQRS
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;

        }
    }
}
