using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WorkSpace_PreAltaClientes.BusinessLayer;
using WorkSpace_PreAltaClientes.DataModel;

namespace WorkSpace_PreAltaClientes.ServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClienteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ClienteService.svc or ClienteService.svc.cs at the Solution Explorer and start debugging.
    public class ClienteService : IClienteService
    {
        public ClienteDTOResp Consultar(ClienteDTOReq req)
        {
            return new ClienteLogic().Consultar(req);
        }
        public void Grabar()
        {

        }
    }
}
