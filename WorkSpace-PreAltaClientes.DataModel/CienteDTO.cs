using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace_PreAltaClientes.DataModel
{
    [DataContract]
    public class ClienteDTO : CatalogoBase
    {
        [DataMember]
        public string NombreClte { get; set; }
        [DataMember]
        public string Cuit { get; set; }
        [DataMember]
        public string Razon_social { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public DateTime DateCreated { get; set; }

        [DataMember]
        public List<ProductDTO> MyProducts { get; set; }
    }

    [CollectionDataContract]
    public class ListaClientes : List<ClienteDTO>
    {
    }

    [DataContract]
    public class ClienteDTOReq : CatalogoReqBase
    {
        [DataMember]
        public ListaClientes clientes { get; set; }
    }

    [DataContract]
    public class ClienteDTOResp : CatalogoRespBase
    {
        [DataMember]
        public ListaClientes clientes { get; set; }
    }

}
