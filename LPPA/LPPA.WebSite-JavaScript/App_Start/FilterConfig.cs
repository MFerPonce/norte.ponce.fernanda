using System.Web;
using System.Web.Mvc;

namespace LPPA.WebSite_JavaScript
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
