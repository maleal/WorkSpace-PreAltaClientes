using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkSpace_PreAltaClientes.BusinessLayer;
using WorkSpace_PreAltaClientes.Web.Models;

namespace WorkSpace_PreAltaClientes.Web.Controllers
{
    public class HomeController : Controller
    {
        private ClienteViewModel model = new ClienteViewModel();

        public ActionResult Index()
        {

            if(TempData["cuit_selected"] != null )
            {
                ClienteServiceReference.ClienteDTO dto = new ClienteServiceReference.ClienteDTO();
                ClienteServiceReference.ClienteDTOResp resp = new ClienteServiceReference.ClienteDTOResp();
                ClienteServiceReference.ClienteDTOReq req = new ClienteServiceReference.ClienteDTOReq()
                {
                    clientes = new ClienteServiceReference.ListaClientes(),
                };

                using (ClienteServiceReference.ClienteServiceClient serviceCliente = new ClienteServiceReference.ClienteServiceClient())
                {
                    req.Operacion = Constantes.Cliente.CONSULTAR_CON_CUIT;
                    //dto.Cuit = "20123456784";
                    dto.Cuit = TempData["cuit_selected"] as string;
                    req.clientes.Add(dto);
                    resp = serviceCliente.Consultar(req);
                }

                if (resp.clientes != null && resp.clientes.Count() > 0)
                {
                    dto = resp.clientes[0];
                    model.nombre = dto.NombreClte;
                    model.razon_social = dto.Razon_social;
                    model.cuit = dto.Cuit;
                    model.email = dto.Email;
                }

            } else {
                return RedirectToAction("Index", "Clientes");
            }

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}