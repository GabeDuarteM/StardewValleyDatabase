using Autofac;
using Autofac.Integration.Mvc;
using StardewValleyDatabase.Models;
using StardewValleyDatabase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace StardewValleyDatabase
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            RegistrarTiposDI();
        }

        private void RegistrarTiposDI()
        {
            // Para pegar o container: 'AutofacDependencyResolver.Current'

            var builder = new ContainerBuilder();

            builder.RegisterType<Item>();
            builder.RegisterType<Models.Bundle>();
            builder.RegisterType<BundleItem>();
            builder.RegisterType<Craft>();
            builder.RegisterType<Receita>();
            builder.RegisterType<ItemViewModel>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}