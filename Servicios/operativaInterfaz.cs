using ejercicioRepasoLogin.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepasoLogin.Servicios
{
    internal interface operativaInterfaz
    {
        public void darAltaCliente(List<clienteDtos> listaClientes);
        public void registroEmpleado(List<clienteDtos> listaClientes);


       
        public void loginCliente(List<clienteDtos> listaClientes);

    }
}
