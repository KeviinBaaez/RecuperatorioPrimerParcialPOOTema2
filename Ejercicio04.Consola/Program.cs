using Ejercicio04.Datos;
using Ejercicio04.Entidades;
using MiDLL;

namespace Ejercicio04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioNumeros repositorio = new RepositorioNumeros();
            bool salir = false;

            int cantidad = ConsoleExtensions.ReadInt("Ingrese la cantidad: ");
            NumeroDivCincoSiete numeroDivCincoSiete = new NumeroDivCincoSiete(cantidad);

            for (int i = 0; i < cantidad; i++)
            {
                while (!salir)
                {
                    Console.WriteLine("\nMenú de Opciones:");
                    Console.WriteLine("1. Agregar Número ");
                    Console.WriteLine("2. Quitar Número ");
                    Console.WriteLine("3. Listar Números ");
                    Console.WriteLine("4. Buscar Número ");
                    Console.WriteLine("5. Sumar Números en el Repositorio");
                    Console.WriteLine("6. Salir");
                    Console.Write("Seleccione una opción: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Write("Ingrese el número a agregar: ");
                            if (int.TryParse(Console.ReadLine(), out int valorAgregar))
                            {
                                NumeroDivCincoSiete numero = new NumeroDivCincoSiete(valorAgregar);
                                var resultado = repositorio.AgregarNumero(numero);
                                Console.WriteLine(resultado.Item2);
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido.");
                            }
                            break;

                        case "2":
                            Console.Write("Ingrese el número a quitar: ");
                            if (int.TryParse(Console.ReadLine(), out int valorQuitar))
                            {
                                NumeroDivCincoSiete numero = new NumeroDivCincoSiete(valorQuitar);
                                var resultado = repositorio.QuitarNumero(numero);
                                Console.WriteLine(resultado.Item2);
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido.");
                            }
                            break;

                        case "3":
                            Console.WriteLine("\nNúmeros en el Repositorio:");
                            Console.WriteLine(repositorio.MostrarNumeros());
                            break;

                        case "4":
                            Console.Write("Ingrese el número a buscar: ");
                            if (int.TryParse(Console.ReadLine(), out int valorBuscar))
                            {
                                NumeroDivCincoSiete numero = new NumeroDivCincoSiete(valorBuscar);
                                var resultado = repositorio.FormaParte(numero);
                                if (resultado.Item1)
                                {
                                    Console.WriteLine($"Número encontrado en la posición {resultado.Item2}");
                                }
                                else
                                {
                                    Console.WriteLine("Número no encontrado.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido.");
                            }
                            break;

                        case "5":
                            int suma = repositorio;
                            Console.WriteLine($"La suma de los números es: {suma}");
                            break;

                        case "6":
                            salir = true;
                            break;

                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                } 
            }
        }
    }
}
