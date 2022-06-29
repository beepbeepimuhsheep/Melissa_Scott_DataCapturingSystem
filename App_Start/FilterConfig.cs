using System.Web;
using System.Web.Mvc;

namespace Melissa_Scott_9189_IPG521_FA1_Final
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
