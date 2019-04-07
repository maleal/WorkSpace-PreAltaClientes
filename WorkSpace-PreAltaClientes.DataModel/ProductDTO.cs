using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace_PreAltaClientes.DataModel
{
    [DataContract]
    public class ProductDTO : CatalogoBase
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int ProductCategoryId { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public int ClienteId { get; set; }
    }
    [CollectionDataContract]
    public class ListaProduct : List<ProductDTO>
    {

    }

    [DataContract]
    public class ProductReq : CatalogoReqBase
    {
        [DataMember]
        ListaProduct productos { get; set; }
    }

    [DataContract]
    public class ProductResp : CatalogoRespBase
    {
        [DataMember]
        ListaProduct productos { get; set; }
    }
}
