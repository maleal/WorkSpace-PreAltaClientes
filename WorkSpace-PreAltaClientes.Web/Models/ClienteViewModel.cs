using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkSpace_PreAltaClientes.Web.Models
{
    public class ClienteViewModel
    {
        public int id { get; set; }
        [DisplayName("Nombre")]
        public string nombre { get; set; }
        public string cuit { get; set; }
        public string razon_social { get; set; }
        public string email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }
    }
}