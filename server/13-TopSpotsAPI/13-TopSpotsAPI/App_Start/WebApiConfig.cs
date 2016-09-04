using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace _13_TopSpotsAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var policy New Enable Cors Attribute  ("*","*","*")
                config.EnableCors(policy)
            // Web API routes
            c onfig.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
