using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportePublico;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string mensajeIngresado;
            int opcion;
            string datoIngresado;
            int datoNumerico;
            const int LIMITEMAXIMO = 5;
            List<Omnibus> omnibuses = new List<Omnibus>();
            List<Taxi> autos = new List<Taxi>();
            Console.Title = "Transporte app por Cristian Corsaro";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            do
            {
                Console.Clear();
                Console.WriteLine("**************************************************************");
                Console.WriteLine("*                                                            *");
                Console.WriteLine("* 1-Alta omnibus:                                            *");
                Console.WriteLine("* 2-Alta taxi:                                               *");
                Console.WriteLine("* 3-Baja omnibus:                                            *");
                Console.WriteLine("* 4-Baja taxi:                                               *");
                Console.WriteLine("* 5-Mostrar omnibus:                                         *");
                Console.WriteLine("* 6-Mostrar taxi:                                            *");
                Console.WriteLine("* 7-Mostrar todo:                                            *");
                Console.WriteLine("* 8-Salir:                                                   *");
                Console.WriteLine("*                                                            *");
                Console.WriteLine("**************************************************************");
                mensajeIngresado = Console.ReadLine();
                while (!int.TryParse(mensajeIngresado, out opcion))
                {
                    Console.WriteLine("Error. Debe ingresar un número.");
                    mensajeIngresado = Console.ReadLine();

                    if (mensajeIngresado.ToLower() == "salir")
                    {
                        Environment.Exit(0);
                    }
                }
                if (opcion < 9 && opcion > 0)
                {
                    switch (opcion)
                    {
                        case 1:
                            if (omnibuses.Count == LIMITEMAXIMO)
                            {
                                Console.WriteLine("Ya tenemos 5 omnibus");
                            }
                            else
                            {
                                datoNumerico = ValidarPasajeros(100);
                                nombre = ValidarNombreOmnibus(omnibuses);
                                Omnibus omnibus = new Omnibus(datoNumerico, nombre);
                                omnibuses.Add(omnibus);
                                Console.WriteLine(omnibus.Avanzar());
                                Console.WriteLine("{0} con {1} pasajeros", omnibus.Nombre, omnibus.Pasajeros);
                            }
                            break;
                        case 2:
                            if (autos.Count == LIMITEMAXIMO)
                            {
                                Console.WriteLine("Ya tenemos 5 taxis");
                            }
                            else
                            {
                                datoNumerico = ValidarPasajeros(4);
                                nombre = ValidarNombreTaxi(autos);
                                Taxi taxi = new Taxi(datoNumerico, nombre);
                                autos.Add(taxi);
                                Console.WriteLine(taxi.Avanzar());
                                Console.WriteLine("{0} con {1} pasajeros", taxi.Nombre, taxi.Pasajeros);
                            }
                            break;
                        case 3:
                            Console.WriteLine("¿Cual omnibus quiere dar de baja?");
                            datoIngresado = Console.ReadLine();
                            bool nombreNoEncontrado=true;
                            for(int i = 0; i < omnibuses.Count; i++)
                            {
                                if(datoIngresado == omnibuses[i].Nombre)
                                {
                                    Console.WriteLine(omnibuses[i].Detenerse());
                                    omnibuses.RemoveAt(i);
                                    nombreNoEncontrado = false;
                                    break;
                                }
                                
                            }
                            if (nombreNoEncontrado)
                            {
                                Console.WriteLine("No existe una unidad con ese nombre");
                            }
                            break;
                        case 4:
                            Console.WriteLine("¿Cual taxi quiere dar de baja?");
                            datoIngresado = Console.ReadLine();
                            bool taxiNoEncontrado = true;
                            for (int i = 0; i < autos.Count; i++)
                            {
                                if (datoIngresado == autos[i].Nombre)
                                {
                                    Console.WriteLine(autos[i].Detenerse());
                                    autos.RemoveAt(i);
                                    taxiNoEncontrado = false;
                                    break;
                                }
                            }

                            if (taxiNoEncontrado)
                            {
                                Console.WriteLine("No existe Taxi con ese nombre");
                            }
                            break;
                        case 5:
                            MostrarOmnibus(omnibuses);
                            break;
                        case 6:
                            MostrarTaxi(autos);
                            break;
                        case 7:
                            MostrarOmnibus(omnibuses);
                            MostrarTaxi(autos);
                            break;
                        case 8:
                            Console.WriteLine("¿Queres salir de la app?[Si/No]");
                            datoIngresado = Console.ReadLine();
                            if(datoIngresado == "si" || datoIngresado == "Si" || datoIngresado == "SI")
                            {
                               Environment.Exit(0);
                            }
                            break;
                        default:
                            Console.WriteLine("entraste en la opcion incorrecta!");
                            break;
                    }
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (mensajeIngresado.ToLower() != "salir");

            Console.ReadKey();
        }

        public static int ValidarPasajeros(int cantidadMaximaDePasajeros)
        {
            Console.WriteLine("Ingrese cantidad de pasajeros:");
            string datoIngresado = Console.ReadLine();
            int datoNumerico;
            while (!int.TryParse(datoIngresado, out datoNumerico) || datoNumerico < 1 || datoNumerico > cantidadMaximaDePasajeros)
            {
                Console.WriteLine("Error. Debe ingresar un número.");
                datoIngresado = Console.ReadLine();

                if (datoIngresado.ToLower() == "salir")
                {
                    Environment.Exit(0);
                }
            }
            return datoNumerico;
        }

        public static string ValidarNombreOmnibus(List<Omnibus> transportes)
        {
            Console.WriteLine("Ingrese nombre de la unidad:");
            string nombre = Console.ReadLine();
            bool existeNombre;
            do
            {
                existeNombre = false;
                foreach (Omnibus bus in transportes)
                {
                    if (bus.Nombre == nombre)
                    {
                        Console.WriteLine("El nombre ya existe. Ingrese otro");
                        nombre = Console.ReadLine();
                        existeNombre = true;
                        break;
                    }
                }
            } while (existeNombre);
            return nombre;
        }
        public static string ValidarNombreTaxi(List<Taxi> transportes)
        {
            Console.WriteLine("Ingrese nombre de la unidad:");
            string nombre = Console.ReadLine();
            bool existeNombre;
            do
            {
                existeNombre = false;
                foreach (Taxi auto in transportes)
                {
                    if (auto.Nombre == nombre)
                    {
                        Console.WriteLine("El nombre ya existe. Ingrese otro");
                        nombre = Console.ReadLine();
                        existeNombre = true;
                        break;
                    }
                }
            } while (existeNombre);
            return nombre;
        }

        public static void MostrarOmnibus(List<Omnibus> omnibuses)
        {
            for (int i = 0; i < omnibuses.Count; i++)
            {
                Console.WriteLine("{0} {1} con {2} pasajeros", omnibuses[i].Avanzar(), omnibuses[i].Nombre, omnibuses[i].Pasajeros);
            }
        }

        public static void MostrarTaxi(List<Taxi> autos)
        {
            for (int i = 0; i < autos.Count; i++)
            {
                Console.WriteLine("{0} {1} con {2} pasajeros", autos[i].Avanzar(), autos[i].Nombre, autos[i].Pasajeros);
            }
        }
    }
}
