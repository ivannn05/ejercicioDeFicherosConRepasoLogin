using ejercicioRepasoLogin.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepasoLogin.Servicios
{
    internal class menuImplementacion : menuInterfaz
    {
        public int menuCliente()
        {
            int opcionCliente;
            Console.WriteLine("\tSelecciones una opcion ");
            Console.WriteLine("\t0.Cerrar Menu");
            Console.WriteLine("\t1.Registro de cliente");
            Console.WriteLine("\t2.Acceso a cliente existente ");
            opcionCliente = Convert.ToInt32(Console.ReadLine());
            return opcionCliente;
        }

        public int menuPrincipal()
        {
            int opcionCliente;
            Console.WriteLine("\tSelecciones una opcion de inicio");
            Console.WriteLine("\t0.Cerrar Menu");
            Console.WriteLine("\t1.Entrar modo cliente");
            Console.WriteLine("\t2.Entrar modo empleado");
            opcionCliente = Convert.ToInt32(Console.ReadLine());
            return opcionCliente;
        }
        public void accederVersionEmpleado(List<clienteDtos> listaClientes, StreamWriter fichero)
        {
            opearivaEmpleadoInterfaz ei = new operativaEmpleadoImplementacion();

            int opcionEmpleado;
            opcionEmpleado = mostrarMenuEmpleadoYSeleccion();

            switch (opcionEmpleado)
            {
                case 0:
                    fichero.WriteLine("Eligio salir del menu de cliente");
                    break;
                case 1:
                    fichero.WriteLine("Eligio la opcion de validar un cliente ");
                    ei.validarCliente(listaClientes);
                    break;
                case 2:
                    fichero.WriteLine("Eligio la opcion de borrar a un cliente ");
                    ei.borrarCliente(listaClientes);
                    break;
                case 3:
                    fichero.WriteLine("Eligio la opcion de mostrar a un cliente ");
                    ei.mostrarClientes(listaClientes);
                    break;
                default:
                    fichero.WriteLine("Eligio una opcion la cual no existe en el menu de cliente ");
                    Console.WriteLine("No ha seleccionado una opción aceptable vuelve al menú inicial.");
                    break;
            }
        }
        private int mostrarMenuEmpleadoYSeleccion()
        {
            int opcion;

            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Validar cliente");
            Console.WriteLine("2. Borrar cliente");
            Console.WriteLine("3. Mostrar clientes");
            Console.WriteLine("Escriba la opción deseada: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
