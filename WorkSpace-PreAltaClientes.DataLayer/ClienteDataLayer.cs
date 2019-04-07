using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSpace_PreAltaClientes.DataModel;

namespace WorkSpace_PreAltaClientes.DataLayer
{
    public class ClienteDataLayer
    {
        CliConnEntities en = new CliConnEntities();
        
        public ListaClientes ObtenerCliente(string cuit)
        {
            ListaClientes cliente = new ListaClientes();
            
            var tablaCliente = from clte in en.Clientes where clte.Cuit == cuit select clte;
            ClienteDTO dto = new ClienteDTO();
            dto.MyProducts = new List<ProductDTO>();
            foreach (var reg in tablaCliente)
            {
                
                dto.ID = reg.Id;
                dto.NombreClte = reg.Nombre;
                dto.Razon_social = reg.RazonSocial;
                dto.DateCreated = reg.DateCreated;
                dto.Cuit = reg.Cuit;
                dto.Email = reg.EmailClient;

                foreach(var p in reg.Products) {
                    ProductDTO pDto = new ProductDTO()
                    {
                        ProductName = p.ProductName
                    };
                    dto.MyProducts.Add(pDto);
                }

                cliente.Add(dto);
            }

            //foreach(Cliente prod in tablaCliente)



            return cliente;
        }

        public ListaClientes ObtenerTodos()
        {
            ListaClientes clientes = new ListaClientes();

            var tablaCliente = from clte in en.Clientes select clte;
            
            foreach(Cliente reg in tablaCliente)
            {
                ClienteDTO dto = new ClienteDTO();
                dto.ID = reg.Id;
                dto.Cuit = reg.Cuit;
                dto.Razon_social = reg.RazonSocial;
                clientes.Add(dto);
            }
            return clientes;
        }
    }
}
