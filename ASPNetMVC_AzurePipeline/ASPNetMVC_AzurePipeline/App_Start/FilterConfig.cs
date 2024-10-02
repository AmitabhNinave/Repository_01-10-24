using System.Web;
using System.Web.Mvc;

namespace ASPNetMVC_AzurePipeline
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
