﻿using Ilaro.Admin;
using Ilaro.Sample.Models.Northwind;
using Ilaro.Sample.Models.Northwind.Entities;
using Ilaro.Web.Sample.Models.Northwind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Ilaro.Web.Sample
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
			AreaRegistration.RegisterAllAreas();

			AdminInitialise.RegisterRoutes(RouteTable.Routes, "Admin");
			AdminInitialise.RegisterResourceRoutes(RouteTable.Routes);

            RegisterRoutes(RouteTable.Routes);

            AdminInitialise.AddEntity<Customer>();
            AdminInitialise.AddEntity<Employee>();
            AdminInitialise.AddEntity<Order>();
            AdminInitialise.AddEntity<OrderDetail>();
			AdminInitialise.AddEntity<Product>();
			AdminInitialise.AddEntity<EntityChange>();

			// If you have only one connection string there is no need to specify it
            AdminInitialise.Initialise("NorthwindEntities");
        }

		private void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
    }
}