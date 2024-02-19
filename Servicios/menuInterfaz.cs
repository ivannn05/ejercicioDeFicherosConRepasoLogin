using ejercicioRepasoLogin.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepasoLogin.Servicios
{
    internal interface menuInterfaz
    {
        public int menuPrincipal();
        public int menuCliente();
        public void accederVersionEmpleado(List<clienteDtos> listaClientes, StreamWriter fichero);
    }
}
