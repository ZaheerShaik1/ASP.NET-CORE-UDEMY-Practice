
using System.Text.RegularExpressions;

namespace RoutingExample.CustomeConstraints
{
    public class MonthCustomConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (values.ContainsKey(routeKey))
            {
                return false;
            
            }
            Regex regex = new Regex("^(apr|nov|july|dec)$");
            string? monthValue = Convert.ToString(values[routeKey]);

            if (regex.IsMatch(monthValue)) 
            {
                return true;
            }
            return false;
        }
    }
}
