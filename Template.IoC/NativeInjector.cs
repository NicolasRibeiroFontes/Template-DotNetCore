using Microsoft.Extensions.DependencyInjection;
using System;
using Template.Application.Interfaces;
using Template.Application.Services;

namespace Template.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {

            services.AddScoped<IUserService, UserService>();

        }
    }
}
