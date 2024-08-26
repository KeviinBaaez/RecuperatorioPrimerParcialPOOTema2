using Ejercicio01.Entidades;
using MiDLL;

namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Cilindro!");

            int radio = ConsoleExtensions.ReadInt("Ingrese el valor del radio: ");
            int altura = ConsoleExtensions.ReadInt("Ingrese el valor de la altura: ");
            Cilindro cilindro = CrearCilindro(radio, altura);
            MostrarDatos(cilindro);
        }

        private static void MostrarDatos(Cilindro cilindro)
        {
            Console.WriteLine(cilindro.MostrarDatos());
        }

        private static Cilindro CrearCilindro(int radio, int altura)
        {
            return new Cilindro(radio, altura);
        }
    }
}
