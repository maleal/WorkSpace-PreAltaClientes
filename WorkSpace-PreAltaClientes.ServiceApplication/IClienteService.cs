using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WorkSpace_PreAltaClientes.DataModel;

namespace WorkSpace_PreAltaClientes.ServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClienteService" in both code and config file together.
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        ClienteDTOResp Consultar(ClienteDTOReq req);
        [OperationContract]
        void Grabar();
    }
}
