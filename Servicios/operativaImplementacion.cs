using ejercicioRepasoLogin.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepasoLogin.Servicios
{
    internal class operativaImplementacion : operativaInterfaz
    {

        public void darAltaCliente(List<clienteDtos> listaClientes)
        {
            clienteDtos cliente = registroCliente(listaClientes);
            listaClientes.Add(cliente);
        }
        private clienteDtos registroCliente(List<clienteDtos> listaClientes)
        {
            clienteDtos cliente = new clienteDtos();

            Console.WriteLine("Introduzca su DNI");
            cliente.DniCliente = Console.ReadLine();
            Console.WriteLine("Introduzca su Nombre completo (con espacio por separación y formato: nombre apellido1 y apellido2)");
            cliente.NombreCompletoCliente= Console.ReadLine();
            Console.WriteLine("Introduzca su email");
            cliente.EmailCliente = Console.ReadLine();
            Console.WriteLine("Introduzca su contraseña");
            cliente.ContraseniaCliente = Console.ReadLine();
            cliente.EsValidado = false;
            if (listaClientes.Count == 0)
            {
                cliente.IdCliente=1;
            }
            else
            {
                int posicion = listaClientes.Count - 1;
                long nuevoId = listaClientes[posicion].IdCliente + 1;
                cliente.IdCliente = nuevoId;
            }
            return cliente;
        }

        public void registroEmpleado(List<clienteDtos> listaClientes)
        {
            throw new NotImplementedException();
        }

        public void loginCliente(List<clienteDtos> listaClientes)
        {
            

            Console.WriteLine("Introduzca su email");
            string emailCliente = Console.ReadLine();

            Console.WriteLine("Introduzca su contraseña");
            string contrasenia = Console.ReadLine();

            for(int i = 0; i < listaClientes.Count; i++)
            {
               
                if (emailCliente.Equals(listaClientes[i].EmailCliente) & contrasenia.Equals(listaClientes[i].ContraseniaCliente))
                {
                    Console.WriteLine("INICIO DE SESIÓN CORRECTO");
                }
                else { Console.WriteLine("INICIO DE SESIÓN NO ES CORRECTO"); }
            }

           

        }

       
    }
}
