using Fathym.IoC;
using Fathym.Service;
using System;
using System.Web.Http;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(WebApplication1.Startup), "PostStart")]
namespace WebApplication1
{
    public static class Startup
    {
        public static void PostStart()
        {
            Configure();
        }

        public static void Configure()
        {
            UnityConfigurationProvider.ConfigurationProvider.Configure(GlobalConfiguration.Configuration);

            JsonSerializationProvider.SerializationProvider.ConfigureSerialization(GlobalConfiguration.Configuration);

            GlobalConfiguration.Configure(WebApiConfigurationProvider.ConfigurationProvider.Configure);
        }
    }
}