using Autofac;
using Autofac.Integration.Mvc;
using StardewValleyDatabase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StardewValleyDatabase.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Helpers.Helper.GerarJsonComArquivosStardew();
            return View(AutofacDependencyResolver.Current.ApplicationContainer.Resolve<ItemViewModel>());
        }
    }
}