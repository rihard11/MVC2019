using System.Web;
using System.Web.Mvc;

namespace _5._3._1_stranice_s_layoutom
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
