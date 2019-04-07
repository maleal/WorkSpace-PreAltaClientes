using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSpace_PreAltaClientes.DataLayer;
using WorkSpace_PreAltaClientes.DataModel;

namespace WorkSpace_PreAltaClientes.BusinessLayer
{
    public class ClienteLogic : BaseBusinessLayer<ClienteDTOReq, ClienteDTOResp>
    {
        ClienteDataLayer cliente = new ClienteDataLayer();

        public override ClienteDTOResp Consultar(ClienteDTOReq req)
        {
            ClienteDTOResp resp = new ClienteDTOResp();

            switch (req.Operacion)
            {
                case Constantes.Cliente.CONSULTAR_CON_CUIT:
                    resp = ConsultarConCuit(req);
                    break;
                case Constantes.Cliente.CONSULTAR_TODOS:
                    resp = ConsultarTodos();
                    break;
                default:
                    break;
            }
            return resp;// base.Consultar(req);
        }

        public ClienteDTOResp ConsultarConCuit(ClienteDTOReq req)
        {
            ClienteDTOResp resp = new ClienteDTOResp();


            resp.clientes = cliente.ObtenerCliente( req.clientes[0].Cuit );
            return resp;
        }

        public ClienteDTOResp ConsultarTodos()
        {
            ClienteDTOResp resp = new ClienteDTOResp();

            resp.clientes = cliente.ObtenerTodos();

            return resp;
        }
    }

    
}
