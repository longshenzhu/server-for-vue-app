using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace webForVueApp2017
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务
            SetCors(config);
            SetFormmatters(config);

            // Web API 路由
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "AreaApi",
            //    routeTemplate: "api/{area}/{controller}/{action}",
            //    defaults: new { }
            //);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { }
            );
        }

        public static void SetFormmatters(HttpConfiguration config)
        {
            //默认支持xml、json返回格式，去掉xml，在项目中可自定义输出格式
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            //GlobalConfiguration.Configuration.Formatters.Add(new JsonMediaTypeFormatter());
        }

        public static void SetCors(HttpConfiguration config)
        {
            //https://msdn.microsoft.com/en-us/magazine/dn532203.aspx
            //config.EnableCors();
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
        }
    }
}
