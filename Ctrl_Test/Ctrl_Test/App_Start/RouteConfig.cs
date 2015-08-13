using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ctrl_Test.Extentions;

namespace Ctrl_Test
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.LowercaseUrls = true;
			// passing CustomDirectRouteProvider so we can have inheritance in our controllers
			routes.MapMvcAttributeRoutes(new CustomDirectRouteProvider());


			// everything with attributes
			//routes.MapRoute(
			//	name: "Dashboard_route",
			//	url: "Dashboard/{action}",
			//	defaults: new {area="Dashboard", controller = "Dashboard", action = "Index"}
			//);
		}
	}
}
