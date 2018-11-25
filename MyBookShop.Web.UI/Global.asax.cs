using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyBookShop.Web.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var builder = new ContainerBuilder();
            //注册控制器;
            Assembly controllerAss = Assembly.Load("MyBookShop.Web");
            builder.RegisterControllers(controllerAss);
            //注册仓储层；
            Assembly reposAss = Assembly.Load("MyBookShop.Repository");
            builder.RegisterTypes(reposAss.GetTypes()).AsImplementedInterfaces();
            //注册服务层;
            Assembly serviceAss = Assembly.Load("MyBookShop.Service");
            builder.RegisterTypes(serviceAss.GetTypes()).AsImplementedInterfaces();

            //创建依赖解析容器
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
