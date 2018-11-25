using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyBookShop.Admin.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //注册控制器
            var builder = new ContainerBuilder();
            Assembly controllerAss = Assembly.Load("MyBookShop.Admin");
            builder.RegisterControllers(controllerAss);

            //注册数据层
            Assembly reposAss = Assembly.Load("MyBookShop.Repository");
            builder.RegisterTypes(reposAss.GetTypes()).AsImplementedInterfaces();

            //注册业务层:
            Assembly serviceAss = Assembly.Load("MyBookShop.Service");
            builder.RegisterTypes(serviceAss.GetTypes()).AsImplementedInterfaces();

            //交由Autofac管理依赖
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
