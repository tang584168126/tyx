using System.Web;
using System.Web.Mvc;
using Friends.Web.Filters;
namespace Friends.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            
            filters.Add(new HandleErrorAttribute());

            filters.Add(new VisitLoggerFilter());
            
            
           
        }
    }
}