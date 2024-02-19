using ejercicioRepasoLogin.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicioRepasoLogin.Dtos;

namespace ejercicioRepasoLogin.Servicios
{
    internal interface opearivaEmpleadoInterfaz
    {
        public void validarCliente(List<clienteDtos> listaClientes);
        public void borrarCliente(List<clienteDtos> listaClientes);
        public void mostrarClientes(List<clienteDtos> listaClientes);
    }
}
