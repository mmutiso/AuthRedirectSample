using System.Web;
using System.Web.Mvc;

namespace WebApplication1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ResultCatcherFilter());
            filters.Add(new CustomExceptionFilter());
            filters.Add(new AuthCatcherFilter());
        }
    }
}
