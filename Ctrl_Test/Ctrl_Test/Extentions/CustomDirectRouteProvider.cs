using System.Collections.Generic;
using System.Web.Mvc.Routing;

namespace Ctrl_Test.Extentions
{
	public class CustomDirectRouteProvider: DefaultDirectRouteProvider
	{
		protected override IReadOnlyList<IDirectRouteFactory> GetActionRouteFactories(System.Web.Mvc.ActionDescriptor actionDescriptor)
		{
			// return base.GetActionRouteFactories(actionDescriptor);

			// inherit route attributes decorated on base class controller's actions
			return actionDescriptor.GetCustomAttributes(typeof(IDirectRouteFactory), true) as IReadOnlyList<IDirectRouteFactory>;
		}
	}
}