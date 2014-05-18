using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.Mvc.Routes;

namespace Facebook
{
    public class Routes : IRouteProvider
    {

        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }

        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            return new[] {
                             new RouteDescriptor {
                                                     Route = new Route(
                                                         "Admin/Facebook/CheckApp",
                                                         new RouteValueDictionary {
                                                                                      {"area", "Facebook"},
                                                                                      {"controller", "Admin"},
                                                                                      {"action", "CheckApp"}
                                                                                  },
                                                         new RouteValueDictionary(),
                                                         new RouteValueDictionary {
                                                                                      {"area", "Facebook"}
                                                                                  },
                                                         new MvcRouteHandler())
                                                 },
                         };
        }
    }
}