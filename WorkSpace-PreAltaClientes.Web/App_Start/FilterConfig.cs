using System.Web;
using System.Web.Mvc;

namespace WorkSpace_PreAltaClientes.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
