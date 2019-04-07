using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkSpace_PreAltaClientes.BusinessLayer;
using WorkSpace_PreAltaClientes.Web.Models;

namespace WorkSpace_PreAltaClientes.Web.Controllers
{
    public class ClientesController : Controller
    {
        List<Clientes> vmodel = new List<Clientes>();
        // GET: Clientes
        public ActionResult Index()
        {
            

            ClienteServiceReference.ClienteDTOReq req = new ClienteServiceReference.ClienteDTOReq()
            {
                clientes = new ClienteServiceReference.ListaClientes()
            };
            
            ClienteServiceReference.ClienteDTOResp resp = new ClienteServiceReference.ClienteDTOResp();

            using(ClienteServiceReference.ClienteServiceClient service = new ClienteServiceReference.ClienteServiceClient())
            {
                req.Operacion = Constantes.Cliente.CONSULTAR_TODOS;
                resp = service.Consultar(req);
            }

            if(resp.clientes != null && resp.clientes.Count() > 0 )
            {
                foreach(ClienteServiceReference.ClienteDTO dto in resp.clientes)
                {
                    Clientes model = new Clientes();
                    model.id = dto.ID;
                    model.cuit = dto.Cuit;
                    model.razon_social = dto.Razon_social;
                    vmodel.Add(model);
                }
            }
            return View(vmodel);
        }
        [HttpPost]
        public ActionResult Index(string clientes_select_list)
        {
            //int x = cmodel.id;
            //string xx = cmodel.cuit;
            string cuit = clientes_select_list;
            TempData["cuit_selected"] = cuit; // clientes_select_list;
            return RedirectToAction("Index", "Home");
        }

    }
}
