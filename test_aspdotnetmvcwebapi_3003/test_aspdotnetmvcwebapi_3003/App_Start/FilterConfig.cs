using System.Web;
using System.Web.Mvc;

namespace test_aspdotnetmvcwebapi_3003
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
