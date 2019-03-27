using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using FiltersAndAuth.Models;
using FiltersAndAuth.Providers;
using Microsoft.Ajax.Utilities;

namespace FiltersAndAuth
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //ValueProviderFactories.Factories.Add(new BrowserValueProviderFactory());
            ModelBinders.Binders.Add(typeof(Book), new MyModelBinder());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            
        }
    }
}
