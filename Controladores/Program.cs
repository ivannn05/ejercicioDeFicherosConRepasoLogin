using ejercicioRepasoLogin.Dtos;
using ejercicioRepasoLogin.Servicios;
using System.Collections.Generic;

namespace ejercicioRepasoLogin;
class Program
{
    public static void Main(string[] args)
    {
        List<clienteDtos> listaClientes = new List<clienteDtos>();
        DateTime elHoy = DateTime.Now;
        string fecha =elHoy.ToString("ddMMyy");
       /* int dia = elHoy.Day;
        int mes = elHoy.Month;
        int anio = elHoy.Year;
        string nombre =  $"{dia}/{mes}/{anio}";*/

        //Creacion del fichero
        using StreamWriter fichero = new StreamWriter($"log-{fecha}.txt");
        fichero.WriteLine("Se ha creado el fichero ");

        int opcion;
        int opcionCliente;
        bool cerrarMenu = false;
        bool menu2 = false;
        menuInterfaz mi = new menuImplementacion();
        operativaInterfaz op = new operativaImplementacion();
        opearivaEmpleadoInterfaz oe = new operativaEmpleadoImplementacion();
        fichero.WriteLine("Se mostrara el menu pricipal ");
        while (!cerrarMenu)
        {
            opcion = mi.menuPrincipal();
            Console.WriteLine(opcion);
            switch (opcion)
            {

                case 0:
                    fichero.WriteLine("Eligio la opcion de cerrar el menu principal");
                    cerrarMenu =true;
                        break;
                case 1:
                    fichero.WriteLine("Accedio al menu de clientes");

                    while (!menu2)
                    {opcionCliente=mi.menuCliente();
                        Console.WriteLine(opcionCliente);

                        switch (opcionCliente)
                        {
                        case 0:
                                fichero.WriteLine("Eligio la opcion de cerrar el menu de cliente");
                                menu2 = true;
                             break;
                        case 1:
                                fichero.WriteLine("Eligio la opcion de registro del cliente ");
                                op.darAltaCliente(listaClientes);
                             break; 
                        case 2:
                                fichero.WriteLine("Eligio la opcion de acceder (login) a una cuenta cliente");
                                op.loginCliente( listaClientes);
                              break;

                        }

                    }
                    break;
                case 2:
                    fichero.WriteLine("Accedio al menu de empleados ");
                    mi.accederVersionEmpleado(listaClientes,fichero);
                    break;


            }


        }

        
    }
}
